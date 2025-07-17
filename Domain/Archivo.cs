using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Archivo : ComponenteBase
    {
        public Archivo(string nombre) : base(nombre) { }
        public override void Mostrar(int indentacion = 0)
        {
            Console.WriteLine(new string('-', indentacion /*este + 2 borrar si usamos el otro*/+ 2) + "Archivo " + Nombre);
        }

        public override void Agregar(ComponenteBase componente)
        {
            throw new NotImplementedException("Solo los directorios pueden tener hijos.");
        }

    }
}
