using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Clases
{
    internal class Empleado
    {
        public static string[] nombre;
        public static string[] cedula;
        public static string[] direccion;
        public static string[] telefono;
        public static float[] salario;

        static Dictionary<int, List<int>> archivo = new Dictionary<int, List<int>>();

        public static int cantidadEmpleados = 0;


        public static void inicializarArreglos()
        {
            Console.WriteLine("Ingrese la cantidad de empleados: ");
            int tamano = int.Parse(Console.ReadLine());

            nombre = new string[tamano];
            cedula = new string[tamano];
            direccion = new string[tamano];
            telefono = new string[tamano];
            cedula = new string[tamano];
            salario = new float[tamano];

            for (int i = 0; i < tamano; i++)
            {
                nombre[i] = "";
                cedula[i] = "";
                direccion[i] = "";
                telefono[i] = "";
                salario[i] = 0;
            }

            cantidadEmpleados = 0;
            Console.WriteLine($"Sistema inicializado con {tamano} empleados");
            Console.Clear();
        }

        public static void ingresarEmpleados()
        {
            while (cantidadEmpleados < cedula.Length)
            {
                Console.WriteLine("Digite un nombre: ");
                nombre[cantidadEmpleados] = Console.ReadLine();
                Console.WriteLine("Digite la cédula: ");
                cedula[cantidadEmpleados] = Console.ReadLine();
                Console.WriteLine("Digite la dirección: ");
                direccion[cantidadEmpleados] = Console.ReadLine();
                Console.WriteLine("Digite el teléfono: ");
                telefono[cantidadEmpleados] = Console.ReadLine();
                Console.WriteLine("Digite un salario: ");
                salario[cantidadEmpleados] = float.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el número de la archivo donde se almacenarán los datos: ");
                int archivoSeleccionado = int.Parse(Console.ReadLine());

                if (!archivo.ContainsKey(archivoSeleccionado))
                {
                    archivo[archivoSeleccionado] = new List<int>();
                }

                archivo[archivoSeleccionado].Add(cantidadEmpleados); // Almacenamos el índice del producto
                cantidadEmpleados++;
                Console.Clear();
            }
        }


        public static void modificarEmpleados()
        {
            Console.Clear();
            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.WriteLine("Empleados ingresados: ");
                Console.WriteLine($"Nombre: {nombre[i]} Cédula: {cedula[i]}\n Dirección: {direccion[i]}\n Teléfono{telefono[i]}\n Salario: {salario[i]}");
            }

            Console.WriteLine("Ingrese \n 1- Modificar nombre \n 2- Modificar cédula \n 3- Modificar dirección\n 4- Modificar teléfono\n 5- Modificar salario");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    // Modificar nombre
                    Console.WriteLine("Digite el nombre del empleado que desea modificar: ");
                    string nombreviejo = Console.ReadLine();
                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (nombreviejo == nombre[i])
                        {
                            Console.WriteLine("Digite un nuevo nombre: ");
                            nombre[i] = Console.ReadLine();
                            Console.WriteLine($"Nombre actualizado: {nombre[i]}");
                            return;
                        }
                    }
                    Console.WriteLine("Nombre no encontrado");
                    break;

                case 2:
                    // Modificar cédula
                    Console.WriteLine("Digite la cédula del empleado que desea modificar: ");
                    string cedulaviejo = Console.ReadLine();
                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (cedulaviejo == cedula[i])
                        {
                            Console.WriteLine("Digite una nueva cédula: ");
                            cedula[i] = Console.ReadLine();
                            Console.WriteLine($"Cédula actualizada: {cedula[i]}");
                            return;
                        }
                    }
                    Console.WriteLine("Cédula no encontrada");
                    break;

                case 3:
                    // Modificar dirección
                    Console.WriteLine("Digite la dirección del empleado que desea modificar: ");
                    string direccionviejo = Console.ReadLine();
                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (direccionviejo == direccion[i])
                        {
                            Console.WriteLine("Digite una nueva dirección: ");
                            direccion[i] = Console.ReadLine();
                            Console.WriteLine($"Dirección actualizada: {direccion[i]}");
                            return;
                        }
                    }
                    Console.WriteLine("Dirección no encontrada");
                    break;

                case 4:
                    // Modificar teléfono
                    Console.WriteLine("Digite el número de teléfono del empleado que desea modificar: ");
                    string telefonoviejo = Console.ReadLine();
                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (telefonoviejo == telefono[i])
                        {
                            Console.WriteLine("Digite una nuevo número de teléfono: ");
                            direccion[i] = Console.ReadLine();
                            Console.WriteLine($"Teléfono actualizado: {telefono[i]}");
                            return;
                        }
                    }
                    Console.WriteLine("Teléfono no encontrado");
                    break;

                case 5:
                    // Modificar salario
                    Console.WriteLine("Digite el salario del empleado que desea modificar: ");
                    float salarioviejo = float.Parse(Console.ReadLine());
                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (salarioviejo == salario[i])
                        {
                            Console.WriteLine("Digite un nuevo salario: ");
                            salario[i] = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Salario actualizado: {salario[i]}");
                            return;
                        }
                    }
                    Console.WriteLine("Salario no encontrado");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }



        public static void consultarEmpleados()
        {
            Console.Clear();
            Console.WriteLine("*** REPORTE DATOS DE EMPLEADOS ***");


            foreach (var entry in archivo)
            {
                int archivoNumero = entry.Key;
                List<int> productosEnArchivo = entry.Value;

                Console.WriteLine($"\nArchivo {archivoNumero}:");
                Console.WriteLine($"Total de datos empleados: {productosEnArchivo.Count}");


                foreach (int empleadoIndice in productosEnArchivo)
                {
                    Console.WriteLine($" Nombre: {nombre[empleadoIndice]}\n Cédula: {cedula[empleadoIndice]}\n Dirección: {direccion[empleadoIndice]}\n Teléfono {telefono[empleadoIndice]}\n Salario: {salario[empleadoIndice]}");
                }
            }

            Console.WriteLine("\n*** FIN DEL REPORTE ***");

            int salir = 0;
            do
            {
                Console.WriteLine("Ingresa [3] Menú: ");
                salir = int.Parse(Console.ReadLine());
            }
            while (salir != 3);

            Console.WriteLine("Has salido del reporte");
        }

        public static void borrarEmpleados()
        {
            Console.Clear();
            int opcion = 0;

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                if (salario[i] != 0 && !string.IsNullOrEmpty(nombre[i]) && !string.IsNullOrEmpty(cedula[i]) && !string.IsNullOrEmpty(direccion[i]) && !string.IsNullOrEmpty(telefono[i]))  // Imprime los productos con código diferente a 0 y los nombres de productos que no sean nulos o vacíos
                {
                    Console.WriteLine($"Nombre: {nombre[i]}\n Cédula: {cedula[i]} \nDirección: {direccion[i]}\n Teléfono {telefono[i]}\n Salario{salario[i]}");
                }
            }

            while (true)
            {
                Console.WriteLine("Digite:\n1- Eliminar empleado por cédula\n 2- Menú ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese la cédula del empleado a eliminar o [salir]: ");
                    string nombreeliminado = Console.ReadLine();

                    if (nombreeliminado == "salir")
                    {
                        Console.WriteLine("Ha salido de la opción borrar artículos");
                        break;
                    }

                    for (int i = 0; i < cantidadEmpleados; i++)
                    {
                        if (nombreeliminado == cedula[i])
                        {
                            eliminarEmpleados(i);
                            Console.WriteLine($"Artículo con código {nombreeliminado} eliminado.");
                            break;
                        }
                    }
                }

                else if (opcion == 2)
                {
                    Console.WriteLine("Saliendo..");
                    break;
                }
                else
                {
                    Console.WriteLine("*** Opción incorrecta, inténtelo de nuevo ***");
                }
            }
        }

        public static void eliminarEmpleados(int indice)
        {
            for (int i = indice; i < cantidadEmpleados - 1; i++)
            {
                nombre[i] = nombre[i + 1];
                cedula[i] = cedula[i + 1];
                direccion[i] = direccion[i + 1];
                telefono[i] = telefono[i + 1];
                salario[i] = salario[i + 1];

            }

            nombre[cantidadEmpleados - 1] = "";
            cedula[cantidadEmpleados - 1] = "";
            direccion[cantidadEmpleados - 1] = "";
            telefono[cantidadEmpleados - 1] = "";
            salario[cantidadEmpleados - 1] = 0;
            cantidadEmpleados--;
        }
        public static void reporteEmpleados()
        {

            consultarEmpleados();
        }

        public static void reporteCalcularPromedio()
        {
            float promedioSalarios = 0;
            for (int i = 0; i < cedula.Length; i++) 
            {

                promedioSalarios += salario[i];

            }
            promedioSalarios /= salario.Length;
            Console.WriteLine("El promedio de los salario es: " + promedioSalarios);

        }
    }
}
