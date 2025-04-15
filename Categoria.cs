using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SueldoPepe
{
    // Clase base abstracta para la categoría de una persona
    public abstract class Categoria
    {
        // Propiedad abstracta que obliga a definir el sueldo en clases hijas
        public abstract double SueldoNeto { get; }
    }

    // Clase concreta Gerente
    public class Gerente : Categoria
    {
        public override double SueldoNeto => 2000;
    }

    // Clase concreta Cadete
    public class Cadete : Categoria
    {
        public override double SueldoNeto => 1000;
    }
}
