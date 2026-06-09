namespace Calculadora
public enum TipoOperacion{
 Suma,
 Resta,
 Multiplicacion,
 Division,
 Limpiar // Representa la acción de borrar el resultado actual o el historial
}

public class Operacion{
private double resultadoAnterior; // Almacena el resultado previo al cálculo actual
private double nuevoValor; //El valor con el que se opera sobre el resultadoAnterior
private TipoOperacion operacion;// El tipo de operación realizada
 public double Resultado{
 /* Lógica para calcular o devolver el resultado */
 }
// Propiedad pública para acceder al nuevo valor utilizado en la operación

    // Constructor u otros métodos necesarios para inicializar y gestionar la operación
    public double ResultadoAnterior { get => resultadoAnterior; set => resultadoAnterior = value; }
    public double NuevoValor { get => nuevoValor; set => nuevoValor = value; }

    public void Operar()
    {
        int op;
        Console.Write("Seleccionar el tipo de operacion a realizar:");
        int.TryParse(Console.ReadLine(),out op);
        operacion=(TipoOperacion)(op);
    }
}
