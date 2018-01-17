using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10
{
    public class EmpleadoPorComision2
    {
        protected string primerNombre;
        protected string apellidoPaterno;
        protected string numeroSeguroSocial;
        protected decimal ventasBrutas;//ventas semanales totales
        protected decimal tarifaComision;//porcentaje de comisión

        //constructor con cinco parámetros
        public EmpleadoPorComision2(string nombre, string apellido, string nss, decimal ventas, decimal tarifa)
        {
            //la llamada implicita al constructor del objeto se realiza aqui 
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
            VentasBrutas = ventas; //valida las ventas brutas a través de una propiedad
            TarifaComision = tarifa;//valida la tarifa de comisión a través de una propiedad
        } //fin del constructor de EmpleadoPorComision2 con cinco parametros

        //Propiedad de sólo lectura que obtiene el primer nombre del empleado por comisión
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }
        }
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }
        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            }
        }
        public decimal  VentasBrutas{
            get
            {
                return ventasBrutas;
            }
            set
            {
                ventasBrutas = (value < 0) ? 0 : value;
            }// fin de set
        }
        public decimal TarifaComision
        {
            get
            {
                return tarifaComision;
            }
            set
            {
                tarifaComision = (value > 0 && value < 1) ? value : 0;
            }
        }
            //Calcula el sueldo del empleado por comisión
         public virtual decimal Ingresos()
         {
            return tarifaComision * ventasBrutas;
         }

        //devuelve representación string del objeto EmpleadoPorComision
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: 6:C}\n{7}: {8:F2}", "empleado por comision", primerNombre, apellidoPaterno,
                "número de seguro social", numeroSeguroSocial, "Ventas Brutas", ventasBrutas, "Tarifa de comisión", tarifaComision);
        }
    }
}
