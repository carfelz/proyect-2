using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_2
{
    class Alquiler
    {
        public string Direccion { get; set; }
        public string Color { get; set; }
        public string Area { get; set; }
        public string FechaConstruccion { get; set; }
        public int CantParqueos { get; set; }
        public int CantHabitaciones { get; set; }
        public int CantBaños { get; set; }
        public int PrecioMensual { get; set; }


        public void Alquilo()
        {
            Console.WriteLine("Se alquila Apartamento en {0}", Direccion);
            Console.WriteLine("\nCaracteristicas\n");
            Console.WriteLine("Color:" + Color);
            Console.WriteLine("Area en metros cuadrados:" + Area);
            Console.WriteLine("Fecha de contruccion:" + FechaConstruccion);
            Console.WriteLine("Cantidad de parqueos:" + CantParqueos);
            Console.WriteLine("Cantidad de habitaciones:" + CantHabitaciones);
            Console.WriteLine("Mensualidad:" + PrecioMensual);
            Console.ReadKey();
        }

        public void GetDatos()
        {
            Console.WriteLine("Ingrese los datos del apartamento: ");
            Console.WriteLine("Direccion:");
            Direccion = Console.ReadLine();

            Console.WriteLine("Color:");
            Color = Console.ReadLine();

            Console.WriteLine("Metros cuadrados (Area):");
            Area = Console.ReadLine();

            Console.WriteLine("Fecha en la que se construyo el apartamento:");
            FechaConstruccion = Console.ReadLine();

            Console.WriteLine("Cantidad de parqueos:");
            CantParqueos = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de habitaciones:");
            CantHabitaciones = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Alquiler mensual:");
            PrecioMensual = Int32.Parse(Console.ReadLine());
            Console.Clear();


        }
    }
}
