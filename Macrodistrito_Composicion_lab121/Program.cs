using System;

namespace Macrodistrito_Composicion_lab121
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Macrodistrito M1 = new Macrodistrito(4);
            M1.Z[0].Nombre = "Cotahuma"; // setter
            M1.Z[0].NroHabitantes = 1000;
            M1.Z[1].Nombre = "centro";
            M1.Z[1].NroHabitantes = 5000;
            Console.WriteLine("-------- a) Instanciar un Macrodistrito con N zonas y mostra --------");
            M1.mostrar();
            Console.WriteLine("-------- b) Mostrar las zonas con más de X nrohabitantes --------");
            M1.zonasMasXhabiatantes(800);
            Console.WriteLine("-------- c) Agregar k habitantes a cada zona del Macrodistrito “Cotahuma” --------");  
            M1.agragarHabitantes(4000,"Cotahuma");
            M1.mostrar();
            Console.WriteLine("-------- d) Mostrar los nombres de las zonas con el mayor número de habitantes --------");
            M1.mostrarZonaMayorNroHabiantes();
        }                           
    }
}