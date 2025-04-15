using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1SueldoPepe
{
    // Interfaz para el bono por presentismo
    public interface IBonoPresentismo
    {
        double CalcularBono(int diasFaltados);
    }

    // Bono fijo de $200 si no faltó ningún día
    public class BonoPresentismoFijo : IBonoPresentismo
    {
        public double CalcularBono(int diasFaltados)
        {
            return diasFaltados == 0 ? 200 : 0;
        }
    }

    // Bono variable: $100 por cada día NO faltado (de 30 días)
    public class BonoPresentismoVariable : IBonoPresentismo
    {
        public double CalcularBono(int diasFaltados)
        {
            return diasFaltados == 0 ? 3000 : (30 - diasFaltados) * 100;
        }
    }

    // Sin bono
    public class SinBonoPresentismo : IBonoPresentismo
    {
        public double CalcularBono(int diasFaltados)
        {
            return 0;
        }
    }
}
