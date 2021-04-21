using System;

namespace Ej_45
{
    class Ej45
    {
        static void Main(string[] args)
        {
            /* 45.Una agencia de autos nos pide confeccionar un programa que permita informar el estado de las ventas de la
          agencia por modelo de auto.
          Se nos provee la siguiente información:
           • Los modelos de autos están codificados numéricamente de 1 a 49.
           • Las descripciones de los modelos de los autos son cargados manualmente por un usuario.
           • Cada venta se registra con código de modelo, y el importe vendido. Las ventas no se realizan ordenadamente,
            ni tienen determinada su finalización de carga de forma preestablecida.

            Al final de del día se necesita contar con:
             • Listado de las ventas totales registradas por cada modelo de auto, este listado debe mostrar el código del modelo, Su
             descripción y el importe total vendido DEBE MOSTRAR SOLO LOS MODELOS QUE HAYAN REGISTRADO VENTAS.
              Incluyendo el encabezado de títulos tal como se muestra a continuación. 

            Modelo que registro la mayor venta unitaria. Se debe visualizar con leyenda “el modelo que registro la mejor venta
            fue <<modelo>> por <<importe>> pesos.” .
              Tomando el ejemplo suministrado debería visualizarse:
            El modelo que registró la mejor venta fue: Mondeo por 280000 pesos

            */

            int cantmodelos = 49; 
            
            double[] importe = new double[cantmodelos]; int opcion = 0;

            string[] descripcion = new string[cantmodelos];

            
            RecibirString(descripcion);
            RecibirDouble(importe);


          
            do
            {
                Console.WriteLine("\n 1.Ingrese descripcion de los automoviles \n2.Ingrese ventas \n 3. Listado de ventas totales. \n 4. Finalizar programa");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        CargarDescripcion(descripcion);

                        break;

                    case 2:
                        CargarVentas(importe);

                        break;

                    case 3:
                        Listadoventastotales(importe, descripcion);

                        break;

                    case 0:
                        Console.WriteLine("Finalizar programa");
                        break;

                } 
            }
            while (opcion != 0);


        }

        static void RecibirString(string[] aux) //INICIALIZO VECTOR STRING
        {
            for (int i = 0; i < 49; i++)
            {
                Console.WriteLine($"Ingrese descripcion para codigo del auto: {i + 1}");
                aux[i] = Console.ReadLine();
               
            }
        } 

        static void RecibirDouble(double[] aux)
        {
            for (int i = 0; i < aux.Length; i++)
            {
                aux[i] = 0;
            }
        } // INICIALIZO VECTOR double

        static void CargarDescripcion( string[] descripcion)
        {
            for (int i = 0; i < descripcion.Length; i++)
            {
                Console.WriteLine($"Ingrese descripcion para codigo del auto: {i+1}");
                descripcion[i] = Console.ReadLine();

            }

        }
        static void CargarVentas( double[] importe)
        {
            int carga = 0; int i = 0; double acu = 0; int modeauto = 0;

            Console.WriteLine($"Para cargar ventas marque 1, para finalizar la carga marque 99 ");
            carga = int.Parse(Console.ReadLine());

            while (carga != 99)
            {
                Console.WriteLine($"Ingrese  codigo del auto vendido entre 1 y 49 "); //  variable
               
                 modeauto  = int.Parse(Console.ReadLine());
                if (modeauto >= 49 && modeauto == 0)
                {
                    Console.WriteLine($"USTED ESTA INGRESANDO CODIGOS DE AUTOS INCORRECTOS. Ingrese  codigo del auto vendido entre 1 y 49 ");
                    modeauto = int.Parse(Console.ReadLine());
                    modeauto--;
                }
                else
                {
                    modeauto--;
                }

                Console.WriteLine($"Ingrese  el importe del auto vendido");
                importe[modeauto] += int.Parse(Console.ReadLine());
                


                Console.WriteLine($"Para continuar con las ventas marque 1, para finalizar la carga marque 99 ");
                carga = int.Parse(Console.ReadLine());

                
            }
        }
        // IMPORTE. LENGTH
        static void Listadoventastotales( double[] importe, string[] descripcion)
        {
            int flag = 0; double mayor = 0; string mventa = "";
            for (int i = 1; i < importe.Length; i++)
            {
                if (importe[i] > 0)
                {
                   
                    Console.WriteLine($"El auto {i+1}, descripcion: {descripcion[i]} se vendio a {importe[i]}");

                    if (mayor < importe[i])
                    {
                        mayor = importe[i];
                        mventa = descripcion[i];
                    }
                }
            }

            Console.WriteLine($"El auto MAYOR VENDIDO FUE  descripcion: {mventa} se vendio a {mayor}");
        }
    }
}

