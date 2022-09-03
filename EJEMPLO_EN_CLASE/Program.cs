using System;
using System.Collections;

namespace proyecto_clase_teorica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents;
            ArrayList registro = new ArrayList();
            string nombre;
            int edad;
            int contador = 0;

            Console.WriteLine("Ingrese el número de estudiantes: ");

            numberStudents = int.Parse(Console.ReadLine());

            while (contador < numberStudents)
            {
                Console.WriteLine("Ingrese el nombre del estudiante: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());

                Students students = new Students() { Nombre = nombre, Edad = edad };

                registro.Add(students);

                contador++;
            }

            foreach (Students st in registro)
            {
                Console.WriteLine(st.getData());
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

}