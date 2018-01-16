using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea instancia de objeto EmpleadoPorComision
            EmpleadoPorComision empleado = new EmpleadoPorComision("Sue", "Jones", "222-22-222", 1000.00M, .06M);

            //Muestra datos del empleado por comision
            Console.WriteLine("Informacion del empleado obtenida por las propiedades y los métodos: \n");

            Console.WriteLine("{0} {1}", "El primer nombre es", empleado.PrimerNombre);
            Console.WriteLine("{0} {1}", "El primer nombre es", empleado.ApellidoPaterno);
            Console.WriteLine("{0} {1}", "El primer nombre es", empleado.NumeroSeguroSocial);
            Console.WriteLine("{0} {1:C}", "El primer nombre es", empleado.VentasBrutas);
            Console.WriteLine("{0} {1:F2}", "El primer nombre es", empleado.TarifaComision);
            Console.WriteLine("{0} {1:C}", "Los ingresos son:", empleado.Ingresos());
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
