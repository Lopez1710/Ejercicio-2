using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; ;i++ ) {

                Console.WriteLine("Ingrese Su Nombre");
                string Nombre = Console.ReadLine();
                
                Console.WriteLine("Ingrese Su Edad ");
                int Edad = Convert.ToInt32(Console.ReadLine());
                

                Console.WriteLine("Ingrese su Genero Masculino = H, Femenino = F");
                string Sexo = Console.ReadLine();
               

                if (Sexo == "F")
                {
                    Console.WriteLine("La Sra. " + Nombre + " ha sido registrada");
                   
                }
                else if (Sexo == "f")
                {
                    Console.WriteLine("La Sra. " + Nombre + " ha sido registrado");
                   
                }
                else if (Sexo == "M")
                {
                    Console.WriteLine("El Sr. " + Nombre + " ha sido registrado");
                    
                }
                else if (Sexo == "m")
                {
                    Console.WriteLine("El Sr. " + Nombre + " ha sido registrado");
                    
                }
                Console.ReadKey(); 
            }
            
        }
    }
}
