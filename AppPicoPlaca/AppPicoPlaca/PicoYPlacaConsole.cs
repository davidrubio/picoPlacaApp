using AppPicoPlaca.Service;
using Entities;
using System;

namespace AppPicoPlaca
{
    class PicoYPlacaConsole
    {
        static void Main(string[] args)
        {
            do
            {
                //defined variables
                LicensePlateEntitie licensePlate = new LicensePlateEntitie();

                //head of program 
                Console.WriteLine("Consultor de Pico y Placa");
                Console.WriteLine("Por favor ingrese los datos a continuación");

                //principal form  
                Console.WriteLine("Placa: ");
                licensePlate.LicensePlateNumber = Console.ReadLine();
                Console.WriteLine("Fecha de salida (dd/mm/yyyy) : ");
                var dateGoOutString = Console.ReadLine();
                licensePlate.DateGoOut = Convert.ToDateTime(dateGoOutString.ToString());

                //result
                var havePicoYPlaca = PredictService.ProcessPicoYPlaca(licensePlate);
                if (havePicoYPlaca)
                    Console.WriteLine("El automóvil con placa " + licensePlate.LicensePlateNumber + " tiene pico y placa la fecha " + dateGoOutString);
                else
                    Console.WriteLine("El automóvil con placa " + licensePlate.LicensePlateNumber + " esta autorizado para circular la fecha " + dateGoOutString);


                Console.WriteLine("Para salir del programa presione Y, caso contrario presione cualquier tecla");
                var endApp = Console.ReadLine();
                if (endApp.ToUpper().Equals("Y"))
                    break;

            } while (true);
        }
    }
}
