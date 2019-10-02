using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectHorario
{
    public static class ReaderPDF
    {
        // Función ReadPDF:
        // Con este código podemos extraer toda la documentación de una página PDF por página y guardarla
        // en una cadena llamada 'texto' a través de la ubicación de la ruta del PDF.
        // Necesitamos cerrar el lector para los términos de memoria.
        public static string ReadPDF(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }
    }
}
