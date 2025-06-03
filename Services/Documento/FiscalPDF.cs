using System;
using System.IO;
using sistema_de_facturacion.Services.Facturacion;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Imaging;

namespace sistema_de_facturacion.Services.Documento
{
    internal class FiscalPDF : IFacturaGenerator
    {

        public void GenerarFactura(Factura factura)
        {
            string rutaArchivo = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"factura.pdf");

            NegocioInfo negocioInfo = new NegocioInfo();


            Document doc = new Document(PageSize.LETTER, 40f, 40f, 60f, 40f);
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));

            doc.Open();

            Font FontTabla = FontFactory.GetFont(FontFactory.HELVETICA, 8);
            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            PdfPTable encabezado = new PdfPTable(2);
            encabezado.WidthPercentage = 100;
            encabezado.SetWidths(new float[] { 3f, 1f });

            PdfPCell celdaDatos = new PdfPCell();
            celdaDatos.Border = Rectangle.NO_BORDER;

            Paragraph datos = new Paragraph();
            datos.Add(new Chunk("FACTURA\n", negrita));
            datos.Add(new Chunk("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy") + "\n", normal));
            datos.Add(new Chunk("Cliente: Juan Pérez\n", normal));
            datos.Add(new Chunk("Dirección: Calle Falsa 123\n", normal));

            celdaDatos.AddElement(datos);
            encabezado.AddCell(celdaDatos);

            // 1. Celda: Imagen (desde recurso)
            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.logoBN.Save(ms, ImageFormat.Jpeg);
                iTextSharp.text.Image logoPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                logoPdf.ScaleToFit(80f, 80f);

                PdfPCell celdaImagen = new PdfPCell(logoPdf, false);
                celdaImagen.Border = Rectangle.NO_BORDER;
                celdaImagen.HorizontalAlignment = Element.ALIGN_RIGHT ;
                celdaImagen.VerticalAlignment = Element.ALIGN_MIDDLE;

                encabezado.AddCell(celdaImagen);
            }

            doc.Add(encabezado);

            doc.Add(new Paragraph("\n"));

            PdfPTable tabla = new PdfPTable(6);
            tabla.HeaderRows = 1;

            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 3f, 1f, 1.5f, 1.5f, 1.3f,1f });

            tabla.AddCell(new PdfPCell(new Phrase("ARTICULO", FontTabla)));
            tabla.AddCell(new PdfPCell(new Phrase("CANTIDAD", FontTabla)));
            tabla.AddCell(new PdfPCell(new Phrase("PRECIO UNITARIO", FontTabla)));
            tabla.AddCell(new PdfPCell(new Phrase("DESCUENTO", FontTabla)));
            tabla.AddCell(new PdfPCell(new Phrase("IMPUESTOS", FontTabla)));
            tabla.AddCell(new PdfPCell(new Phrase("TOTAL", FontTabla)));


            foreach (Articulo item in factura.articulos)
            {
                tabla.AddCell(new PdfPCell(new Phrase(item.Descripcion.ToString(), FontTabla)));
                tabla.AddCell(new PdfPCell(new Phrase(item.Cantidad.ToString(), FontTabla)));
                tabla.AddCell(new PdfPCell(new Phrase(item.Precio.ToString("C2"), FontTabla)));
                tabla.AddCell(new PdfPCell(new Phrase(item.TotalDesc.ToString("C2"), FontTabla)));
                tabla.AddCell(new PdfPCell(new Phrase(item.ImpuestosAplicados.ToString("C2"), FontTabla)));
                tabla.AddCell(new PdfPCell(new Phrase(item.TotalNeto.ToString("C2"), FontTabla)));

            }

            doc.Add(tabla);


            PdfPTable pie = new PdfPTable(2);
            pie.WidthPercentage = 100;
            pie.SetWidths(new float[] { 4f, 4f });

            PdfPCell cellPieDatos = new PdfPCell();
            cellPieDatos.Border = Rectangle.NO_BORDER;

            Paragraph pieDatos = new Paragraph();
            pieDatos.Add(new Chunk("FACTURA\n", negrita));

            cellPieDatos.AddElement(pieDatos);

            pie.AddCell(cellPieDatos);

            //Tabla celda 2 del pie de página
            PdfPTable tblInnerTotales = new PdfPTable(2);
            tblInnerTotales.WidthPercentage = 100;
            tblInnerTotales.SetWidths(new float[] { 6f, 3f });

            //configuracion celda1
            PdfPCell cellInnerTotalesEtiquetas = new PdfPCell();
            cellInnerTotalesEtiquetas.HorizontalAlignment = Element.ALIGN_RIGHT;
            cellInnerTotalesEtiquetas.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellInnerTotalesEtiquetas.Border = Rectangle.NO_BORDER;

            Paragraph prgInnerTotalesEtiquetas = new Paragraph() { Alignment = Element.ALIGN_RIGHT }; 
            prgInnerTotalesEtiquetas.Add(new Chunk("Subtotal:\n", negrita));
            prgInnerTotalesEtiquetas.Add(new Chunk("IVA:\n", negrita));
            prgInnerTotalesEtiquetas.Add(new Chunk("Total a pagar:\n", negrita));

            //parrafo a celda
            cellInnerTotalesEtiquetas.AddElement(prgInnerTotalesEtiquetas);

            //configuracion celda2
            PdfPCell cellInnerTotalesValores = new PdfPCell();
            cellInnerTotalesValores.HorizontalAlignment = Element.ALIGN_RIGHT;
            cellInnerTotalesValores.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellInnerTotalesValores.Border = Rectangle.NO_BORDER;


            Paragraph prgInnerTotalesValores = new Paragraph() { Alignment = Element.ALIGN_RIGHT };
            prgInnerTotalesValores.Add(new Chunk($"${factura.Total}\n", negrita));
            prgInnerTotalesValores.Add(new Chunk($"${factura.TotalImpuesto}\n", negrita));
            prgInnerTotalesValores.Add(new Chunk($"${factura.TotalNeto}\n", negrita));

            //parrafo a celda
            cellInnerTotalesValores.AddElement(prgInnerTotalesValores);

            //Agrega celldas a la tabla interna 
            tblInnerTotales.AddCell(cellInnerTotalesEtiquetas);
            tblInnerTotales.AddCell(cellInnerTotalesValores);

            //crea la celda para el pie de página
            PdfPCell cellPieTotales = new PdfPCell();
            cellPieTotales.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellPieTotales.Border = Rectangle.NO_BORDER;

            //agrega la celda a la tabla
            cellPieTotales.AddElement(tblInnerTotales);
            pie.AddCell(cellPieTotales);

            doc.Add(pie);

            doc.Close();
        }

        public void MostrarArchivo() {

            string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/factura.pdf";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = rutaArchivo,
                UseShellExecute = true // Importante para que funcione bien en .NET Core o .NET 5+
            });
        }
    }
}
