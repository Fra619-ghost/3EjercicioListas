using System;
using System.Collections.Generic;



   public class Producto
 {
         static List<Tuple<int, string, int, decimal>> producto = new List<Tuple<int, string, int, decimal>>();
   static void Main(string[] args)
   {

      


      Console.WriteLine("BIENVENIDO AL SISTEMA!");
      int op;

        do
        {
         Console.WriteLine("=================================================");
         Console.WriteLine("Menú de opciones:");
         Console.WriteLine("1. Agregar productos");
         Console.WriteLine("2. Mostrar productos");
         Console.WriteLine("3. Eliminar producto");
         Console.WriteLine("4. Ver producto");
         Console.WriteLine("5. Modificar producto");
         Console.WriteLine("6. Salir");
         Console.WriteLine("=================================================");
         Console.WriteLine(" Por favor ingresar alguna de las opciones: ");
          op = int.Parse(Console.ReadLine());
            switch (op)
            {
               case 1: agregarProdu(); break;
               case 2: vertodosProduct(); break;
               case 3:; eliminarProdu();  break;
               case 4:; verProdu(); break;
               case 5:; modificarProdu(); break;
               case 6: Console.WriteLine(" Saliendo..."); break;
               default: Console.WriteLine(" ERROR selecciona una opción válida"); break;
            }
      }
        while (op != 6);
        

        
   }

     //==========================================================================================================================================
      static void agregarProdu()
      {

            Console.WriteLine("¿Cuántos productos desea agregar? (Máximo 8):");
            int cant;

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out cant) || cant <= 0)
            {
               Console.WriteLine("Ingrese un número válido de productos:");
            }

            for (int i = 0; i < cant; i++)
            {
               Console.WriteLine($"Produco número {i + 1}");
               Console.WriteLine(" Ingresar el código del producto:");
               int id = int.Parse(Console.ReadLine());
               Console.WriteLine(" Ingresar el nombre del producto:");
               string nomb = Console.ReadLine();
               Console.WriteLine(" Ingresar la cantidad en stock del producto:");
               int cantProdu = int.Parse(Console.ReadLine());
               Console.WriteLine(" Ingresar el precio del producto:");
               decimal price = decimal.Parse(Console.ReadLine());

               // Crear la tupla con los datos del producto que se quieren agregar
               Tuple<int, string, int, decimal> nuevoProducto = new Tuple<int, string, int, decimal>(id, nomb, cantProdu, price);

               //Agregar los datos a la dupla
               producto.Add(nuevoProducto);

               Console.WriteLine(" Producto agregado correctamente");

            }
      }


      static void vertodosProduct()
    {
        if (producto.Count == 0)
        {
         Console.WriteLine(" No hay productos que mostrar");
        }
      else
      {
            foreach (var productos in producto)
            {
              
               Console.WriteLine($"El código del producto es: {productos.Item1}");
               Console.WriteLine($"El nombre del producto es: {productos.Item2} ");
               Console.WriteLine($"La cantidad en stock es: {productos.Item3} ");
               Console.WriteLine($"El precio del producto es: {productos.Item4}");
         }  
      }
    }






      //=========================================================================================================================================
      static void eliminarProdu()
      {
            Console.WriteLine(" Bienvenido al apartado de eliminar producto!");
            Console.WriteLine(" Por favor, ingresa el id del producto que deseas eliminar:");
            int id2 = int.Parse(Console.ReadLine());

        bool encontrado = false;
        
      for(int i = 0;  i < producto.Count; i++)
      { 
         var product = producto[i]; // se utiliza para acceder a la lista de tuplas y el i para acceder a un punto en específico de la lista
            if (product.Item1 == id2)
            {
               Console.WriteLine($"El código del producto es: {product.Item1}");
               Console.WriteLine($"El nombre del producto es: {product.Item2} ");
               Console.WriteLine($"La cantidad en stock es: {product.Item3} ");
               Console.WriteLine($"El precio del producto es: {product.Item4}");
               producto.RemoveAt(i);

                  Console.WriteLine(" Producto eliminado exitosamente");
                   encontrado = true;
                  break;

            }
            if (!encontrado)
            {
               Console.WriteLine("No hay registro del producto con el ID ingresado.");
            }
      }

        
    }
   //===============================================================================================================================

   static void verProdu()
   {

      Console.WriteLine(" Bienvenido al apartado de eliminar producto!");
      Console.WriteLine(" Por favor, ingresa el id del producto que deseas eliminar");
      int id2 = int.Parse(Console.ReadLine());

      bool encontrado = false;

        foreach (var productos in producto)
        {
            if (productos.Item1 == id2)
            {
                     Console.WriteLine($"El código del producto es: {productos.Item1}, " +
                             $"El nombre del producto es: {productos.Item2}, " +
                             $"La cantidad en stock es: {productos.Item3}, " +
                             $"El precio del producto es: {productos.Item4}");
                 encontrado = true;
                   break;
            }

         if (!encontrado)
         {
            Console.Write($" El producto con id: {id2} no está en stock");
         }

      }


   }

   //=============================================================================================================================

    static void modificarProdu()
   {
      Console.WriteLine(" Bienvenido al apartado de modifcar producto");
      Console.WriteLine(" Ingresar el código del producto: ");
      int id3 = int.Parse(Console.ReadLine());

      bool encontrado = false;


      for (int i = 0; i < producto.Count; i++)
      {
         var productos = producto[i]; //sirve para acceder a un elemento en una colección producto usando el índice

         if (productos.Item1 == id3)
         {
            Console.WriteLine($"El código del producto es: {productos.Item1}");
            Console.WriteLine($"El nombre del producto es: {productos.Item2} ");
            Console.WriteLine($"La cantidad en stock es: {productos.Item3} ");
            Console.WriteLine($"El precio del producto es: {productos.Item4}");


            Console.WriteLine(" Deseas actualizar este producto?  (s = si / n = no)");
            char sentencia = Console.ReadKey().KeyChar;

            if (sentencia == 's' || sentencia == 'S')
            {
               producto.RemoveAt(i);


               Console.WriteLine("INGRESAR NUEVOS DATOS DEL PRODUCTO");
               Console.WriteLine("Ingresar código del producto del producto:");
               int cod = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingresar nombre del producto:");
               string nuevoNom = Console.ReadLine();
               Console.WriteLine("Ingresar cantidad en stock  del producto:");
               int cantNueva = int.Parse(Console.ReadLine());
               Console.WriteLine("Ingresar precio del producto:");
               decimal nuevoPrecio = decimal.Parse(Console.ReadLine());


               // Crear una nueva tupla con los nuevos datos
               //var nuevoProducto = new Tuple<int, string, int, decimal>(cod, nuevoNom, cantNueva, nuevoPrecio);  ESTE EJEMPLO DE VIDEO ES LO MISMO PERO DIFERENTE SINTAXIS, 
               Tuple<int, string, int, decimal> nuevoProducto = new Tuple<int, string, int, decimal>(cod, nuevoNom, cantNueva, nuevoPrecio);
               //Siempre se realiza cada que ingresemos un nuevo elemento 
               //Facilita la agrupación y almacenamiento de los datos del producto, nos asegura de que se puedan agregar nuevos elementos
               // a la lista


               producto.Add(nuevoProducto);
            }
            else
            {
               Console.Write(" La modificación ha sido cancelada");
            }


         }
         Console.WriteLine(" EL PRODUCTO SE ACTUALIZÓ CORRECTAMENTE!!");
         encontrado = true;
         break;

      }

      if (!encontrado)
      {
         Console.Write(" No se encontro producto a actualizar");
      }

      Console.WriteLine(" Ingresa los nuevos datos del producto: ");

   }
}

