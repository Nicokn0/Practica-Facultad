using System;

namespace Matrices_Ej1
{
    class EJ1_Matricez
    {
        static void Main(string[] args)
        {
            /*
             Se tiene un listado de las ventas de los 4 productos de los 7 días de la semana. Se pide crear un programa que
             almacene la venta individual de cada uno de estos. No hay certeza de la cantidad de ventas por dia ni por
            producto. Se sabe que el listado con los datos no se encuentra de forma ordenada.
            Se pide utilizar un arreglo que describa el nombre de los días
            Se pide utilizar un arreglo que describa el nombre de los productos
            Se pide almacenar las ventas totales por dia por producto en una matriz
            Se pide almacenar las ventas por producto utilizando una matriz
            Se pide poder listar las ventas totales de cada producto
            Se pide poder listar las ventas totales de cada día de la semana

             */

            string[] productos = inicializaString("productos");
            string[] dias = inicializaString("dias");

            float[,] ventas = new float[4, 7];
            int otraVenta = 0, prod = 0, dia = 0;
            float venta = 0;
            do
            {
                menu(1);
                otraVenta = int.Parse(Console.ReadLine());
                switch (otraVenta)
                {
                    case 1:
                        menu(3);
                        prod = int.Parse(Console.ReadLine());
                        prod--;
                        menu(2);
                        dia = int.Parse(Console.ReadLine());
                        dia--;
                        menu(4);
                        venta = float.Parse(Console.ReadLine());
                        ventas[prod, dia] = venta;
                        break;
                    case 2:
                        menu(5);
                        Listado(2, ventas, dias, productos);
                        break;
                    case 3:
                        menu(6);
                        Listado(3, ventas, dias, productos);
                        break;
                    case 0:
                        Console.WriteLine("fin del programa");
                        break;
                    default:
                        Console.WriteLine("opción inválida");
                        break;
                }

            } while (otraVenta != 0);


        }
        private static void Listado(int opt, float[,] auxVta, string[] dias, string[] productos)
        {
            Console.Clear();
            float vtaAcum = 0;
            if (opt == 2)
            {    //recorro las filas y luego por columnas
                for (int i = 0; i < 4; i++) // representa los productos
                {
                    for (int j = 0; j < 7; j++) // representa los dias
                    {
                        vtaAcum += auxVta[i, j];

                    }
                    Console.WriteLine($"El producto {productos[i]} tuvo una venta total de {vtaAcum}");
                    vtaAcum = 0;
                }
            }
            else
            {
                for (int i = 0; i < 7; i++) // recorremos cada columna (referidos a los dias)
                {
                    for (int j = 0; j < 4; j++) // recorremos cada fila (referidos a los productos)
                    {
                        vtaAcum += auxVta[j, i];

                    }
                    Console.WriteLine($"El dia {dias[i]} tuvo una venta total de {vtaAcum}");
                    vtaAcum = 0;

                }
            }
        }

        private static void menu(int opt)
        {
            string texto = "";
            switch (opt)
            {
                case 1:
                    texto = "Ingrese 1 para cargar las ventas\nIngrese 2 para listar las ventas por producto\nIngrese 3 para listar las ventas por día\n0 para terminar el programa";
                    break;
                case 2:
                    texto = "Ingrese el número del día [ 1 para el lunes 7 domingo]";
                    break;
                case 3:
                    texto = "Ingrese el número de producto [valores posible 1 a 4]";
                    break;
                case 4:
                    texto = "Ingrese valor de la venta";
                    break;
                case 5:
                    texto = "Listado de ventas totales por cada producto";
                    break;
                case 6:
                    texto = "Listado de ventas totales por cada día de la semana";
                    break;
            }
            Console.WriteLine(texto);
        }


        private static string[] inicializaString(string tipo)
        {
            string[] aux;
            if (tipo.Equals("dias"))
            {   // string [] aux = new string[7]
                aux = new string[] { "lunes", "martes", "miercoles", "jueves", "viernes", "sábado", "domingo" };
            }
            else
            {
                aux = new string[] { "Producto A", "Producto B", "Producto C", "Producto D" };
            }

            return aux;
        }

        
        private static float[,] inicializaFloat(int fila, int columna)
        {
            float[,] aux = new float[fila, columna];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    aux[i, j] = 0;
                }
            }
            return aux;
        }

    }
    }

