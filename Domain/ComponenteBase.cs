using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class ComponenteBase
    {

        public string Nombre { get; private set; }
        protected ComponenteBase(string nombre)
        {
            Nombre = nombre;
        }

        //pq lo que tiene este patron es que no respetamos la gerarquia habitual como en por ejemplo en repository
        //sino que todos herdan de componente base
        public abstract void Mostrar(int indentacion = 0);
        //esto es la cosa con la que sabemos si la jerarquia se sigue correctamente

        //este metodo no hace falta para la primer version que hicimos (lo que esta comentado en program)
        public virtual void Agregar(ComponenteBase componente)
        {
            throw new NotImplementedException("Solo los directorios pueden tener hijos.");
        }
    }
}
