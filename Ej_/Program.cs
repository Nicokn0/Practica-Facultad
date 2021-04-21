using System;

namespace Ej_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 39. Una institución educativa necesita evaluar la evolución de 5 materias correspondientes a primer, segundo y
           tercer año de carrera. (1. Matemática, 2. Lengua, 3 Historia, 4 Geografía, 5 Tecnología)
           Para realizar esta tarea se dispone de un listado, ordenado por Número de curso y Código de materia que
           contiene la siguiente información:
           • Número de curso (valores de 1 a 3)
           • Código de Materia (valores de 1 a 5)
           • Nota del Examen final de cada alumno

           Se pide informar:
           • Por cada materia se pide saber el promedio de nota de todo el curso
           • La cantidad de alumnos aprobados
           • La cantidad de alumnos desaprobados aprobados
           • La materia con mayor índice de aprobación
           • La materia con menor índice de aprobación*/


            string[] asignaturas = { "Matemática", "Lengua", "Historia", "Geografia", "Tecnología" };
            string alumno = "";
            int materiasigui = 0;
            int contadorProm = 0, cursosigui = 0, cantAprob = 0, cantDesaprobAprob = 0, flag = 0, flag2 = 0, nomMinIndiceAprob = 0,  nomMaxIndiceAprob = 0, curso = 0, materia = 0, x = 0, indiceAprob = 0, indiceDesaprob = 0, y = 0;
            float examenFinal = 0, promedioExamenFinal = 0, maxIndiceAprob = 0, minIndiceAprob = 0;

            Console.WriteLine("Ingrese número de curso (valores de 1 a 3).\n 1. 1° AÑO \n 2. 2° AÑO \n 3.3° AÑO \n Digite 0 para finalizar la carga");
            curso = int.Parse(Console.ReadLine());

            cursosigui = curso;

            while (curso !=0)
            {
                while(curso!=0 && curso == cursosigui)
                {

                    Console.WriteLine("Ingrese código de Materia (valores de 1 a 5). \n 1. MATEMATICAS  \n 2. LENGUA \n 3. HISTORIA \n 4. Geografia \n 5. Tecnologia \n  0. Para detener la carga");
                    materia = int.Parse(Console.ReadLine());

                    materiasigui = materia;

                    while (curso != 0 && curso == cursosigui && materia != 0)
                    {
                        while (curso != 0 && curso == cursosigui && materia != 0 && materia == materiasigui)
                        {
                            Console.WriteLine("Ingrese el nombre del alumno, para terminar la carga digite 000"); //Variable agregada para mayor entendimiento del ejercicio
                            alumno = Console.ReadLine();

                            
                            promedioExamenFinal = 0;

                            x = 0; // CONTADOR PARA GUARDAR LAS NOTAS QUE TIENEN APROBADAS
                            y = 0; // CONTADOR PARA GUARDAR LAS NOTAS DE LOS NO APROBADOS
                            contadorProm = 0;

                            while (!alumno.Equals( "000"))
                            {
                                Console.WriteLine("Ingrese la nota del Examen Final del alumno:");
                                examenFinal = float.Parse(Console.ReadLine());
                               
                                if (examenFinal >= 7)
                                {
                                    cantAprob = cantAprob + 1;
                                    x = x + 1;
                                }

                                else
                                {
                                    if (examenFinal < 7)
                                    {
                                        cantDesaprobAprob = cantDesaprobAprob + 1;
                                        y = y + 1;
                                    }
                                   

                                }

                               
                                promedioExamenFinal = promedioExamenFinal + examenFinal; // ACUMULADOR DE LAS NOTAS PARA LUEGO PODER SACARLAS.

                                contadorProm = contadorProm + 1; // CONTADOR PARA SACAR EL INDICE DE APROBACON

                                indiceAprob = (x * 100) / contadorProm; // INDICE DE APROBACION X = CONTADOR DE APROBADOS / CANTIDAD DE CONTADORES QUE INGRESARON

                                indiceDesaprob = (y * 100) / contadorProm; // IDEMA ARRIBA PERO CON LOS DE DESAPROBACION

                             

                                Console.WriteLine("Ingrese el nombre del alumno, para terminar la carga digite 000"); // Variable agregada para mayor entendimiento del ejercicio
                                alumno = Console.ReadLine();

                             

                            }

                            if (flag == 0) // PARA SACAR EL MAXIMO DE LAS MATERIAS QUE APROBARON
                            {
                                flag = 1;
                                maxIndiceAprob = indiceAprob;
                                nomMaxIndiceAprob = materia;
                            }

                            else
                            {
                                if (maxIndiceAprob < indiceAprob)
                                {
                                    maxIndiceAprob = indiceAprob;
                                    nomMaxIndiceAprob = materia;
                                }
                            }

                                minIndiceAprob = indiceDesaprob;
                               nomMinIndiceAprob = materia; // borrarlo
                            
                           
                                if (minIndiceAprob > indiceDesaprob)
                                {
                                    minIndiceAprob = indiceDesaprob;
                                    nomMinIndiceAprob = materia;
                                }
                            


                            Console.WriteLine("Ingrese código de Materia (valores de 1 a 5). \n 1. MATEMATICAS  \n 2. LENGUA \n 3. HISTORIA \n 4. Geografia \n 5. Tecnologia \n Digite 000 para detener  la carga");
                            materia = int.Parse(Console.ReadLine());

                        } // aca termina el segundo corte de control.


                        Console.WriteLine($"En el curso {curso}, Materia {materiasigui}, la nota promedio fue {(promedioExamenFinal / contadorProm)}");
                        materiasigui = materia;
                        promedioExamenFinal = 0;
                        contadorProm = 0;
                        indiceAprob = 0;
                        indiceDesaprob = 0;
                      
                       

                        Console.WriteLine("Ingrese número de curso (valores de 1 a 3).\n 1. 1° AÑO \n 2. 2° AÑO \n 3.3° AÑO \n Digite 0 para finalizar la carga");
                        curso = int.Parse(Console.ReadLine());
                    }

                    cursosigui = curso;

                 


                }

 
            }

            Console.WriteLine($"En total, hay {cantAprob} Alumnos aprobados");

            Console.WriteLine($"En total, hay {cantDesaprobAprob} Alumnos desaprobados");

            Console.WriteLine($"La materia con mayor índice de aprobación es {asignaturas[nomMaxIndiceAprob - 1]} con un {maxIndiceAprob}%");

            Console.WriteLine($"La materia con menor índice de aprobración es {asignaturas[nomMinIndiceAprob - 1]} con un {minIndiceAprob}%");
            

        }
    }
}
