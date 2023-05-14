using System;

namespace Macrodistrito_Composicion_lab121
{
    public class Macrodistrito
    {
        private String nombre;
        private int nroZonas;
        private Zona[] z = new Zona[100];

        public Macrodistrito(int nroZonas)
        {
            nombre = "Centro";
            this.nroZonas = nroZonas;
            for (int i = 0; i < nroZonas; i++)
            {
                z[i] = new Zona();
            }
        }

        public Macrodistrito(string nombre, int nroZonas)
        {
            this.nombre = nombre;
            this.nroZonas = nroZonas;
        }

        public void mostrar()
        {
            Console.WriteLine("========= Macrodistrito ========= ");
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("nroZonas: " + nroZonas);
            for (int i = 0; i < nroZonas; i++)
            {
                z[i].mostrar();
            }

        }

        public void zonasMasXhabiatantes(int x)
        {
            for (int i = 0; i < nroZonas; i++)
            {
                if (z[i].NroHabitantes > x)
                    Console.WriteLine(z[i].Nombre);
            }
        }

        public void agragarHabitantes(int k,String zonaX)
        {   
            // si se quiere aumente k habitantes al macroditrito de manera equitativa a cada zona este esl codigo: 
            // k = k - NroZonas;
            // while (k > 0)
            // {
            //     for (int i = 0; i < nroZonas; i++)
            //         if (k>0)
            //         {
            //             z[i].NroHabitantes++;
            //         }
            //     if (k>nroZonas)
            //     {
            //             k = k - nroZonas;
            //     }
            //     else
            //     {
            //         for (int i = 0; i < k; i++)
            //         {
            //             z[i].NroHabitantes++;
            //         }
            //         k = 0;
            //     }
            // }
            for (int i = 0; i < nroZonas; i++)
            {
                if (z[i].Nombre.Equals(zonaX))
                {
                    z[i].NroHabitantes = z[i].NroHabitantes + k;
                }
            }
        }

        public void mostrarZonaMayorNroHabiantes()
        {
            int mayor = 0;
            for (int i = 0; i < nroZonas; i++)
            {
                if (z[i].NroHabitantes > mayor)
                {
                    mayor = z[i].NroHabitantes;
                }
            }

            for (int i = 0; i < nroZonas; i++)
            {
                if (z[i].NroHabitantes == mayor)
                {
                    Console.WriteLine(Z[i].Nombre);
                }
            }
        }

        public string Nombre => nombre;

        public int NroZonas => nroZonas;

        public Zona[] Z => z;
    }
}