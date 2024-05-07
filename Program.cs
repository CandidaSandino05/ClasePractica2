using PracticaNumero2;

public class Programs
{
    static void Main(string[] args)
    {
        Console.WriteLine("Aplicacion de Gestion de Empleados");

        //Crear una lista para almacenar empleados 
        List<Empleado> listaEmpleados = new List<Empleado>();


        //Agregar empleados de ejemplo a la lista
        listaEmpleados.Add(new Empleado("Juan", 101, 30000, true));  //Empleado activo (true)
        listaEmpleados.Add(new Empleado("Maria", 102, 36000, true));
        listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false)); //Empleado inactivo (false)
        listaEmpleados.Add(new Empleado("Martha", 104, 29000, false));
        listaEmpleados.Add(new Empleado("Luz", 105, 31500, true));
        listaEmpleados.Add(new Empleado("Enrique", 106, 32800, false));


        //Mostrar los detalles de cada Empleado en la lista 

        foreach (var empleado in listaEmpleados)
        {
            empleado.MostrarDetalles();
        }


        //cambiar el estado de un empleado por su numero 
        //Numero de empleado a cambiar estado (106)


        int numeroEmpleadoCambiarEstado = 106;
        Empleado empleadoCambiarEstado = BuscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

        if (empleadoCambiarEstado != null)
        {
            //Cambiar el estado a activo (1) o inactivo (0)
            empleadoCambiarEstado.CambiarEstado(1);          //Cambiar a activo
            empleadoCambiarEstado.MostrarDetalles();         //Mostrar Detalles actualizados 
        }
        else
        {
            Console.WriteLine($"EMpleado con número {numeroEmpleadoCambiarEstado} no encontrado.");
        }



        //metodo para buscar empleado segun su numero de empleado 


        static Empleado BuscarEmpleado(List<Empleado> empleados, int numeroEmpleado)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.ObtenerNumeroEmpleado() == numeroEmpleado)
                {
                    return empleado;
                }

            }
            return null;         //Retorna null si no se encuentra ningun empleado con ese numero 
        }



    }



}
