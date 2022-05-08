using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Ordenamiento
{
    internal class Metodoinsercion
    {
        private int[] vector;

        public void ingresar()
        {
            Console.WriteLine("*Metodo de ordenamiento Insercion*");

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

        public void metodoinsercion()
        {
            int a=0;
            int b=0;
            for(int i=0;i < this.vector.Length; i++)
            {
                a= this.vector[i];
                b = i - 1;
                while (b >= 0 && this.vector[b] > a)
                {
                    this.vector[b + 1] = this.vector[b];
                    b--;
                }
                this.vector[b + 1] = a;
            }
        }
        public void ver()
        {
            string NombreArchivo = "metodoInsercion.txt";

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
