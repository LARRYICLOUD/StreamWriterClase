using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamWriterClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE");

            /*//Creamos un archivo
            FileStream fs = File.Create("Archivo con file.txt");

            //Cerramos el flujo
            fs.Close();*/

            //Instanciamos a SW y le mandamos el archvo a su constructor
            StreamWriter sw = new StreamWriter("Archivo con file.txt", true);

            //Write / WriteLine
            sw.WriteLine(" otro texto anexado");

            sw.Close();
        }
    }
}
