namespace PHerenciaE
{
    public class EmpleadoBase : Empleado, IEmpleadoBase
    {
        protected string nombre;
        protected double salarioBase;

        public EmpleadoBase(string nombre, double salarioBase)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
        }

        public virtual double CalcularBonificacion()
        {
          
            return salarioBase * 0.10;
        }

        public virtual void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {nombre}, Salario Base: {salarioBase:C2}");
        }
    }
}