using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Entity;
using System.IO;


namespace Infraestructura
{
    public class DocumentoPdf
    {
        public void GuardarPdf(IList<Cliente> clientes, string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create);
            Document document = new Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
            PdfWriter writer = PdfWriter.GetInstance(document, stream);
            document.AddAuthor("Aplicacion Veterinaria");
            document.Open();
            document.Add(new Paragraph("INFORME DE CLIENTES REGISTRADOS"));
            document.Add(new Paragraph("\n"));
            document.Add(LlenarTabla(clientes));
            document.Close();
        }

      

        private PdfPTable LlenarTabla(IList<Cliente> clientes)
        {
            PdfPTable tabla = new PdfPTable(5);
            tabla.AddCell(new Paragraph("Identificacion"));
            tabla.AddCell(new Paragraph("Nombre"));
            tabla.AddCell(new Paragraph("Apellido"));
            tabla.AddCell(new Paragraph("Telefono"));
            tabla.AddCell(new Paragraph("Direccion"));
            
            foreach (var item in clientes)
            {
                tabla.AddCell(new Paragraph(item.Identificacion));
                tabla.AddCell(new Paragraph(item.Nombre));
                tabla.AddCell(new Paragraph(item.Apellido));
                tabla.AddCell(new Paragraph(item.Telefono));
                tabla.AddCell(new Paragraph(item.Direccion));
           
            }




            return tabla;

        }
    }
}
