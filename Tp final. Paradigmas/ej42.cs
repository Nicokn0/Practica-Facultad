using System;

namespace Tp_final._Paradigmas.__Cano__Cicirello__Soto
{
    class ej42
    {
        static void Main(string[] args)
        {
            /* 42. Se tienen los montos de ventas totales de los n primeros meses (definidos por el usuario), correspondiente a un
             mismo año de un comercio.
             Se quiere calcular e informar la venta promedio de esos meses.
             Así como el nombre del mes y el monto de la venta de aquellos meses en que la venta superó a la venta promedio calculada. Las
            ventas se encuentras ordenadas por mes ascendente (enero al mes indicado por el usuario). El usuario podría no
            requerir ningún informe indicando 0 como número de meses a procesar*/

            int cantidad = 0, actual = 0;
            double acumuladormonto = 0, resu = 0;


            int[] meses = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }; // DECLARO LOS MESES 


            Console.WriteLine("Indique la cantidad de meses que quiere informar sobre su venta"); // INGRESO LOS MESES A CARGAR VENTAS
            cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n MES 1 = ENERO // MES 2 = FEBRERO // MES 3 = MARZO // MES 4 = ABRIL // MES 5 = MAYO // MES 6 = JUNIO // MES 7 = JULI0 // MES 8 = AGOSTO// MES 9 = SEPTIEMBRE // MES 10 = OCTUBRE // MES 11 = NOVIEMBRE // MES 12 = DICIEMBRE ");
            Console.WriteLine("\n\n"); // LE MUESTRO AL USUARIO LOS NOMBRES DE LOS MESES EN RELACION CON LOS NUMEROS

            double[] monto = new double[cantidad]; // DECLARO QUE LOS MONTOS A INGRESAR ES LA MISMA CANTIDAD EN RELACION A LOS MESES A CARGAR.

            CargarMeses(cantidad, meses); // METODO PARA INGRESAR LOS MESES A CARGAR

            
            Ordenamiento(meses, cantidad, actual); // METODO PARA ORDENAR LOS MESES INGRESADOS

          
            for (int i = 0; i < cantidad; i++) // PARA INGRESAR MONTO
            {
                Console.WriteLine($"Ingrese el monto correspondiente al mes: {meses[i]} ");
                monto[i] = double.Parse(Console.ReadLine());

                acumuladormonto = acumuladormonto + monto[i];

            }
            
            Console.WriteLine("\n\n");

            resu = Promedio(acumuladormonto, cantidad); // FUNCION PARA SACAR EL PROMEDIO

            Console.WriteLine($"\t\t El valor promedio de los montos de cada mes fue de ${resu}");

            MostrarVentas(cantidad, meses, monto, resu); // METODO PARA QUE EL USUARIO MUESTRE SI QUIERE VER LOS RESULTADOS INGRESADOS EN RELACION AL PROMEDIO.

           
        }

        // Ejercicio N°42 MEtodos Y FUNCIONES ///////////////////////////


        static double Promedio(double acumonto, int cantidad)
        {

            double promedio = 0;

            promedio = acumonto / (double)cantidad;

            return (promedio);
        }

        static void Ordenamiento(int[] meses, int cantidad, int actual)
        {
            int j = 0;


            for (int i = 1; i < cantidad; i++)      // ordenamiento  de los meses 
            {
                actual = meses[i];

                for (j = i; j > 0 && meses[j - 1] > actual; j--)
                {
                    meses[j] = meses[j - 1];
                }

                meses[j] = actual;
            }
        }


        static void MostrarMeses(int[] meses, int i)
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

        static void Mostrarresu(int[] m, double[] valor, int i, double resultado)
        {
            int carga = 0;


            Console.WriteLine($"\n Si quiere observar el monto correspondiente al mes {m[i]}  marque 1. Marque 0 si quiere evitar la carga ");
            carga = int.Parse(Console.ReadLine());

            if (carga != 0)
            {

                Console.WriteLine($"\n MES :  {m[i]}  \n VENTA: ${valor[i]}");


                if (valor[i] >= resultado)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"\n El mes {m[i]} tuvo un valor de venta de $ {valor[i]} supero el valor de las ventas promedio.");
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;

                    Console.WriteLine($"\n El mes {m[i]}, tuvo un valor de venta de $ {valor[i]} .NO SUPERO el valor de las ventas promedio");
                }
            }

            else
            {
                Console.WriteLine("\n Usted ingreso 0. No se dara a conocer las ventas correspondientes a dicho mes ");

            }


        }


        static void CargarMeses(int cantidad, int[] meses)
        {

            for (int i = 0; i < cantidad; i++) // FOR PARA INGRESAR MESES A INFORMAR VENTAS 

            {
                Console.WriteLine("Ingrese los MESES (numeros) a informar ventas. ");
                meses[i] = int.Parse(Console.ReadLine());
            }
        }
        
       static void MostrarVentas(int cantidad, int []meses, double [] monto, double resu)
        {

            for (int i = 0; i < cantidad; i++) // PARA VISUALIZAR RESULTADOS Y QUE EL USUARIO DECIDA SI QUIERE MOSTRAR INFORMACION
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                while (i < cantidad)

                {
                    MostrarMeses(meses, i);

                    Mostrarresu(meses, monto, i, resu);

                    i++;
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////

    }
}

