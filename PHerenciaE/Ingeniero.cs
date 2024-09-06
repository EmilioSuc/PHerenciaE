using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHerenciaE
{
        public class Ingeniero : EmpleadoBase
        {
            private string especialidad;

            public Ingeniero(string nombre, double salarioBase, string especialidad)
                : base(nombre, salarioBase)
            {
                this.especialidad = especialidad;
            }

            public override double CalcularBonificacion()
            {
               
                return salarioBase * 0.15;
            }

            public override void MostrarDetalles()
            {
                base.MostrarDetalles();
                Console.WriteLine($"Especialidad: {especialidad}");
            }
        }
    }

