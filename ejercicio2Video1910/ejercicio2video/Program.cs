using System;
using System.Collections.Generic;

   public class Banco2
   {
      // Inicialización del saldo para todos las funciones
      static List<decimal> saldo = new List<decimal> { 0m }; // Comienza con saldo 0
   static void Main(string[] args)
      {
         int op = 0;
          
            Console.WriteLine("BIENVENIDO LA SISTEMA!");
      

      while (op != 4)
      { 
         Console.WriteLine("==========================================================");
         Console.WriteLine(" Eliga alguna de las siguientes opciones");
         Console.WriteLine("1. Agregar saldo a la cuenta");
         Console.WriteLine("2. Ver saldo actual de la cuenta");
         Console.WriteLine("3. Retirar");
         Console.WriteLine("4. Salir del programa");
         Console.WriteLine("==========================================================");
         op = int.Parse(Console.ReadLine());
         switch (op)
         {
            case 1:
               agregarSaldo();
            break;
            
            case 2:
               verSaldo();
            break;

            case 3:
               retirarSaldo();
             break;

            case 4:
               Console.WriteLine("Saliendo...");
            break;
            default:
               Console.WriteLine(" ERROR, vuelve a ingresar la opción");
            break;
         }
      }





      }

      static void agregarSaldo()
      {

         Console.WriteLine(" Ingrees la cantidad la cual quieres ingresar a la cuenta: ");
         if (decimal.TryParse(Console.ReadLine(), out decimal cantidad))
         {
            if (cantidad <= 0)
            {
                Console.WriteLine("Su saldo actual es de 0 dólares ");
            }
            else
            {
               saldo[0] += cantidad;
               saldo.Add(cantidad);
               Console.WriteLine(" Se ha ingresado correctamente la cantidad a la cuenta");
            }
        }
      }

    //===============================================================================================================================
      static void verSaldo()
      {
          Console.Write("BIENVENIDO AL APARTADO PARA VER SU SALDO");
          Console.WriteLine();
          Console.WriteLine($"Su saldo actual es de: {saldo[0]} dólares"); //se usa saldo[0] para ingresar al unico elemento de la lista
        
      }
    
   //==================================================================================================================================
      static void retirarSaldo()
      {
           
         Console.WriteLine(" BIENVENIDO AL APARTADO DE RETIRAR");
         Console.WriteLine();
         verSaldo();

         if (saldo[0] <= 0)
         {
            Console.WriteLine(" No tiene fondos");
         }
         else
         {
         Console.WriteLine(" Ingresa la cantidad a reitarar (la cuenta es el dólares)");
         if (decimal.TryParse(Console.ReadLine(), out decimal cantidad))
         {

            if (cantidad > 0)
            {
               if (saldo[0] <= 0)
               {
                  Console.WriteLine(" No tiene fondos que pueda retirar");
               }
               else
               {

                  saldo[0] -= cantidad;  // se usa el mismo saldo[0] ya que si no lo usamos y queremos volver a usar la función nos mostrara el valor inicial y no el restadp 
                  Console.WriteLine($" Tu saldo actual es de:{saldo[0]} ");
               }
            }
            else
            {
               Console.WriteLine(" La cantidad debe de ser mayor a 0");
            }






         }

         }  





      }
   }

