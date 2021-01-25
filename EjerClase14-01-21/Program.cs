using System;

namespace EjerClase14_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese una opcion: ");
            Console.WriteLine("1- Nuevo Producto");
            Console.WriteLine("2- Borrar Producto");
            Console.WriteLine("3- Listar Producto");
            Console.WriteLine("4- Buscar Producto");
            Console.WriteLine("5- Devolver Precio de Prodcto");
            Console.WriteLine("6- Salir");
            Console.Write("Opcion: ");
            int opcion;
            
            ListaProductos productos = new ListaProductos();

            do
            {
                opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        //Producto producto = new Producto();

                        /*
                        if (productos.ListaLlena(10) != -1)
                        {
                            Console.WriteLine("Ingrese el codigo: ");
                            string codigo = Console.ReadLine();
                            Console.WriteLine("Ingrese la descripcion: ");
                            string descripcion = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio: ");
                            float precio = Convert.ToInt16(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de stock");
                            int stock = Convert.ToInt16(Console.ReadLine());

                            productos.AgregarProducto(codigo, descripcion, precio, stock);

                        }
                        */
                        Console.WriteLine("Ingrese el codigo: ");
                        string codigo = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripcion: ");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("Ingrese el precio: ");
                        float precio = Convert.ToInt16(Console.ReadLine());
                        Console.WriteLine("Ingrese la cantidad de stock");
                        int stock = Convert.ToInt16(Console.ReadLine());

                        productos.AgregarProducto(codigo, descripcion, precio, stock);

                        break;
                    case 2:
                        if (productos.ListaVacia() != -1)
                        {
                            Console.WriteLine("Ingrese el codigo del producto a eliminar: ");
                            string CodigoMain = Console.ReadLine();

                            productos.BorrarProducto(CodigoMain);

                        }

                        break;
                    case 3:
                        if (productos.ListaVacia() != -1)
                        {
                            productos.ListarProductos();

                        }

                        break;
                    case 4:
                        if (productos.ListaVacia() != -1)
                        {
                            Console.WriteLine("Ingrese el codigo del producto para buscar: ");
                            string CodigoMain = Console.ReadLine();

                            productos.BuscarProducto(CodigoMain);

                        }

                        break;
                    case 5:
                        if (productos.ListaVacia() != -1)
                        {
                            Console.WriteLine("Ingrese la descripcion del producto para conocer el precio: ");
                            string DescripcionMain = Console.ReadLine();

                            productos.DevolverPrecio(DescripcionMain);

                        }

                        break;
                    /*
                    case 6:

                        break;
                    */
                    default:

                        break;
                        //Console.ReadKey();
                }

            } while (opcion>0 && opcion<6);
            
        }
    }

    /*public Producto[] ListaProductos = new Producto[10];

    private int _posicion = 0;

    public void AgregarProducto()
    {
        ListaProductos[_posicion] = new Producto();
        _posicion++;
    }
    */

    public class Producto
    {
        public string Codigo;
        public string Descripcion;
        public float Precio;
        public int Stock;

        public Producto (string codigo, string descripcion, float precio, int stock)
        {
            /*
            Console.WriteLine("Ingrese el codigo: ");
            string codigo = Console.ReadLine();
            Console.WriteLine("Ingrese la descripcion: ");
            string descripcion = Console.ReadLine();
            Console.WriteLine("Ingrese el precio: ");
            float precio = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de stock");
            int stock = Convert.ToInt16(Console.ReadLine());
            */
            

        }
    }

    public class ListaProductos
    {
        public Producto[] lista = new Producto[10];
        private int posicion = 0;

        public void AgregarProducto (string codigo, string descripcion, float precio, int stock)
        {
            lista[posicion] = new Producto (codigo, descripcion, precio, stock);
            posicion++;
        }

        public void ListarProductos()
        {
            foreach (var item in lista)
            {
                if (item != null)
                {
                    Console.WriteLine("Codigo: {0} - Descripcion: {1} - Precio: {2} - Stock: {3}", item.Codigo, item.Descripcion, item.Precio, item.Stock);
                }
                else
                {
                    Console.WriteLine("Posición Vacía");
                }
            }
        }

        public void BorrarProducto (string CodigoMain)
        {
            int i = 0;
            while (i <= lista.Length)
            {
                if (lista[i].Codigo == CodigoMain)
                {
                    for (int j=i; j<=lista.Length-1; j++)
                    {
                        lista[j] = lista[j + 1];
                    }
                    lista[i] = null;
                    _ = lista.Length - 1;
                }
                else
                {
                    i++;
                    if (i == lista.Length)
                    {
                        Console.WriteLine("No se encontró el producto");
                    }
                }
            }

        }

        public void BuscarProducto (string DescripcionMain)
        {
            for (int i = 0; i <= posicion; i++)
            {
                int resultado = string.Compare(lista[i].Descripcion, DescripcionMain);
                Console.WriteLine("resultado de comparacion: " + resultado);
                if (resultado == 0)
                {
                    Console.WriteLine("El producto está en la posicion: " + i);
                }
                else
                {
                    Console.WriteLine("No se encontro el producto");
                }
            }

        }

        public void DevolverPrecio(string DescripcionMain)
        {
            foreach (var item in lista)
            {
                if (item.Descripcion.CompareTo(DescripcionMain) == 0)
                {
                    Console.WriteLine("Precio: {0}", item.Precio);
                }
                else
                {
                    Console.WriteLine("No se encontró el producto");
                }
            }
        }

        public int ListaVacia()
        {
            if (lista[0] == null)
            {
                Console.WriteLine("La lista está vacia");
                return -1;
            }
            else
            {
                return 1;
            }
        }

        /*
        public int ListaLlena(int n)
        {
            if (lista[n] != null)
            {
                Console.WriteLine("La lista está llena");
                return -1;
            }
            else
            {
                return 1;
            }

        }
        */
    }
}
