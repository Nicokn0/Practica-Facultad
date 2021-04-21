using System;

namespace Ej_44
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Se tienen los montos de ventas diarias de un comercio para n monto (de un mismo año). La información no está
               ordenada por mes, ni todos los monto registran ventas.
               Se necesita informar un listado ordenado por mes de los montos mensuales indicando primeros aquellos monto
              que no registraron ventas.
                                           */
            //ARREGLAR LOS MESES PORQUE PUSE QUE MARQUE TODOS LOS MESES Y EN REALIDAD TIENE QUE MOSTRAR LOS QUE EL USUARIO QUIERE

            int cantidad = 31; int j = 0;


            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", };

            RecibirString(meses);

            double[] monto = new double[cantidad];

            RecibirDouble(monto); // recorro monto mediante un metodo

            Cargardatos(meses, monto, j); // metodo para cargar datos

          
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Presione cualquier tecla para mostrar en pantalla los meses con sus respectivos montos");
            Console.ReadKey();

            Console.WriteLine("\n");


            for (int i = 0; i < meses.Length; i++)
            {
                
                MostrarDatos(meses, monto, i);
               
            }

            for (int i = 0; i < meses.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                MostrarMesesconventa(meses, monto, i);

            }
            Console.WriteLine("\n\n");
        }

        // METODOS 

        static void RecibirString(string[] aux)
        {
            for (int i = 0; i < 12; i++)
            {
                aux[i] = "";
            }
        } //INICIALIZO VECTOR STRING

        static void RecibirDouble(double[] aux) // Inicializo vector double
        {
            for (int i = 0; i < 12; i++)
            {
                aux[i] = 0;
            }
        }

        static void Cargardatos(string[] meses, double[] monto, int i) // Carga de meses 
        {
            double carga = 0; double acu = 0; int terminar = 0;



            Console.WriteLine("Ingrese 0 para comenzar la carga.");
            terminar = int.Parse(Console.ReadLine());

            while (terminar != 1 || i == 12)
            {
                Console.WriteLine($"Ingrese el mes que quiere cargar");
                meses[i] = Console.ReadLine();

                Console.WriteLine($"Ingrese los montos diarios correspondiente al mes: {meses[i]} ");
                carga = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese 0 para continuar la carga, 1 para finalizar el ingreso de meses");
                terminar = int.Parse(Console.ReadLine());

                acu = acu + carga;
                monto[i] = acu;
                acu = 0;
                i++;
            }

            
        }

        static void  MostrarDatos (string [] meses, double [] monto, int i )
        {
            string reporte = "";

            if (monto[i] == 0)
            {
               
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"\n El mes de {meses[i]} NO SE REGISTRARON VENTAS ");
               
            }
           
        }

        static void MostrarMesesconventa (string [] meses, double [] monto, int i)
        {

            if (monto[i] > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine($"\n El mes de {meses[i]} tuvo un gasto de : {monto [i]} ");
            }
        }



    }
    }

