namespace Problema01_Lab09
{
            class Program
        {
            static Dictionary<string, int> ventas = new Dictionary<string, int>();
            static Dictionary<string, int> devoluciones = new Dictionary<string, int>();
            static Dictionary<string, int> inventario = new Dictionary<string, int>();
            static Dictionary<string, double> cajaPorRubro = new Dictionary<string, double>();
            static double cajaGeneral = 0.0;

            static void Main()
            {
                int opcion;
                do
                {
                    Console.WriteLine("================================");
                    Console.WriteLine("Tienda de Don Lucas");
                    Console.WriteLine("================================");
                    Console.WriteLine("1: Registrar venta");
                    Console.WriteLine("2: Registrar devolución");
                    Console.WriteLine("3: Cerrar Caja");
                    Console.WriteLine("================================");
                    Console.Write("Ingrese una opción: ");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            //RegistrarVenta();
                            break;
                        case 2:
                            //RegistrarDevolucion();
                            break;
                        case 3:
                            //errarCaja();
                            break;
                    }
                } while (opcion != 3);
            }
        }
    }
