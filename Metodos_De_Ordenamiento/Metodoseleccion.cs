using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_De_Ordenamiento
{
    internal class Metodoseleccion
    {
        private int[] vector;

        public void ingresar()
        {
            Console.WriteLine("*Metodo de ordenamiento Seleccion*");
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

        public void metodoseleccion()
        {
            for (int i=0; i <this.vector.Length-1; i++)
            {
                int minimo = i;
                for(int b=i+1;b < this.vector.Length; b++)
                {
                    if(this.vector[b] < this.vector[minimo])
                    {
                        minimo = b;
                    }
                }
                if (i != minimo)
                {
                    int a = this.vector[i];
                    this.vector[i]=this.vector[minimo];
                    this.vector[minimo] = a;

                }
            }
        }
        public void ver()
        {
            string NombreArchivo = "metodoSeleccion.txt";

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
