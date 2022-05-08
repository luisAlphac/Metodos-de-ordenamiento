// See https://aka.ms/new-console-template for more information
using Metodos_De_Ordenamiento;
int eleccion = 0;
do
{

    try
    {
        Console.WriteLine("Elige un metodo de ordenamiento");
        Console.WriteLine("1.   Metodo burbuja");
        Console.WriteLine("2.   Metodo shell");
        Console.WriteLine("3.   Metodo seleccion");
        Console.WriteLine("4.   Metodo insercion");
        Console.WriteLine("5.   Salir");
        eleccion = int.Parse(Console.ReadLine());
        switch (eleccion)
        {
            case 1:
                Metodoburbuja meburbuja = new Metodoburbuja();
                meburbuja.ingresar();
                meburbuja.metodobur();
                meburbuja.ver();
                break;
            case 2:
                Metodoshell meshell = new Metodoshell();
                meshell.ingresar();
                meshell.metodoshell();
                meshell.ver();
                break;
            case 3:
                Metodoseleccion meseleccion = new Metodoseleccion();
                meseleccion.ingresar();
                meseleccion.metodoseleccion();
                meseleccion.ver();
                break;
            case 4:
                Metodoinsercion meinsercion = new Metodoinsercion();
                meinsercion.ingresar();
                meinsercion.metodoinsercion();
                meinsercion.ver();
                break;
        }

    }
    catch (Exception)
    {
        Console.WriteLine("valor no valido");
    }
} while (eleccion != 5);



