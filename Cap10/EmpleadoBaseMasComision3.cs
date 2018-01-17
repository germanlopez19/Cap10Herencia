using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10
{
    public class EmpleadoBaseMasComision3 : EmpleadoPorComision2
    {
        private decimal salarioBase;// Salario base por semana

        //constructor de la clase derivada con seis paramétros
        //Con una llamada al constructor de la clase base EmpleadpPorComision
        public EmpleadoBaseMasComision3(string nombre, string apellido, string nss,
            decimal ventas, decimal tarifa, decimal salario) : base(nombre, apellido, nss, ventas, tarifa)
        {

        }
    }
}
