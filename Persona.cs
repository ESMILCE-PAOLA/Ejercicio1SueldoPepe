using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SueldoPepe
{
    public class Persona
    {
        // Atributos
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }
        public int DiasFaltados { get; set; }
        public IBonoPresentismo BonoPresentismo { get; set; }
        public IBonoResultados BonoResultados { get; set; }

        // Constructor
        public Persona(string nombre, Categoria categoria, IBonoPresentismo bonoPresentismo, IBonoResultados bonoResultados, int diasFaltados)
        {
            Nombre = nombre;
            Categoria = categoria;
            BonoPresentismo = bonoPresentismo;
            BonoResultados = bonoResultados;
            DiasFaltados = diasFaltados;
        }

        // Método para calcular el sueldo total
        public double CalcularSueldo()
        {
            double sueldoBase = Categoria.SueldoNeto;
            double bonoPres = BonoPresentismo.CalcularBono(DiasFaltados);
            double bonoRes = BonoResultados.CalcularBono(sueldoBase);
            return sueldoBase + bonoPres + bonoRes;
        }
    }
}

