using System;
using System.Collections;

namespace PARCIAL_l
{
    class Program
    {
        private static double promedio;
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayList();
            ArrayList registro_2 = new ArrayList();
            string nombre;
            int edad;
            int notas;
            int notas_2;
            int nota_parcial;
            int continuar = 0;
            int contador = 0;

            Console.WriteLine("Ingrese el número de estudiantes: ");
            numberStudents = int.Parse(Console.ReadLine());
            contador = numberStudents;
            while (contador != 0 || continuar != 0)
            {
                contador--;     //Es mejor reducir el contador
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota del laboratorio 1");
                notas = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota del laboratorio 2");
                notas_2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa la nota de tu parcial");
                nota_parcial = int.Parse(Console.ReadLine());


                Students students = new Students() { Nombre = nombre, Edad = edad };
                registro.Add(students);
                Notas_students notas_students = new Notas_students() { Nota_1 = notas, Nota_2 = notas_2, Nota_parcial = nota_parcial };
                registro_2.Add(notas_students);

                promedio = (notas * .3) + (notas_2 * .3) + (nota_parcial * .4);

                if (contador == 0)
                {
                    Console.WriteLine("Ingresa 1 para repetir el proceso, (0 CERRAR)");
                    continuar = int.Parse(Console.ReadLine());

                    if (continuar == 1)
                    {
                        Console.Clear(); //Para limpiar la consola
                        Console.WriteLine("Ingrese el número de estudiantes: ");
                        numberStudents = int.Parse(Console.ReadLine());
                        contador = numberStudents;
                    }

                }

            }

            foreach (Students st in registro)
            {
                Console.WriteLine(st.getData());
            }
            foreach (Notas_students st in registro_2)
            {
                Console.WriteLine(st.getData());
            }
            if (promedio >= 6.0)
            {
                Console.WriteLine("APROBADO");
            }
            else if (promedio < 6.0)
            {
                Console.WriteLine("REPROBADO");
            }



        }
    }

    public class Students
    {
        private string _nombre;
        private int _edad;

        public string Nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public int Edad
        {
            get => _edad;
            set => _edad = value;
        }

        public string getData()
        {
            return "Nombre: " + _nombre + " Edad: " + _edad;
        }

    }
    public class Notas_students
    {
        private int _notas;
        private int _notas_2;
        private int _nota_parcial;

        public int Nota_1
        {
            get => _notas;
            set => _notas = value;
        }

        public int Nota_2
        {
            get => _notas_2;
            set => _notas_2 = value;
        }

        public int Nota_parcial
        {
            get => _nota_parcial;
            set => _nota_parcial = value;
        }

        public string getData()
        {
            return "Nota_1: " + _notas + " Nota_2: " + _notas_2 + " Nota_Parcial: " + _nota_parcial;
        }
    }
}
