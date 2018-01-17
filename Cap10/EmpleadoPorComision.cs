using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10
{
    public class EmpleadoPorComision : Object
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        private decimal ventasBrutas;//ventas semanales totales
        private decimal tarifaComision;//porcentaje de comision

        //Constructor con cinco parámetros
        public EmpleadoPorComision(string nombre, string apellido, string nss,
        decimal ventas, decimal tarifa)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            ventasBrutas = ventas; //Valida las ventas brutas mediante una propiedad
            tarifaComision = tarifa;//valida la tarifa de comision mediante una propiedad
        }  //fin frl constructor de EmpleadoPorComision con cinco parametros

        //propiedad de sólo lectura que obtiene el primer nombre del empleado por comision
        //numero de seguro social del empleado por comisión
        public string PrimerNombre
        {
            get { return primerNombre; }
        }
        public string ApellidoPaterno
        {
            get { return apellidoPaterno; }
        }
        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
        }
        public decimal VentasBrutas
        {
            get { return ventasBrutas; }

            set
            {
                ventasBrutas = (value < 0) ? 0 : value;
            }//Fin de ventas brutas
        }

        public decimal TarifaComision
        {
            get { return tarifaComision; }

            set
            {
                tarifaComision = (value < 0 && value < 1) ? value :0 ;
            }//Fin de la propiedad TarifaComision
        }
        //Calcula el salario del empleado por comision
        public decimal Ingresos()
        {
            return tarifaComision * ventasBrutas;
        }//Fin del método Ingresos

        //devuelve representacion string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}; {4}\n{5}: {6:C}\n{7}: {8:F2}",
                "empleado por comision", PrimerNombre, ApellidoPaterno, "numero de seguro social", NumeroSeguroSocial,
                "ventas brutas", VentasBrutas, "tarifa comision", TarifaComision);
        }//fin del metrodo ToString
    }//Fin de la clase EmpleadoPorComision
}
