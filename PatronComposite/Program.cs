using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace PatronComposite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directorio raiz = new Directorio("Raiz");

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Sistema de Archivos (Composite) ===\n");
                raiz.Mostrar();

                Console.WriteLine("\nOpciones:");
                Console.WriteLine("1. Agregar Directorio");
                Console.WriteLine("2. Agregar Archivo");
                Console.WriteLine("3. Salir");

                Console.Write("\nElige una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    AgregarElemento(raiz, true);
                }
                else if (opcion == "2")
                {
                    AgregarElemento(raiz, false);
                }
                else if (opcion == "3")
                {
                    break;
                }
            }
        }

        
        static void AgregarElemento(Directorio raiz, bool esDirectorio)
        {
            Console.Write("\nNombre del nuevo " + (esDirectorio ? "directorio" : "archivo") + ": ");
            string nombre = Console.ReadLine();

            // Por ahora, todo se agrega a la raíz
            if (esDirectorio)
                raiz.Agregar(new Directorio(nombre));
            else
                raiz.Agregar(new Archivo(nombre));

            Console.WriteLine($"{(esDirectorio ? "Directorio" : "Archivo")} '{nombre}' agregado con éxito.");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
            //esta muy bueno, pero quizas deberia hacer algo mas sencillo en program
            //funciona este codigo sin la necidad del metodo agragar dentro del composite, ya que no agrega nada pq lee los archivos y muestra la jerarquia correspondiente
           /* static void Main(string[] args)
        {

            Console.WriteLine("EJERCICIO MOTIVACIÓN COMPOSITE");

            Console.WriteLine("Ingrese la ruta del directorio a recorrer:");
            string path = Console.ReadLine();
            if (!Directory.Exists(path))
            {
                Console.WriteLine("El path no existe.");
                return;
            }
            Directorio raiz = ConstruirEstructuraDirectorio(new DirectoryInfo(path));
            Console.WriteLine("Estructura del directorio:");
            raiz.Mostrar();
            Console.ReadLine();

        }
        static Directorio ConstruirEstructuraDirectorio(DirectoryInfo dirInfo)
        {
            var directorio = new Directorio(dirInfo.Name);

            // Agregar archivos
            FileInfo[] archivos;
            try
            {
                archivos = dirInfo.GetFiles();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Acceso denegado a archivos en: {dirInfo.FullName}");
                archivos = new FileInfo[0];
            }

            foreach (var archivo in archivos)
            {
                directorio.Agregar(new Archivo(archivo.Name));
            }

            // Agregar subdirectorios recursivamente
            DirectoryInfo[] subdirs;
            try
            {
                subdirs = dirInfo.GetDirectories();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine($"Acceso denegado a directorios en: {dirInfo.FullName}");
                subdirs = new DirectoryInfo[0];
            }

            foreach (var subdir in subdirs)
            {
                // LLamada recursiva para construir el directorio hijo del directorio actual
                directorio.Agregar(ConstruirEstructuraDirectorio(subdir));
            }

            return directorio;
        }
    }
}*/
