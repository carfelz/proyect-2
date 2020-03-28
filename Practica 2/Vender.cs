using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_2
{
    class Vender
    {
        public string Direccion { get; set; }
        public string Color { get; set; }
        public string Area { get; set; }
        public string FechaConstruccion { get; set; }
        public int CantParqueos { get; set; }
        public int CantHabitaciones { get; set; }
        public int CantBaños { get; set; }
        public int Precio { get; set; }


        public void Vendo()
        {
            Console.WriteLine("Se vende apartamento en {0}", Direccion);
            Console.WriteLine("\nCaracteristicas\n");
            Console.Write("Color:" + Color);
            Console.Write("Area en metros cuadrados:" + Area);
            Console.Write("Fecha de contruccion:" + FechaConstruccion);
            Console.Write("Cantidad de parqueos:" + CantParqueos);
            Console.Write("Cantidad de habitaciones:" + CantHabitaciones);
            Console.Write("Costo:" + Precio);
            Console.ReadKey();
        }

        public void GetDatos()
        {
            Console.WriteLine("Ingrese los datos del apartamento: ");
            Console.WriteLine("Direccion:");
            Direccion = Console.ReadLine();

            Console.WriteLine("Color");
            Color = Console.ReadLine();

            Console.WriteLine("Metros cuadrados (Area)");
            Area = Console.ReadLine();

            Console.WriteLine("Fecha en la que se construyo el apartamento");
            FechaConstruccion = Console.ReadLine();

            Console.WriteLine("Cantidad de parqueos");
            CantParqueos = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Cantidad de habitaciones");
            CantHabitaciones = Int16.Parse(Console.ReadLine());

            Console.WriteLine("Precio");
            Precio = Int16.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();


        }
    }
}
