using System;

namespace practica1
{
    class Animales
    {
        //declaracion de datos de la Clase
        public string nombre;
        public string raza;
        public int edad;     
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Raza
        {
            get { return raza;}
            set { raza = value; }
        }
        public int Edad
        {
            get { return edad;}
            set
            {
                if (value >= 0)
                { edad = value; }
                else { Console.WriteLine("ERROR: Edad no debe ser negativa"); }
            }
        }
    }
    class Perro: Animales
    {
        //declaracion de datos de la Clase
        private string perrarinafav;
       public string Perrarinafav
        {
            get { return perrarinafav;}
            set
            { perrarinafav = value; }
        }
    }
    class Program

    {
        static void Main(string[] args)
        {
            Perro p = new Perro();

            Console.WriteLine("Nombre del Perro: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Raza del Perro: ");
            p.Raza = Console.ReadLine();
            Console.WriteLine("Edad del Perro: ");
            p.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Perrarina favorita del Perro: ");
            p.Perrarinafav = Console.ReadLine();

            Console.WriteLine("\n ===:Datos del Perro:=== \n");
            Console.WriteLine("Nombre: {0}", p.Nombre);
            Console.WriteLine("Raza: {0}", p.Raza);
            Console.WriteLine("Edad: {0}", p.Edad);
            Console.WriteLine("Perrarina favorita: {0}", p.Perrarinafav);
        }
    }
}
