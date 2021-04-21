using System;

namespace Matricez_EJ3
{
    class Ej3_Matrices
    {
        static void Main(string[] args)
        {
            /*  Idem al ejercicio anterior pero se pueden vender 1 ,2, 3 ó cuatro productos por venta. (se cierra la venta con
            ingresando un producto ‘0000’
                                            */
            string[] productos = inicializaString("productos"); // COLUMNAS

            string[] cantventas = inicializaString("cant.ventas"); // FILAS 

            float[,] ventas = new float[30, 4]; // MATRIZ DECLARADA
            int opcion = 0, numproducto = 0, numventa = 0; // VARIABLE OPCION == PARA ELEGIR LA OPCION CORRECTA del MENU. NUMPRODUCTO (A,B,C,D) Y NUMVENTA PARA ESTABLECER EL N° VENTA Q VA DESDE EL 1 AL 30.
            float venta = 0;
            int numproductosigui = 0;

            do
            {
                menu(1); //METODO MENU, EN EL CUAL DESCRIBO QUE PUEDE PASAR SEGUN EL NUMERO CORRESPONDIENTE.
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:


                        menu(2); // Ingreso dato de las columnas, productos a ,b ,c y d
                        numproducto = int.Parse(Console.ReadLine());


                        numproductosigui = numproducto;

                        while (numproducto != 0000)
                        {
                            while (numproducto != 0000 && numproducto == numproductosigui) // CORTE DE CONTROL PARA FINALIZAR EN 0000
                            {

                                numproducto--;
                                menu(3); //Ingreso dato de las filas Numeros del 1 al 30;
                                numventa = int.Parse(Console.ReadLine());

                                if (numventa > 30) // IF PARA FINALIZAR LA CARGA YA QUE SE PERMITEN NUMEROS HASTA EL 30.
                                {
                                    Console.WriteLine("SUEPERO LA CARGA DE VENTA MAXIMA PERMITIDA DIARIA DE 30 UNIDADES.");

                                    Console.WriteLine("\n\n");
                                }

                                numventa--;

                                menu(4); // Cargo al igual que las anteriores 2 opciones, mediante el metodo MENU. El valor de las ventas

                                venta = float.Parse(Console.ReadLine());

                                ventas[numventa, numproducto] = venta; // DECLARE LA MATRIZ QUE EN TAL FILA Y COLUMNA Q INGRESE EL USARIO VA A DECIR TAL PRECIO

                                menu(2); // Ingreso dato de las columnas, productos a ,b ,c y d
                                numproducto = int.Parse(Console.ReadLine());

                            }
                            venta = 0; // REINICIO LAS VENTAS
                            numproductosigui = numproducto;
                        }



                        break;

                    case 2: // lista de cada columna referido al total en relacion a lo vendido $.

                        menu(5);
                        Listado(2, ventas, productos, cantventas);
                        break;

                    case 3: // lista de la columna en relacion con la cantidad vendida de cada producto (cant).
                        menu(6);

                        Listadocont(3, ventas, productos, cantventas, numproducto);

                        break;

                    case 4:
                        menu(7);
                        mostrarventas(4, ventas, productos, cantventas);
                        break;


                    case 0:

                        Console.WriteLine("FIN DEL PROGRAMA");
                        break;

                    default:
                        Console.WriteLine("opción inválida");
                        break;
                }
            }

            while (opcion != 000);
        }

        private static string[] inicializaString(string tipo) // inicializo string primero las columnas, luego las filas . FUNCION
        {
            string[] aux;
            if (tipo.Equals("productos"))
            {
                aux = new string[] { "Producto A", "Producto B", "Producto C", "Producto D" };
            }
            else
            {
                aux = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" };
            }

            return aux;
        }

        private static void menu(int opc) // METODO PARA MOSTRAR EN PANTALLA LAS OPCIONES DEL MENU.
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            string texto = "";
            switch (opc)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    texto = "Ingrese 1 para cargar las ventas \nIngrese 2 para listar las ventas por productos \nIngrese 3 para ver el listado de la cantidad de productos vendidos en total por dia.\nIngrese 4 par mostrar ventas ingresadas en el dia. \n0 para terminar el programa";
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Ingrese el número del producto [ 1 Producto A , 2. Producto B, 3. Producto C, 4. Producto D]. Para finalizar marque 0000";
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Ingrese el número de venta [valores posible 1 al 30]";
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Ingrese PRECIO UNITARIO VENDIDO";
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Listado de ventas totales por cada producto y producto que mayor dinero vendio";
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Listado cantidad total de productos vendidos";
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    texto = "Mostrar en pantalla ventas diarias en relacion producto y costo vendido";
                    break;
            }
            Console.WriteLine(texto);
        }

        private static void Listado(int opt, float[,] auxVta, string[] productos, string[] cantventas) // Referencia a las columnas y cantventas a las filas  
        {
            float mayorventa = 0; string mejorventa = "";
            Console.Clear();
            float vtaAcum = 0, mayor = 0;

            if (opt == 2)

            {
                for (int i = 0; i < 4; i++) // recorremos cada columna (referidos a los productos)
                {
                    for (int j = 0; j < 30; j++) // recorremos cada fila (referidos a los numeros del 1 al 30 )
                    {
                        vtaAcum += auxVta[j, i];


                        //sacar el maximo.
                        if (mayorventa < vtaAcum)
                        {
                            mayorventa = vtaAcum;
                            mejorventa = productos[i];
                            mayor = vtaAcum;
                        }


                    }

                    Console.WriteLine($"\t{productos[i]}\t IMPORTE VENDIDO");

                    Console.WriteLine($"\t \t \t \t ${vtaAcum}");



                    vtaAcum = 0;

                }


                Console.WriteLine("\n\n");

                Console.WriteLine($"El producto ({mejorventa}) fue el producto que mas ventas tuvo que fue de $ {mayor}");
                Console.WriteLine("\n\n");
            }

        }

        private static void Listadocont(int opt, float[,] auxVta, string[] productos, string[] cantventas, int numproducto) // producto hace referencia a las columnas y cantventas a las filas. Cuenta la cantidad de productos ingresados ademas de productos totaltes.
        {
            int cont = 0; int acu = 0;
            Console.Clear();

            if (opt == 3)

            {
                for (int j = 0; j < 4; j++) // recorremos cada fila (referidos a los productos)
                {

                    for (int i = 0; i < 30; i++)
                    {

                        if (auxVta[i, j] > 0)
                        {
                            cont++;
                        }
                    }

                    Console.WriteLine($"\t {productos[j]} \t CANTIDAD DE PRODUCTOS VENDIDOS");
                    Console.WriteLine($"\t \t \t \t {cont}");

                    acu += cont;

                    cont = 0;
                }
            }

            Console.WriteLine("\n\n");
            Console.WriteLine($"En el dia se vendieron un total de {acu} productos ");

            Console.WriteLine("\n\n");



        }

        static void mostrarventas(int opt, float[,] auxVta, string[] productos, string[] cantventas) // Metodo para mostrar la matriz
        {

            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine($"{productos[j]}");
                Console.Write("\n\n");

                for (int i = 0; i < 30; i++)
                {
                    Console.Write($"N° VENTA {cantventas[i]} :\t");

                    Console.Write($"{auxVta[i, j]} \t ");
                }
                Console.Write("\n\n");
                Console.Write("\n\n");
            }

        }

    }
}

