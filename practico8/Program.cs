using System;
using System.IO;
using  System.Collections.Generic;//para poder trabajar con listas genericas



namespace  ObjectDirectory

   
{

   class Program
   {
    static void Main(string[] args)
    {

       Console.WriteLine("Ingrese la ruta de la carpeta:");
       string? rutaCarpeta=Console.ReadLine();

    
      string[] Archivos=Directory.GetFiles(rutaCarpeta);


        Console.WriteLine("- - - Archivos econtrados - - -");
          foreach (string archivo in Archivos)
        
          {

            string nomArchvios=Path.GetFileNameWithoutExtension(archivo);
            string ext=Path.GetExtension(archivo);
            Console.WriteLine($" {nomArchvios} ({ext})");
            
            //   Console.WriteLine($"Nombre: {Path.GetFileName(archivo)
            // }   - {Path.GetExtension(archivo)}");
            //     // Console.WriteLine($"Nombre: {Path.GetFileName(archivo)
            // } 
            
            //  ");


            

          }
           
              //guarde en un archivo csv (archivos separados por comas) llamado “index.csv”

            
           string ruteCvs=  Path.Combine(@"c:\Repogit\tp8\tl1_tp8_2023-agos4567\practico8", "index.csv");
          Console.WriteLine("Listado de archivos guardado en index.csv");
  
     
   
 
                  using (StreamWriter writer =new StreamWriter (ruteCvs))
                  {
                    writer.WriteLine("indice -nombre - extencion");

                   for (int i = 0; i < Archivos.Length; i++)
                   {
                     
                     string archivoNombre=Path.GetFileNameWithoutExtension(Archivos[i]);
                     string archivoExt=Path.GetExtension(Archivos[i]);
                    
                     writer.WriteLine($"{i +1}, {archivoNombre}, {archivoExt}");

                   }

 

                  }  

 

    }


 
          }


           }

           