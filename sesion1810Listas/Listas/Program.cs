
//Listas/  Tupla = pueden ser varios elementos, datos heterogeneas
//Las listas son más flexibles permiten agregar, eliminar o editar
//EJ3
using System;
using System.Collections.Generic;


//sintaxis == List numeros o nombre de la lista = new List(){1,2,3,4,5}
//tuple = Tuple <int,string> = new Tuple
public class Diccionario
   {


      public static void Main(string[] args)
      {
         List<Tuple<string, string>> diccionario =  crearDiccionario(); //crear lista con Tuple y que esta sea igual a la funcion crearDiccionario
         traducir(diccionario);
         Console.ReadKey();




         Console.WriteLine("BIENVENIDO/A AL SISTEMA!");
      }

   //metodo crearDiccionario
   public static List<Tuple<string, string>> crearDiccionario() 
   {
      
      // Solicitar al usuario cuántas palabras desea ingresar
      Console.Write("¿Cuántas palabras desea agregar al diccionario? (Máximo 8): ");
      int numPalabras;

      // Validar la entrada del usuario
      while (!int.TryParse(Console.ReadLine(), out numPalabras) || numPalabras <= 0)
      {
         Console.Write("Ingrese un número válido de palabras: ");
      }

      // Si el usuario ingresa más de 8, limitar a 8
      if (numPalabras > 8)
      {
         Console.WriteLine("El máximo de palabras que puede agregar es 8. Se agregarán solo 8 palabras.");
         numPalabras = 8;
      }


      // Crear la estructura
      List<Tuple<string, string>> diccionario = new List<Tuple<string, string>>();

      for (int i = 0; i < numPalabras; i++)
      {
         Console.WriteLine($"Ingrese la palabra {i + 1} en inglés: ");
         string pala1 = Console.ReadLine();
         Console.WriteLine($"Ingrese la palabra {i + 1} en español: ");
         string pala2 = Console.ReadLine();

         // Añadirlas al diccionario
         diccionario.Add(new Tuple<string, string>(pala1, pala2));
      }

      return diccionario; // Retornamos la lista de tuplas

   }


   public static void traducir( List<Tuple<string, string>> diccionario) // como no va a retornar nada, a el le van a llegar los datos mas bien es void y no igual al anterior
   {
      
      char palabraSegui; // Declarar la variable fuera del bucle
      do
      {
         Console.Write($"Ingrese la palabra a traducir: ");
         string pal3 = Console.ReadLine();
         bool encontrado = false;

         // Recorrer el diccionario
         foreach (var duo in diccionario)
         {
            if (duo.Item1.Equals(pal3, StringComparison.OrdinalIgnoreCase)) // Compara con inglés
            {
               Console.WriteLine($"La traducción de la palabra {pal3} es: {duo.Item2}");
               encontrado = true;
               break;
            }
            if (duo.Item2.Equals(pal3, StringComparison.OrdinalIgnoreCase)) // Compara con español
            {
               Console.WriteLine($"La traducción de la palabra {pal3} es: {duo.Item1}");
               encontrado = true;
               break;
            }
         }

         if (!encontrado)
         {
            Console.WriteLine($"La palabra {pal3} no existe o no está registrada.");
         }

         // Preguntar si desea continuar
         Console.WriteLine("¿Desea traducir otra palabra? (s=si/n=no)");
          palabraSegui = (char)Console.Read(); // Leer un carácter
         Console.ReadLine(); // Limpiar el buffer de entrada

      } while (palabraSegui == 's' || palabraSegui == 'S'); // Continuar si el usuario ingresa 's' o 'S'




   }


}

