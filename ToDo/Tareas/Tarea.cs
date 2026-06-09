namespace Tareas;
public class Tarea
{
    private string ?descripcion;
    private int tareaid;
    private int duracion;
    //PROPIEDADES
    public int Duracion { get=>duracion; set=>duracion=value; }
    public int TareaID { get => tareaid; set => tareaid = value; }
    public string ?Descripcion { get => descripcion; set => descripcion = value; } //?=indico que puede ser NULL
    //METODOS O FUNCIONES
    public void BuscarTarea(string descripcion)
    {
        
        if(this.Descripcion==descripcion)
        {
            Console.WriteLine($"Tarea ID: {this.TareaID} - Descripcion: {this.Descripcion} - Duracion: {this.Duracion}");
        }
    }
}