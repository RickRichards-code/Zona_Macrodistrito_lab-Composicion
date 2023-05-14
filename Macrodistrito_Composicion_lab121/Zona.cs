using System;

namespace Macrodistrito_Composicion_lab121
{
    public class Zona
    {
        private String nombre;
        private int nroHabitantes;

        public Zona()
        {
            nombre = "SanPedro";
            nroHabitantes = 700;
        }

        public Zona(string nombre, int nroHabitantes)
        {
            this.nombre = nombre;
            this.nroHabitantes = nroHabitantes;
        }

        public void mostrar()
        {
            Console.WriteLine("---- Zona ----");
            Console.WriteLine("nombre: "+nombre+"\nnroHabitantes: "+nroHabitantes);
        }

        public void leer()
        {
            Console.WriteLine("---- ingrese los datos ---- ");
            Console.Write("ingresa nombre: ");
            nombre = Console.ReadLine();
            Console.Write("ingresa el nroHabitantes: ");
            nroHabitantes = int.Parse(Console.ReadLine());
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public int NroHabitantes
        {
            get => nroHabitantes;
            set => nroHabitantes = value;
        }
    }
}