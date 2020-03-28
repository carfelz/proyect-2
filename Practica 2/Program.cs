using System;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
      
            var alquiler = new Alquiler();
            var vender = new Vender();
            var acciones = new Acciones();
            acciones.Accion();
            int transcion;
            do
            {
                transcion = Int32.Parse(Console.ReadLine());
                
                if (transcion == 1)
                {
                    alquiler.GetDatos();
                    alquiler.Alquilo();
                }
                else if (transcion == 2)
                {
                    vender.GetDatos();
                    vender.Vendo();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR AL SELECCIONAR ACCION \n");
                    acciones.Accion();
                }
            } while( transcion > 2 );   
        }






    }
}
