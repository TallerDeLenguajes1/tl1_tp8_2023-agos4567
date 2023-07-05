using System;
using System.Collections.Generic;


  namespace ClasesGeneral{

    public class Tarea{

     private int idTarea;
     private int duracion;
     private string? descripcion;

        public int IDtarea { get => idTarea; set => idTarea = value; }
        
        public int Duracion { get => duracion; set => duracion = value; }

        public string? Descripcion { get => descripcion; set => descripcion = value; }
   
        }    
      
     public  class Funciones{
     public Funciones() {}





        public static void mostrarTareas( List<Tarea> listaDeTareas){
          if (listaDeTareas.Count==0)
          {
            Console.WriteLine("Esta lista esta vacia");
          }

         foreach (Tarea tarea in listaDeTareas)
       {
        Console.WriteLine("Id de la tarea:" + tarea.IDtarea);
        Console.WriteLine("Descripcion: " + tarea.Descripcion);
        Console.WriteLine("Duracion: " + tarea.Duracion);






        }



 }




      public static Tarea? BuscarTareaId(int idTarea, List<Tarea> listaDeTareasP,List<Tarea> listaDeTareasR){


        foreach (Tarea tarea in listaDeTareasP)
        {
            if (idTarea == tarea.IDtarea)
            {
                return tarea;
            }else
            {
              Console.WriteLine("ID no encontrado en lista de pendientes");
            }



        }



         foreach (Tarea tarea in listaDeTareasR)
        {
            if (idTarea == tarea.IDtarea)
            {
                return tarea;
            }else
            {
              Console.WriteLine("ID no encontrado en esta lista tampoco");
            }



        }
   
   
      return null;

      }


       public static Tarea? BuscarTareaClave(string? clave, List<Tarea> listaDeTareasP,List<Tarea> listaDeTareasR){

         Tarea BuscarTarea =new Tarea();


         foreach (Tarea tarea in listaDeTareasP)
        {
            if (tarea.Descripcion == clave)
            {
                BuscarTarea=tarea;
            }else
            {
              // Console.WriteLine("busca otra lista");
            }
        }


        foreach (Tarea tarea in listaDeTareasR)
        {
          if (tarea.Descripcion == clave)
            {
                BuscarTarea=tarea;
            }else
            {
              Console.WriteLine("No se encontro la tarea en esta lista tampco");
            }
        }


         return BuscarTarea;


       }



      public static void MoverTarea( List<Tarea> listaDeTareasPendientes, List<Tarea> listaDeTareasRealizadas){
     
          int idTarea;
          Console.WriteLine("Ingrese el ID de la tarea a mover:");
            idTarea=Convert.ToInt32(Console.ReadLine());

          foreach ( Tarea tareaP in listaDeTareasPendientes)
          {
          

             if (idTarea == tareaP.IDtarea)
             {
              listaDeTareasRealizadas.Add(tareaP);
             }

    


          }

          foreach (Tarea tareaRemover in listaDeTareasRealizadas)
             {
              listaDeTareasPendientes.Remove(tareaRemover);
             }

      }



        public static void Sumario(List<Tarea>  listaDeTareasRealizadas) 
    {
        int HorasTotal = 0; 
        StreamWriter file = new StreamWriter("sumario.txt"); 
        foreach (Tarea tarea in  listaDeTareasRealizadas) 
        {
            HorasTotal += tarea.Duracion; 
        }
        file.WriteLine($"Sumario: {HorasTotal}");
        file.Close(); 
    }

 }

  }
