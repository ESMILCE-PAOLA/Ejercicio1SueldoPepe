using PracticoObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ejercicio1SueldoPepe
{
    // Interfaz para el bono por resultados
    public interface IBonoResultados
    {
        double CalcularBono(double sueldoNeto);
    }

    // Bono fijo de $80
    public class BonoFijo : IBonoResultados
    {
        public double CalcularBono(double sueldoNeto)
        {
            return 80;
        }
    }

    // Bono de 10% del sueldo
    public class BonoPorcentaje : IBonoResultados
    {
        public double CalcularBono(double sueldoNeto)
        {
            return sueldoNeto * 0.10;
        }
    }

    // Sin bono
    public class SinBonoResultados : IBonoResultados
    {
        public double CalcularBono(double sueldoNeto)
        {
            return 0;
        }
    }
}
