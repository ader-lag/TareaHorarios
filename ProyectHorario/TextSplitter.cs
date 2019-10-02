using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectHorario
{
    public class TextSplitter
    {
        // Función RemoveUselessText:
        // En este código, primero guardamos una cadena completa en una matriz de cadenas separada por líneas de corte.
        // Luego verificamos si la línea no está vacía o solo tiene '(*)'
        // (No necesitamos ese símbolo en nuestros datos, consulte el pdf para obtener más información)
        // Finalmente verificamos si nuestro segundo y tercer carácter es un número, porque algunas líneas tienen fechas como
        // este '13 / 6/2019 'o este' 3/9/2019 '(el carácter' / 'no es un número) y no necesitamos fechas en nuestra cadena de datos.
        public static List<string> RemoveUselessText(string text)
        {
            string[] splittedText = text.Split('\n');
            List<string> splittedListText = new List<String>();
            foreach (string textLine in splittedText)
            {
                if (textLine != "" && textLine != "(*)")
                {
                    char secondChar = textLine.ToCharArray().ElementAt(1);
                    char thirdChar = textLine.ToCharArray().ElementAt(2);
                    if (char.IsNumber(secondChar) && char.IsNumber(thirdChar))
                    {
                        splittedListText.Add(textLine + '\n');
                    }

                }
            }
            return splittedListText;
        }
    }
}
