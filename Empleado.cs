using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaNumero2
{
    public class Empleado
    {
        //Variables de la clase Empleados
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo; //Estado del Empleado 

        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroEmpleado { get => numeroEmpleado; set => numeroEmpleado = value; }
        public decimal Salario { get => salario; set => salario = value; }

        public decimal GetSalario()
        {
            return this.Salario;
        }
        public bool Activo { get => activo; set => activo = value; }



        //constructor para tres argumentos en los empleados 

        public Empleado(string Nombre, int NumeroDeEmpleado, decimal Salario, bool Activo)
        {
            this.nombre = Nombre;
            this.numeroEmpleado = NumeroDeEmpleado;
            this.salario = Salario;
            this.activo = Activo;

        }

        //Metodo para mostrar los detalles de los Empleados
        public void MostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Número de Empleado: {numeroEmpleado}, Salario: {salario:c}, Estado: {estado}");
        }

        //Obtener numero de Empleados 

        public int ObtenerNumeroEmpleado()
        {
            return this.numeroEmpleado;
        }

        //Metodo para cambiar el Estado del empleado 
        public void CambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true; //Activar empleado 
                Console.WriteLine("Empleado activado.");
            }
            else if (nuevoEstado == 0)
            {
                activo = false; //Desactivar empleado 
                Console.WriteLine("Empleado desactivado.");
            }
            else
            {
                Console.WriteLine("Estado no válido.");
            }



        }
    }

}