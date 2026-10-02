using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            string codigo="", carrera="", bienvenido="";
            do {
                Console.Clear();//limpia la consola por cada ejecucion
                Console.WriteLine ("********MENU DE OPCIONES**********");
                Console.WriteLine ("1. Leer códogo de estudiante y carrera");
                Console.WriteLine ("2. Formar una nueva etiqueta textual con ambos(concatenado).");
                Console.WriteLine ("3. Mostrar longitud de caracteres del código carrera y etiqueta.");
                Console.WriteLine ("4. Mostrar el primer y último caracter del código.");
                Console.WriteLine ("5. Imprimir la carrera carácter por carácter.");
                Console.WriteLine ("6. Cree una nueva etiqueta de bienvenida agregada. ");
                Console.WriteLine ("7. Salir del Menu");
                opcion = int.Parse(Console.ReadLine());//opcion=7 , salir del menu
                switch (opcion) {
                    case 1:
                        Console.WriteLine("ingrese el código");
                        codigo = Console.ReadLine();
                        Console.Write("carrera: ");
                        carrera = Console.ReadLine();
                        break;

                    case 2:
                        bienvenido = codigo+"|carrera"+ carrera; //concatenar unir ambas cadenas
                        Console.WriteLine("etiquta generada: "+bienvenido);
                        break;
                    case 3:
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);//N000123 = ?
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud del saludo es: " + bienvenido.Length);
                        break;
                    case 4:// ingenieria  i  a
                        Console.WriteLine("el primero caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length-1]);
                        break;
                    case 7:Console.WriteLine("saliendo...");
                        break;
                    default: Console.WriteLine("opcion no valida");
                        break;
                }
                Console.ReadKey();//paurar y esperar que el usuario orecione el teclado para continuar
                
            }//7 distinto a 7!(true)
            while (opcion !=7);//> < >= ==  !=(distinto a)
        }
    }
}
