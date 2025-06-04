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

            Font normal = FontFactory.GetFont(FontFactory.HELVETICA, 7);
            Font negrita = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);

            doc.Add(new Paragraph(negocioInfo.Nombre, negrita));
            doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "\n", normal));
            doc.Add(new Paragraph("====================="));

            PdfPTable tabla = new PdfPTable(2);
            tabla.WidthPercentage = 100;
            tabla.SetWidths(new float[] { 3f, 1f });
            tabla.DefaultCell.Border = Rectangle.NO_BORDER;


            foreach (Articulo item in factura.articulos) {

                tabla.AddCell(new Paragraph(item.Descripcion, normal));
                tabla.AddCell(new Paragraph(item.TotalNeto.ToString("C2"), normal));
                tabla.AddCell(new Paragraph($"@x{item.Cantidad}", normal));
                tabla.AddCell(new Paragraph("", normal));
            }


            


            doc.Add(tabla);

            doc.Add(new Paragraph("====================="));
            doc.Add(new Paragraph($"Total: ${factura.TotalNeto}", negrita));
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
