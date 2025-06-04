using System;
using System.IO;
using sistema_de_facturacion.Services.Facturacion;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Imaging;
using System.Xml.Linq;

namespace sistema_de_facturacion.Services.Documento
{
    internal class FiscalPDF : PdfPageEventHelper, IFacturaGenerator
    {


        public class EncabezadoConstructor : PdfPageEventHelper
        {
            public PdfPTable Encabezado { get; set; }

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                if (Encabezado != null)
                {
                    // Ajustar ancho de la tabla al tamaño de página
                    Encabezado.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;

                    // Posicionar tabla (x, y)
                    float x = document.LeftMargin;
                    float y = document.PageSize.Height - 25;

                    // Dibujar tabla en la página
                    Encabezado.WriteSelectedRows(0, -1, x, y, writer.DirectContent);
                }


            }
        }

        public void GenerarFactura(Factura factura)
        {
            string rutaArchivo = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"factura.pdf");

            NegocioInfo negocioInfo = new NegocioInfo();


            Document doc = new Document(PageSize.LETTER, 40f, 40f, 120f, 40f);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));

            EncabezadoConstructor evento = new EncabezadoConstructor();
            evento.Encabezado = EncabezadoTabla(factura,negocioInfo);
            writer.PageEvent = evento;


            doc.Open();

            Font FontTabla = FontFactory.GetFont(FontFactory.HELVETICA, 8);
            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);


            PdfPTable tblArticulos = new PdfPTable(6);
            tblArticulos.HeaderRows = 1;

            tblArticulos.WidthPercentage = 100;
            tblArticulos.SetWidths(new float[] { 3f, 1f, 1.5f, 1.5f, 1.3f,1f });

            tblArticulos.AddCell(new PdfPCell(new Phrase("ARTICULO", FontTabla)));
            tblArticulos.AddCell(new PdfPCell(new Phrase("CANTIDAD", FontTabla)));
            tblArticulos.AddCell(new PdfPCell(new Phrase("PRECIO UNITARIO", FontTabla)));
            tblArticulos.AddCell(new PdfPCell(new Phrase("DESCUENTO", FontTabla)));
            tblArticulos.AddCell(new PdfPCell(new Phrase("IMPUESTOS", FontTabla)));
            tblArticulos.AddCell(new PdfPCell(new Phrase("TOTAL", FontTabla)));



            foreach (Articulo item in factura.articulos)
            {
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.Descripcion.ToString(), FontTabla)));
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.Cantidad.ToString(), FontTabla)));
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.Precio.ToString("C2"), FontTabla)));
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.TotalDesc.ToString("C2"), FontTabla)));
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.ImpuestosAplicados.ToString("C2"), FontTabla)));
                tblArticulos.AddCell(new PdfPCell(new Phrase(item.TotalNeto.ToString("C2"), FontTabla)));

            }


            doc.Add(tblArticulos);


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

        public PdfPTable EncabezadoTabla(Factura factura,NegocioInfo negocio) {

            PdfPTable tblEncabezado = new PdfPTable(2);
            tblEncabezado.WidthPercentage = 100;
            tblEncabezado.SetWidths(new float[] { 3f, 1f });

            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 10);
            Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            PdfPCell cellEncabezadoDatos = new PdfPCell();
            cellEncabezadoDatos.Border = Rectangle.NO_BORDER;

            Paragraph prgEncabezadoDatos = new Paragraph();
            prgEncabezadoDatos.Add(new Chunk($"# {factura.FacturaId}\n", negrita));
            prgEncabezadoDatos.Add(new Chunk("Fecha: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n", normal));
            prgEncabezadoDatos.Add(new Chunk($"Cliente: {factura.Cliente}\n", normal));
            prgEncabezadoDatos.Add(new Chunk($"Dirección: {negocio.Direccion}\n", normal));

            cellEncabezadoDatos.AddElement(prgEncabezadoDatos);
            tblEncabezado.AddCell(cellEncabezadoDatos);

            // 1. Celda: Imagen (desde recurso)
            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.logoBN.Save(ms, ImageFormat.Jpeg);
                iTextSharp.text.Image logoPdf = iTextSharp.text.Image.GetInstance(ms.ToArray());
                logoPdf.ScaleToFit(80f, 80f);

                PdfPCell celdaImagen = new PdfPCell(logoPdf, false);
                celdaImagen.Border = Rectangle.NO_BORDER;
                celdaImagen.HorizontalAlignment = Element.ALIGN_RIGHT;
                celdaImagen.VerticalAlignment = Element.ALIGN_MIDDLE;

                tblEncabezado.AddCell(celdaImagen);
            }


            return tblEncabezado;

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
