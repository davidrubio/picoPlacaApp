using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPicoPlaca
{
    class PicoYPlacaConsole
    {
        static void Main(string[] args)
        {
            //defined variables
            LicensePlateEntitie licensePlate = new LicensePlateEntitie();


            //principal structur of program
            Console.WriteLine("Consultor de Pico y Placa");
            Console.WriteLine("Por favor ingrese los Datos a continuación");

            Console.WriteLine("Placa (PDC-7662) : ");
            licensePlate.LicensePlateNumber = Console.ReadLine();
            Console.WriteLine("Fecha de salida (dd/mm/yyyy) : ");
            var dateGoOutString = Console.ReadLine();
            licensePlate.DateGoOut = Convert.ToDateTime(dateGoOutString.ToString());

            Console.WriteLine("sss : "+ licensePlate.LicensePlateNumber);
            Console.WriteLine("sss : "+ licensePlate.DateGoOut);




            Console.ReadKey();

        }
    }
}
