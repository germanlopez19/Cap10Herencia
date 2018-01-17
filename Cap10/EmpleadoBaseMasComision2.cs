using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10
{
    public class EmpleadoBaseMasComision2 : EmpleadoPorComision
    {
        private decimal salarioBase; // salario base por semana

        //Constructor de la clase derivada con seis parametros
        //con una llammada al constructor de la clase base EmpleadoPorComision
        public EmpleadoBaseMasComision2( string nombre, string apellido,
            string nss, decimal ventas, decimal tarifa, decimal salario)
            : base(nombre, apellido, nss, ventas, tarifa)
        {
            salarioBase = salario; // valida el salario base a través de una propiedad 
        } // fin del constructor de EmpleadoBaseMasComision2 con seis parametros
        
        //propiedad que obtiene y establece 
        //el salario base del empleado por comisión con salario base
        public decimal SalarioBase
        {
            get
            {
                return salarioBase;
            } //fin de get

            set { salarioBase = (value < 0) ? 0 : value; }
        }//fin de salario base

        //calucla los ingresos
        public override decimal Ingresos()
        {
            //No se permite: tarifaComision y ventasBrutas son private en la clase base
            return salarioBase + (TarifaComision * VentasBrutas);
        }//fin del método Ingresos

        //devuelve representación string de EmpleadoBaseMasComision2
        public override string ToString()
        {
            //no se permite: trata de acceder a los miembros private de la clase base 
            return string.Format("{0}: {1} {2}\n {3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9} {10:C}",
                "Empleado por comisión con salario base", primerNombre, )
        }
    }
}
