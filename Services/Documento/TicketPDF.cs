using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using sistema_de_facturacion.Services.Facturacion;

namespace sistema_de_facturacion.Services.Documento
{
    internal class TicketPDF : IFacturaGenerator
    {
        public void GenerarFactura(Factura factura)
        {
            string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/factura.pdf";
            NegocioInfo negocioInfo = new NegocioInfo();

            Document doc = new Document(new Rectangle(226f, 600f)); // 80mm aprox.
            PdfWriter.GetInstance(doc, new FileStream(rutaArchivo, FileMode.Create));
            doc.Open();

            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 9);
            Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10);

            doc.Add(new Paragraph("TIENDA XYZ", negrita));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy"), normal));
            doc.Add(new Paragraph("Hora: " + DateTime.Now.ToString("HH:mm:ss"), normal));
            doc.Add(new Paragraph("----------------------------------"));

            PdfPTable tabla = new PdfPTable(3);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 3f, 1f, 1f });

            tabla.AddCell("Producto");
            tabla.AddCell("Cant.");
            tabla.AddCell("Total");

            tabla.AddCell("Soda");
            tabla.AddCell("2");
            tabla.AddCell("$4.00");

            tabla.AddCell("Pan");
            tabla.AddCell("1");
            tabla.AddCell("$1.50");

            tabla.AddCell("Café");
            tabla.AddCell("1");
            tabla.AddCell("$2.00");

            doc.Add(tabla);

            doc.Add(new Paragraph("----------------------------------"));
            doc.Add(new Paragraph("TOTAL: $7.50", negrita));
            doc.Add(new Paragraph("¡Gracias por su compra!", normal));

            doc.Close();
        }

        public void MostrarArchivo()
        {
            string rutaArchivo = AppDomain.CurrentDomain.BaseDirectory + "/factura.pdf";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = rutaArchivo,
                UseShellExecute = true // Importante para que funcione bien en .NET Core o .NET 5+
            });
        }
    }
}
