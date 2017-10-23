using System;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// Muestra el menú de la aplicación.
        /// </summary>
        static void MostrarMenu()
        {
            Console.WriteLine("Qué querés hacer?");
            Console.WriteLine();
            Console.WriteLine("1- Sumar dos números");
            Console.WriteLine("2- Multiplicar dos números");
            Console.WriteLine("0- Salir");
        }

        static int Sumar(int num1,int num2)
        {
            return num1 + num2 ;
        }

        static int Multiplicar(int num1,int num2)
        {
            return num1 * num2 ;
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculadora");
            MostrarMenu();
            int opcion = int.Parse(Console.ReadLine());
            while(opcion != 0)
            {                
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese numero: ");
                        int numero1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese numero: ");
                        int numero2 = int.Parse(Console.ReadLine());

                        int resultado = Sumar(numero1,numero2);
                        
                        Console.WriteLine("El resultado es: " + resultado); 

                        MostrarMenu();

                        break;
                    case 2:         
                        Console.WriteLine("Ingrese numero: ");
                        int numero3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese numero: ");
                        int numero4 = int.Parse(Console.ReadLine());

                        int resultado_mult = Multiplicar(numero3,numero4);
                        
                        Console.WriteLine("El resultado es: " + resultado_mult);  

                        MostrarMenu();          
                        break;
                    default:
                        Console.WriteLine("Opción inválida");                    
                        MostrarMenu();
                        opcion = int.Parse(Console.ReadLine());
                        break;            
                }
            }

            Console.WriteLine("Chau!!!!");
            Console.ReadKey();
        }
    }
}