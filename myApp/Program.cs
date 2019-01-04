using System;



namespace ejercicio_basicos_DDR_4
{
    class MainClass
    {

        

        
        public static void Main (string[] args)
        { 
            
         
         Console.Write("1º)Gestion de profesores" + "\n" + "2º)Gestion de estudiante" + "\n" + "3º)Gestion de periodos" + "\n" + "4º)Gestion de calificaciones" + "\n" + "5º)Salir" + "/n");
        
         Console.Write("\n Seleccione una opcion:");
                 Console.Clear();
         switch (Console.Read())
         {
              
             case '1':
            
             Console.Write("\n i. Crear nuevo profesor.");
             Console.Write("\n ii. Listar profesor.");
             Console.Write("\n iii. Borrar profesor.");
             Console.Write("\n iv. Listar las calificaciones de ese profesor en el formato (Nombre estudiante, Letra final, periodo."); 
             break;
            
             case '2':
            
             Console.Write("\n i. Crear nuevo estudiante.");
             Console.Write("\n ii. Listar estudiante.");
             Console.Write("\n iii. Modificar estudiante.");
             Console.Write("\n iv. Listar las calificaciones de ese estudiante.");
             break;
            
             case '3':
             
             Console.Write("\n i. Crear nuevo periodo.");
             Console.Write("\n ii. lista de periodo.");
             break;

             case '4':
           
             Console.Write("\n i. Crear nueva calificacion.");
             Console.Write("\n ii. Modificar calificacion.");
             Console.Write("\n iii. Listar calificaciones.");
             Console.Write("\n Seleccione una opcion:");
             Console.ReadKey();
             break;
           
            
             
             default: 
             Console.Write("\n NO ESTA DISPONIBLE..");
             break;

           
         }
          
        }
    }
}

     
         
     