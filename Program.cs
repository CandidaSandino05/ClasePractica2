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


        //Le solicitamos al usuario , el numero del empleado al que le haremos un aumento de sueldo.

        Console.Write("Digite el número del empleado al que se le aumentara el salario: ");

        //Creamos una variable donde guarda el numero de empleado ingresado.

        int numeroEmpleado = Convert.ToInt32(Console.ReadLine());

        // Cree una variabla llamada "EmpleadoSalarioNuevo" para poder ingresar a los metodos de la clase Generica

        Empleado empleado_salario_nuevo = BuscarEmpleado(listaEmpleados, numeroEmpleado);

        //Validamos con el if-else el numero del empleado que ingresamos
        if (empleado_salario_nuevo != null)
        {
            //Si el empleado existe 
            empleado_salario_nuevo.MostrarDetalles();

            //Le solicito al usuario el porcentaje a aumentar al salario del empleado
            Console.Write("Ingrese el porcentaje a aumentar: ");

            //Se crea la variable que guardara el porcentaje en aumentar
            decimal Porcentaje = Convert.ToDecimal(Console.ReadLine());


            /*Hacemos uso de la variable "Empleado" para ingresar al salario ya que esta en privada */

            decimal SalarioBase = empleado_salario_nuevo.GetSalario();

            //Hacemos el calculo porcentual para hacer el aumento al sueldo
            decimal SalarioNuevo = SalarioBase + (SalarioBase * (Porcentaje / 100));


            //Imprimmos el resultado 
            Console.WriteLine($"Aumento el salario en {Porcentaje} %. El salario nuevo es: {SalarioNuevo}");

        }
        else
        {
            //Si no existe 
            Console.WriteLine($"El empleado con el numero digitado {empleado_salario_nuevo} no existe");
        }





    }



}
