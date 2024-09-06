using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHerenciaE
{
        public class Gerente : EmpleadoBase
        {
            private string departamento;

            public Gerente(string nombre, double salarioBase, string departamento)
                : base(nombre, salarioBase)
            {
                this.departamento = departamento;
            }

            public override double CalcularBonificacion()
            {
                return salarioBase * 0.20;
            }

            public override void MostrarDetalles()
            {
                base.MostrarDetalles();
                Console.WriteLine($"Departamento: {departamento}");
            }
        }
    }

