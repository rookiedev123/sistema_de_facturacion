using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_facturacion.Services.PdfGenerador
{
    internal class FacturaPDF
    {


        public void CrearFactura() {

            string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory+"/factura.pdf" ;

            Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            // Fuentes
            Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Font subTituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            Font textoFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

            // Título
            Paragraph titulo = new Paragraph("FACTURA", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(titulo);
            doc.Add(new Chunk("\n"));

            // Información de la empresa
            Paragraph empresa = new Paragraph("Empresa XYZ\nDirección: Calle Falsa 123\nTel: 555-1234\nCorreo: contacto@empresa.com", textoFont);
            empresa.Alignment = Element.ALIGN_LEFT;
            doc.Add(empresa);

            // Datos del cliente
            doc.Add(new Paragraph("\nCliente:\nNombre: Juan Pérez\nDirección: Calle Real 456\nCorreo: cliente@correo.com", textoFont));

            // Datos de la factura
            doc.Add(new Paragraph("\nFactura Nº: 0001\nFecha: " + DateTime.Now.ToShortDateString(), textoFont));
            doc.Add(new Chunk("\n"));

            // Tabla de productos/servicios
            PdfPTable tabla = new PdfPTable(4);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 40, 20, 20, 20 });

            // Encabezados
            tabla.AddCell(new PdfPCell(new Phrase("Descripción", subTituloFont)));
            tabla.AddCell(new PdfPCell(new Phrase("Cantidad", subTituloFont)));
            tabla.AddCell(new PdfPCell(new Phrase("Precio Unitario", subTituloFont)));
            tabla.AddCell(new PdfPCell(new Phrase("Total", subTituloFont)));

            // Filas de ejemplo
            tabla.AddCell("Producto A");
            tabla.AddCell("2");
            tabla.AddCell("$50.00");
            tabla.AddCell("$100.00");

            tabla.AddCell("Producto B");
            tabla.AddCell("1");
            tabla.AddCell("$80.00");
            tabla.AddCell("$80.00");

            // Total general
            PdfPCell celdaTotal = new PdfPCell(new Phrase("TOTAL", subTituloFont));
            celdaTotal.Colspan = 3;
            celdaTotal.HorizontalAlignment = Element.ALIGN_RIGHT;
            tabla.AddCell(celdaTotal);
            tabla.AddCell("$180.00");

            doc.Add(tabla);

            // Pie de página
            doc.Add(new Paragraph("\nGracias por su compra.", textoFont));
            doc.Close();
        }

        public void OpenFile() {

            string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/factura.pdf";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = rutaArchivo,
                UseShellExecute = true // Importante para que funcione bien en .NET Core o .NET 5+
            });
        }
    }
}
