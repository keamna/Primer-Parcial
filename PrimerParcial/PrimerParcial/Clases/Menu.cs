using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    internal class Menu
    {
        public static void principal()
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar Arreglos");
                Console.WriteLine("2- Ingresar Empleados");
                Console.WriteLine("3- Consultar Empleados");
                Console.WriteLine("4- Borrar Empleados");
                Console.WriteLine("5- Modificar Empleados");
                Console.WriteLine("6- Reportes");
                Console.WriteLine("7- Salir");
                Console.WriteLine("Digite una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Empleado.inicializarArreglos();
                        break;
                    case 2:
                        Empleado.ingresarEmpleados();
                        break;
                    case 3:
                        Empleado.consultarEmpleados();
                        break;
                    case 4:
                        Empleado.borrarEmpleados();
                        break;
                    case 5:
                        Empleado.modificarEmpleados();
                        break;
                    case 6:
                        subMenuReportes();
                        break;
                    case 7:
                        Console.WriteLine("Saliendo del Sistema...");
                        Console.WriteLine("Ha salido del Sistema");
                        Environment.Exit(0); // termina el programa
                        break;
                    default:
                        Console.WriteLine("*** Opción incorrecta *** ");
                        break;
                }

            } while (opcion != 7);

        }
        public static void subMenuReportes()
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("1- Listar Empleados");
                Console.WriteLine("2- Calcular Promedio de Salarios");
                Console.WriteLine("3- Salir");
                Console.WriteLine("Digite una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Empleado.reporteEmpleados();
                        break;
                    case 2:
                        Empleado.reporteCalcularPromedio();
                        break;
                    case 3:
                        principal();
                        break;
                    default:
                        Console.WriteLine("*** Opción incorrecta *** ");
                        break;
                }

            } while (opcion != 3);

        }


    }
}

