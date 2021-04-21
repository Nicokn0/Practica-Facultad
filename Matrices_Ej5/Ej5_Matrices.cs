using System;

namespace Matrices_Ej5
{
    class Ej5_Matrices
    {
        static void Main(string[] args)
        {
            /* La oficina de atención al socio del club del Vino “La Logia” nos pidió ayuda para obtener informes de los 4
            centros de atención que tienen a lo largo de la provincia de Buenos Aires. Para tal fin tenemos que crear un
            programa que permita cargar por teclado la cantidad socios que fue atendida en cada centro. Estos centros
            abren sus puertas de lunes a sábado.
            Para optimizar las consultas se debe cargar los datos en una matriz, dejando la última columna para que
            almacene el total atendido del día y la última fila para que almacene la cantidad de socios atendidos por cada
            centro de atención.
            */

            string[] vcentros = { "Centro 1", "Centro 2", "Centro 3", "Centro 4", "Total por centro" }; // Declaro las columnas

            string[] vdias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Total por DIA" }; // Declaro las filas


            int[,] mRegistrodeSocios = new int[7, 5]; int opcion = 0; // Matriz

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Ingrese la opcion que desea operar.\n \n 1. Cargar ingreso de socios por dia segun centro correspondiente \n 2. Ver la cantidad de socios ingresados en un dia para un centro especifico. \n 3. Observar Cantidad TOTAL por Sucursal. \n 4. Observar cantidad TOTAL POR DIA \n 5. Cantidad total todas las sucrusales \n 0. Finalizar programa. ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Cargarsocios(mRegistrodeSocios, vcentros, vdias);

                        break;

                    case 2:
                        Console.Clear();
                        Informarcantsocios(mRegistrodeSocios, vcentros, vdias);


                        break;

                    case 3:
                        Console.Clear();
                        Informarcantsucursal(mRegistrodeSocios, vcentros);

                        break;

                    case 4:

                        Console.Clear();
                        Informarcantdia(mRegistrodeSocios, vdias);


                        break;

                    case 5:
                        Console.Clear();
                        Mostrartotal(mRegistrodeSocios);


                        break;
                    
                    case 0:
                        Console.WriteLine("FIN DEL PROGRAMA");
                        Console.Beep();
                        break;

                    default:

                        Console.WriteLine("Opcion invalida, re ingrese opcion");
                        break;
                }
            } while (opcion != 0);



        }




        private static void Cargarsocios(int[,] registro, string[] centros, string[] vdias) // cargar informacion 
        {

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Dia {vdias[i]}");

                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"Ingrese la cantidad de socios ingresados en el {centros[j]}:");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    registro[i, j] = int.Parse(Console.ReadLine());

                    registro[i, 4] += registro[i, j]; // guarda la info en la ultima columna
                    registro[6, j] += registro[i, j]; // guarda la info en la ultima fila 

                    registro[6, 4] = registro[6, j] + registro[i, 4];



                }


            }

        }

        private static void Informarcantsocios(int[,] registro, string[] centros, string[] vdias) // mostrar dia y centro especifico.
        {
            int fila = 0;
            int col = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Ingrese numero de centro a buscar \n1_{centros[0]}\n2_{centros[1]}\n3_{centros[2]}\n4_{centros[3]}");
            col = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("\n\n");

            Console.WriteLine("Ingrese el dia a consultar.1 Lunes / 2.Martes / 3.Miercoles / 4.Jueves / 5.Viernes / 6. Sabado");
            fila = int.Parse(Console.ReadLine());
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"El dia {vdias[fila - 1]} correspondiente al {centros[col - 1]} se registraron {registro[fila - 1, col - 1]} personas");
            Console.WriteLine("\n\n");

        }

        private static void Informarcantsucursal(int[,] registro, string[] centros) // mostrar centro especifico.
        {

            int col = 0;

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Ingrese numero de central a saber cantidad total de pacientes ingresados de lunes a sabado. \n1{centros[0]}\n2{centros[1]}\n3{centros[2]}\n4{centros[3]}");
            col = int.Parse(Console.ReadLine());
            Console.Beep();
            Console.WriteLine("\n\n");



            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"En el {centros[col - 1]} se registraron {registro[6, col - 1]} personas");
            Console.WriteLine("\n\n");

        }

        private static void Informarcantdia(int[,] registro, string[] vdias)
        {
            int fila = 0;


            Console.WriteLine("Ingrese el dia a consultar.1 Lunes / 2.Martes / 3.Miercoles / 4.Jueves / 5.Viernes / 6. Sabado");
            fila = int.Parse(Console.ReadLine());
            Console.Beep();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"El dia {vdias[fila - 1]}  se registraron {registro[fila - 1, 4]} personas");
            Console.WriteLine("\n\n");
        }
        private static void Mostrartotal(int[,] registro)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"La cantidad total de ingresos que se dieron en todos los centros fue de : {registro[6, 4]}");
            Console.WriteLine("\n\n");
        }

       
        }
    }

    

