using System;

namespace Ej_43
{
    class ej43
    {
        static void Main(string[] args)
        {
            /*  EJERCICIO 43
             
             Idem al ejercicio anterior pero se pide que el informe sea por mes descendente, (de aquellos meses que
             superaron la venta promedio)
             Además se solicitan informar el promedio de ventas de los meses que superaron la venta promedio total. (esto
             quiere decir por ejemplo si tenemos venta promedio de los 12 meses por $100, se pide informar el promedio de
             la venta de aquellos meses cuya venta superó al promedio)
             */


            int cantidad = 0, actual = 0, contador = 0;
            double acumuladormonto = 0, resu = 0, resupromedio = 0, acuventapromedio = 0; // DECLARO VARIABLES

            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // ARREGLO MESES



            Console.WriteLine("Indique la cantidad de meses que quiere informar sobre su venta");
            cantidad = int.Parse(Console.ReadLine()); // SABER CANTIDAD DE MESES A CARGAR 

            Console.WriteLine($"\n MES 1 = ENERO // MES 2 = FEBRERO // MES 3 = MARZO // MES 4 = ABRIL // MES 5 = MAYO // MES 6 = JUNIO // MES 7 = JULI0 // MES 8 = AGOSTO// MES 9 = SEPTIEMBRE // MES 10 = OCTUBRE // MES 11 = NOVIEMBRE // MES 12 = DICIEMBRE ");


            double[] monto = new double[cantidad];

            CargarMeses(cantidad, meses); // METODO CARGAR MESES 

            Ordenamiento(meses, cantidad, actual); //ORDENAMIENTO DEL MAS GRANDE AL MAS CHICO

            for (int i = 0; i < cantidad; i++) 
            {
                Console.WriteLine($"Ingrese el monto correspondiente al mes: {meses[i]} ");
                monto[i] = double.Parse(Console.ReadLine());

                acumuladormonto = acumuladormonto + monto[i];
            }

            resu = Promedio(acumuladormonto, cantidad); // FUNCION PROMEDIO 1

            Mostrar(resu); // METODO PARA MOSTRAR EL RESULTADO.
           

            Console.WriteLine("A continuacion se mostraran los meses en el cual se supero el valor promedio de venta");

            for (int i = 0; i < cantidad; i++)
            {

                Console.ForegroundColor = ConsoleColor.DarkRed;

                if (monto[i] >= resu)

                {
                    MostrarMeses(meses, i);

                    Mostrarresu(meses, monto, i, resu);

                    contador++;
                    acuventapromedio = acuventapromedio + monto[i];
                }
            }

            Console.WriteLine("\n\n");

            resupromedio = Promedio1(acuventapromedio, contador);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine($"El promedio de venta de los meses en el cual se supero dicho valor promedio fue de {resupromedio}");
            Console.WriteLine("\n\n");

            Console.WriteLine("Presione cualquier tecla para finalizar programa");

            Console.ReadKey();
        }

        // METODOS Y FUNCIONES.

        static double Promedio(double acumonto, int cantidad)
        {

            double promedio = 0;

            promedio = acumonto / (double)cantidad;

            return (promedio);
        } // PRIMER PROMEDIO

        static void Ordenamiento(int[] meses, int cantidad, int actual)
        {
            int j = 0;


            for (int i = 1; i < cantidad; i++)      // ordenamiento  de los meses 
            {
                actual = meses[i];

                for (j = i; j > 0 && meses[j - 1] < actual; j--)
                {
                    meses[j] = meses[j - 1];
                }

                meses[j] = actual;
            }
        } // ORDENAMIENTO

        static double Promedio1(double acumonto, int cantidad)
        {

            double promedio = 0;

            promedio = acumonto / (double)cantidad;

            return (promedio);
        } // FUNCION, PROMEDIO PARA SACAR EL PORENCENTAJE DE TODO LO QUE PASO

        static void MostrarMeses(int[] meses, int i) // METODO PARA CARGAR LOS MESES 
        {


            if (meses[i] == 1)
            {
                Console.WriteLine("\n Mes de ENERO");
            }
            else
            {
                if (meses[i] == 2)
                {
                    Console.WriteLine("\nMes de febrero");
                }
                else
                {
                    if (meses[i] == 3)
                    {
                        Console.WriteLine("\nMes de Marzo");
                    }
                }
                if (meses[i] == 4)
                {
                    Console.WriteLine("\nMes de Abril");
                }

                if (meses[i] == 5)
                {
                    Console.WriteLine("\nMes de Mayo");
                }
                if (meses[i] == 6)
                {
                    Console.WriteLine("\nMes de Junio");
                }
                if (meses[i] == 7)

                {
                    Console.WriteLine("\nMes de Julio");
                }
                if (meses[i] == 8)
                {
                    Console.WriteLine("\nMes de Agosto");
                }
                if (meses[i] == 9)
                {
                    Console.WriteLine("\nMes de Septiembre");
                }
                if (meses[i] == 10)
                {
                    Console.WriteLine("\nMes de Octubre");

                }
                if (meses[i] == 11)
                {
                    Console.WriteLine("\nMes de Noviembre");

                }
                if (meses[i] == 12)
                {
                    Console.WriteLine("\nMes de Diciembre");

                }

                i++;

            }


        }

        static void Mostrarresu(int[] m, double[] valor, int i, double resultado) // METODO PARA MOSTRAR LAS VENTAS QUE SUPERARON LASS VENTAS PROMEDIOS 
        {

            Console.WriteLine($"\n MES : {m[i]}  \n VENTA: ${valor[i]}");

            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine($"\n El mes {m[i]} tuvo un valor de ventas de ${valor[i]} supero el valor de las ventas promedio");


        }
        static void CargarMeses (int cantidad, int [] meses) // METODO PARA CARGAR MESES
        {
            for (int i = 0; i < cantidad; i++)

            {
                Console.WriteLine("\nIngrese los MESES a informar ventas.  ");
                meses[i] = int.Parse(Console.ReadLine());
            }
        }
        static void Mostrar(double resu) // METODO PARA MOSTRAR EL PROMEDIO DE TODOS LOS MESES INGRESADOS.
        {
            Console.WriteLine("\n\n");

            Console.WriteLine($"\n El valor promedio de los montos de cada mes fue de ${resu}");
            Console.WriteLine("\n\n");
        }
    
    }
    }

