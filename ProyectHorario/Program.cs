using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectHorario
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Asus\Desktop\TI 1\Classroom\Horarios Sistemas II-2019.pdf";
            string text = ReaderPDF.ReadPDF(path);
            List<string> dataString = TextSplitter.RemoveUselessText(text);
            foreach (string line in dataString)
            {
                Console.Write(line);
                //Console.Write(dataString[0]);
            }

            Console.ReadKey();
        }
    }
}
