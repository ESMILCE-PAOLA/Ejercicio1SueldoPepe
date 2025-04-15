using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio1SueldoPepe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos a Pepe como GERENTE, sin faltas,
            // con bono variable por presentismo y 10% por resultados
            Persona pepe = new Persona(
                nombre: "Pepe",
                categoria: new Gerente(),
                bonoPresentismo: new BonoPresentismoVariable(),
                bonoResultados: new BonoPorcentaje(),
                diasFaltados: 0
            );

            Console.WriteLine($"Sueldo de {pepe.Nombre} (gerente, sin faltas, 10% resultados): ${pepe.CalcularSueldo()}");

            // Ahora cambiamos a CADETE, con 1 falta,
            // y bono fijo de $80 por resultados
            pepe.Categoria = new Cadete();
            pepe.DiasFaltados = 1;
            pepe.BonoResultados = new BonoFijo();

            Console.WriteLine($"Sueldo de {pepe.Nombre} (cadete, 1 falta, $80 resultados): ${pepe.CalcularSueldo()}");

            // Cambiamos a que no tenga bono por presentismo ni resultados
            pepe.BonoPresentismo = new SinBonoPresentismo();
            pepe.BonoResultados = new SinBonoResultados();
            pepe.DiasFaltados = 2;

            Console.WriteLine($"Sueldo de {pepe.Nombre} (sin bonos, 2 faltas): ${pepe.CalcularSueldo()}");

            Console.ReadKey(); // Espera una tecla para cerrar la consola
        }
    }
}


