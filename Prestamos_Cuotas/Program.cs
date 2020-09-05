using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos_Cuotas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Este programa te calcula las cuotas de un prestamo

            double capital, interes, cuota;


            Console.WriteLine("< ESTE PROGRAMA TE CALCULA LAS CUOTA MENSUAL DE UN PRESTAMO >");
            Console.WriteLine("Digite la cantidad que desea tomar prestado  : ");
            capital = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite el interes del prestamos");
            interes = Convert.ToDouble(Console.ReadLine());

            cuota = (capital + interes)/12;

            Console.WriteLine("La cuota mensual para este prestamos segun el sistema frances es RD$ : "+ cuota);

            Console.ReadKey();
        }
        
    }
}
