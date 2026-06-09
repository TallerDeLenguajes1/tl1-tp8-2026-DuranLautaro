using Tareas;
//LISTAS DE TIPO TAREAS
List<Tarea> tareaspendientes= new List<Tarea>();
List<Tarea> tareasrealizadas= new List<Tarea>();
int N;



/*int opcion;
char seleccionar; 
do
{   
    Console.WriteLine("Desea realizar una tarea?[S:SI-N:NO]");
    char.TryParse(Console.ReadLine(), out seleccionar);
    seleccionar=char.ToUpper(seleccionar); //asigno la variable en mayusculas
    if(tareaspendientes.Count>0 && seleccionar=='S')
    {
        Console.Write("\nSeleccione la tarea a Realizar:");
        
    
}while(seleccionar=='S' && tareaspendientes.Count > 0);*/


int opcion,opcion1;
do
{
    Console.WriteLine("\n---MENU PRINCIPAL---");
    Console.WriteLine("1. Cargar tareas pendientes");
    Console.WriteLine("2. Listar tareas pendientes");
    Console.WriteLine("3. Listar tareas realizadas");
    Console.WriteLine("4. Agregar A Tarea realizada");
    Console.WriteLine("5. Buscar tarea por descripcion");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opcion:");
    int.TryParse(Console.ReadLine(), out opcion);
    switch(opcion) {
        case 0:
            Console.WriteLine("Saliendo del programa...");
        break;
        case 1:
            Console.WriteLine("Ingresar la cantidad de tareas a agregar:");
            int.TryParse(Console.ReadLine(), out N);
            for (int i=0;i<N;i++)
            {
                Tarea tpendiente=new Tarea(); //genero la tarea pendiente
                Console.Write($"Tarea {i+1}:\n");
                Console.Write("Ingresar descripcion de la tarea:");
                tpendiente.Descripcion=Console.ReadLine();
                tpendiente.TareaID=i+1;
                Console.Write("\nIngresar Duracion de la tarea[Entre 10-100]:");
                int duracion;
                do
                {   
                    int.TryParse(Console.ReadLine(),out duracion);
                    if(duracion>10 || duracion <100)
                    {
                        tpendiente.Duracion=duracion;
                    }
                    else
                    {
                        Console.Write("Duracion invalida. Reintentar\n");
                    }
                }while(duracion<10 || duracion>100);

                tareaspendientes.Add(tpendiente); //agrego a la lista tareaspendientes
            }
        break;
        case 2:
            Console.WriteLine("\n---Tareas Pendientes---");
            IEnumerator<Tarea> enumerador = tareaspendientes.GetEnumerator(); //GetEnumerator()=devuelve un enumerador que itera a través de la colección, es decir, devuelve un objeto que permite recorrer la lista de tareas pendientes
            while(enumerador.MoveNext()) //avanza sobre el elemento siguiente de la lista, devuelve true si hay un elemento siguiente y false si no lo hay
            {
                //Current=devuelve el elemento actual del enumerador, es decir, el elemento sobre el que se encuentra actualmente el enumerador
                Console.WriteLine($"Tarea ID:{enumerador.Current.TareaID} - Descripcion: {enumerador.Current.Descripcion} - Duracion: {enumerador.Current.Duracion}");
            }

        break;
        case 3:
            Console.WriteLine("\n---Tareas Realizadas---");
            IEnumerator<Tarea> enumerador2 = tareasrealizadas.GetEnumerator();
            while(enumerador2.MoveNext())
            {
                Console.WriteLine($"Tarea ID:{enumerador2.Current.TareaID} - Descripcion: {enumerador2.Current.Descripcion} - Duracion: {enumerador2.Current.Duracion}");
            }
        break;
        case 4:
            Console.WriteLine("Seleccione la tarea a realizar");
            int.TryParse(Console.ReadLine(), out opcion1);
            if(opcion<1 || opcion>tareaspendientes.Count)
            {
                Console.WriteLine("Seleccion invalida. Reintentar");
            }
            else
            {
                if(tareaspendientes.Count>0 && opcion<=tareaspendientes.Count)
                {
                    Tarea trealizada= tareaspendientes[opcion-1];
                    tareaspendientes.RemoveAt(opcion-1); //remuevo la tarea que ya se encuentra realizada
                    tareasrealizadas.Add(trealizada); //agrego a mi lista de tipo tarea la tarea realizada
                }
                else
                {
                    Console.WriteLine("No hay mas tareas para realizar o no deseo realizar mas tareas\n");
                }
            }
            
        break;
        case 5:
            Console.WriteLine("Ingresar descripcion a buscar:");
            string ?descripcion=Console.ReadLine();
            foreach(Tarea tarea in tareaspendientes)
            {
                tarea.BuscarTarea(descripcion);
            }
        break;
    }
}while(opcion!=0);
