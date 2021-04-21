using System;

namespace Ej_39
{
    class Ej_39
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

            int contadorProm = 0, cantAprob = 0, cantDesaprobAprob = 0, flag = 0, flag2 = 0, nomMinIndiceAprob = 0, nomMaxIndiceAprob = 0, curso = 0, materia = 0, x = 0, indiceAprob = 0, indiceDesaprob = 0, y = 0;
            float examenFinal = 0, promedioExamenFinal = 0, maxIndiceAprob = 0, minIndiceAprob = 0;

            Console.WriteLine("");
            Console.WriteLine("Una institución educativa necesita evaluar la evolución  de 5 materias correspondientes\n a primer, segundo y tercer año de carrera. (1. Matemática, 2. Lengua, 3 Historia, 4 Geografía, 5 Tecnología)");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese número de curso (valores de 1 a 3) digite 000 para parar la carga");
            curso = int.Parse(Console.ReadLine());
            Console.Clear();


            while (curso != 000)
            {
                Console.WriteLine("Ingrese código de Materia (valores de 1 a 5) digite 000 para parar la carga");
                materia = int.Parse(Console.ReadLine());
                


                while (materia != 000)
                {
                    Console.WriteLine("Ingrese el nombre del alumno, para terminar la carga digite 000"); //Variable agregada para mayor entendimiento del ejercicio
                    alumno = Console.ReadLine();
                    
                    promedioExamenFinal = 0;
                    x = 0;
                    y = 0;
                    contadorProm = 0;


                    while (alumno != "000")
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
                            if (examenFinal >= 4 && examenFinal < 7)
                            {
                                cantDesaprobAprob = cantDesaprobAprob + 1;

                            }
                            else
                            {
                                if (examenFinal < 7)
                                {
                                    y = y + 1;
                                }
                            }

                        }


                        Console.WriteLine("Ingrese el nombre del alumno, para terminar la carga digite 000"); //Variable agregada para mayor entendimiento del ejercicio
                        alumno = Console.ReadLine();

                        

                        promedioExamenFinal = promedioExamenFinal + examenFinal;
                        contadorProm = contadorProm + 1;
                    }

                    indiceAprob = (x * 100) / contadorProm;

                    indiceDesaprob = (y * 100) / contadorProm;


                    if (flag == 0)
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
                    if (flag2 == 0)
                    {
                        flag2 = 1;
                        minIndiceAprob = indiceAprob;
                        nomMinIndiceAprob = materia;
                    }
                    else
                    {
                        if (minIndiceAprob > indiceAprob)
                        {
                            minIndiceAprob = indiceAprob;
                            nomMinIndiceAprob = materia;
                        }
                    }

                    Console.WriteLine($"En el curso {curso}, Materia {materia}, la nota promedio fue {(promedioExamenFinal / contadorProm)}");

                    Console.WriteLine("Ingrese código de Materia (valores de 1 a 5) digite 000 para parar la carga");
                    materia = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ingrese número de curso (valores de 1 a 3) digite 000 para parar la carga");
                curso = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"En total, hay {cantAprob} Alumnos aprobados");

            Console.WriteLine($"En total, hay {cantDesaprobAprob} Alumnos desaprobados aprobados");

            Console.WriteLine($"La materia con mayor índice de aprobación es {asignaturas[nomMaxIndiceAprob - 1]} con un {maxIndiceAprob}%");

            Console.WriteLine($"La materia con menor índice de aprobración es {asignaturas[nomMinIndiceAprob - 1]} con un {minIndiceAprob}%");
            Console.ReadLine();

        }
          
}   
        }
    

