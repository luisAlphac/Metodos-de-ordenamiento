using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Ordenamiento
{
    internal class Metodoshell
    {

        private int[] vector;

        public void ingresar()
        {
            Console.WriteLine("*Metodo de ordenamiento Shell*");
            try
            {
                 int cantidad = 10;
                 int valor;
                 if (cantidad > 0)
                 {
                     this.vector = new int[cantidad];
                     for (int i = 0; i < this.vector.Length; i++)
                     {
                         Console.Write("ingrese el numero de la posicion " + (i + 1) + " : ");
                         valor = int.Parse(Console.ReadLine());
                         while (Repetido(valor, i))
                         {
                             Console.WriteLine("El numero : " + valor + " se encuentra agregado ");
                             Console.Write("Por favor digite un numero diferente: ");
                             valor = int.Parse(Console.ReadLine());
                         }
                         this.vector[i] = valor;
                         valor = 0;
                     }

                 }
             }
             catch (Exception e)
             {
                 Console.WriteLine("valor no permitido");
             }


        }
        bool Repetido(int valor, int i)
        {
            for (int x = 0; x < i; x++)
            {
                if (valor == vector[x])
                {
                   return true;
                }
            }
            return false;
        }

        public void metodoshell()
        {
            int saltos = 0;
            int a = 0;
            int aux = 0;
            int b = 0;
            saltos = this.vector.Length / 2;
            while (saltos > 0)
            {
                a = 1;
                while (a != 0)
                {
                    a = 0;
                    b = 1;
                    while (b <= (this.vector.Length - saltos))
                    {
                        if (this.vector[b - 1] > this.vector[(b - 1) + saltos])
                        {
                            aux = this.vector[(b - 1) + saltos];
                            this.vector[(b - 1) + saltos] = this.vector[b - 1];
                            this.vector[(b - 1)] = aux;
                            a = 1;
                        }
                        b++;
                    }
                }
                saltos = saltos / 2;
            }
        }
        public void ver()
        {
            string NombreArchivo = "metodoShell.txt";

            StreamWriter writer = File.AppendText(NombreArchivo);
            Console.WriteLine("Números en el arreglo");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i] + " ");
                writer.WriteLine(vector[i] + " ");
            }
            writer.Close();
            Console.ReadKey();

        }
    }

}
