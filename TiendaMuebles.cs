
/*
Muñoz Sánchez, Jorge
Practica Evaluable Tema 5
Ejercicio 1
Apartado 1.1 si
Apartado 1.2 si 
Apartado 1.3 si 
Apartado 1.4 no 
Apartado 1.5 no 
Apartado 1.6 si / no / parcialmente
Apartado 1.7 si / no / parcialmente
Apartado 1.8 si / no / parcialmente


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class TiendaMuebles
    {
        Mueble presentación = new Mueble("Espejo escocés", "circular para vestíbulos", "azul cobalto", 1977, 9500, "Esparta", 09, 699988986);

        static int indx = 2;   
        static Mueble[] arrProducto = new Mueble[250]; //La nueva capacidad máxima del array será de 250.

        static void Main(string[] args)
        {
            bool exposicionMenuPrincipal = true;

            while (exposicionMenuPrincipal)
            {

                exposicionMenuPrincipal = MenuPrincipal();
            }

        }

        private static bool MenuPrincipal()   
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("   ¡Bienvenido a la tienda de muebles! ");
            Console.WriteLine("      El buen descansar de Ávila");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Seleccione 1 para añadrir un nuevo producto." + "\n" + "Seleccione 2 para mostrar todos los artículos de la tienda de muebles."
                              + "\n" + "Seleccione 3. Búsqueda." + "\n" + "Seleccione 4 para cerrar el programa.");
			// #1# El menú de opciones y su funcionamiento será similar al de la práctica anterior, salvo.  #se cumple#
            // la opción de "Buscar producto", que cambia como se explica más adelante. #se cumple paso búsqueda en el número 3#
            
            Console.WriteLine("----------------------------");
            
			// #1# De los datos de cada producto, además se desea almacenar el nombre del ...
			// fabricante, su código de identificación y su teléfono.
			
			// #2# Opciones. Se cumple.Mostrar por pantalla todas las opciones del menú principal del programa incluso las que el usuario añada.
			
			// #3# La función Añadir recibirá como parámetro el array de productos, el contador ...
			//	de elem	entos del array y no devolverá nada. Internamente, pedirá al usuario los datos del ...
			//	nuevo producto, lo añadirá al array e incrementará el contador.  
			
			// #4# Falta la opción borrar.
			
			// #5# Falta la opción ordenar.
			
			// #6# Se cumple.
			
			// #7# Se cumple.
			
			// #8# Se cumple.
            arrProducto[0] = new Mueble("Cama", "De estilo italiano", "Negro caoba", 2008, 90000, "Esparta", 02, 699999996);
            arrProducto[1] = new Mueble("Sofá", "De estilo aterciopelado de sajonia", "Gold", 2004, 13500, "Ikuni", 03, 699899966);
			arrProducto[2] = new Mueble("Mampara", "De estilo barroco toscano", "rojo etrusco", 2002, 13500, "Esparta", 04, 69399966);
			arrProducto[3] = new Mueble("Silla", "De estilo eduardiano", "Azul caspio", 1999, 2300, "Ikuni", 05, 699999566);
			arrProducto[4] = new Mueble("Biombo", "De la época Edo", "Azul de Iwate", 1987, 44400, "Esparta", 06, 63999966);
			
            string SeleccionPrincipal = Console.ReadLine();

            if (SeleccionPrincipal == "1")
            {
                AddProducto("Armario", "Estilo castellano", "Verde oscuro",  1897, 40500, "Esparta", 07, 690999966);
                return true;
            }
            else if (SeleccionPrincipal == "2")
            {
                ExpoMuebles();
                return true;
            }
            else if (SeleccionPrincipal == "3")
            {
                bool mostrarMenuBusqueda = true;
                while (mostrarMenuBusqueda)
                {
                    mostrarMenuBusqueda = MenuBusqueda();
                }
                return false;
            }
            else if (SeleccionPrincipal == "4")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        
        //En el programa principal, se debe sustituir todo el código del "case" correspondiente
		//a cada opción del menú,  #se cumple (no hay código case)#

        public static void AddProducto(string make, string model, 
        string color, int year, int price, string fabricante, int identificación, int teléfono)
        {
            Console.WriteLine("\n" + "Añada un nuevo producto." + "\n" + "Información: El número permitido de productos es de 250." + "\n");

            arrProducto[indx] = new Mueble(make, model,  color, year, price, fabricante, identificación, teléfono);

            arrProducto[indx] = new Mueble("Armario", "Estilo castellano", "Verde oscuro", 1897, 40500, "Esparta", 07, 699939966);

            Console.Write("Ingrese el producto: ");
            arrProducto[indx].Make = Console.ReadLine();

            Console.Write("Ingrese el modelo del producto: ");
            arrProducto[indx].Model = Console.ReadLine();
            
            Console.Write("Ingrese el color del producto: ");
            arrProducto[indx].Color = Console.ReadLine();

            Console.Write("Ingrese el año del producto: ");
            arrProducto[indx].Year = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio del producto: ");
            arrProducto[indx].Price = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el fabricante del producto: ");
            arrProducto[indx].Fabricante = Console.ReadLine();
            
            Console.Write("Ingrese el identificador del producto: ");
            arrProducto[indx].Identificación = int.Parse(Console.ReadLine());
            
            Console.Write("Ingrese el teléfono del producto: ");
            arrProducto[indx].Teléfono = int.Parse(Console.ReadLine());


            int x = indx + 1;
            Console.WriteLine("\n" + "Ingrese el número del producto" + x + " de 250, continúe:");
            Console.WriteLine("Producto es {0}. Modelo es {1}. Año es {2}. Color es {3}. Precio es {4}. Fabricante {5}. Identificación {6} .Teléfono {7}"
                , arrProducto[indx].Make, arrProducto[indx].Model, arrProducto[indx].Year, arrProducto[indx].Color, arrProducto[indx].Price, arrProducto[indx].Fabricante, arrProducto[indx].Identificación, arrProducto[indx].Teléfono);
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n");

            indx++;
        }

        public static void ExpoMuebles()
        {
            Console.WriteLine("Guarde los siguientes productos:" + "\n");


            for (int i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null)  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }

            Console.WriteLine("\n");
            int numeroDeMuebles = arrProducto.Count(s => s != null);  
            Console.WriteLine("Hay {0} muebles en la colección.", numeroDeMuebles);
            Console.WriteLine("----------------------------");


        }

        private static bool MenuBusqueda()
        {
            Console.WriteLine("#      #################          #");
            Console.WriteLine("      Busca el producto en el menú      ");
            Console.WriteLine("#####         #######         ####");
            Console.WriteLine(  "Seleccione 1 para buscar la marca." + "\n"
                              + "Seleccione 2 para ver la descripción." + "\n"
                              + "Seleccione 3 para buscar el color." + "\n"
                              + "Seleccione 4 para buscar el año de manufactura." + "\n"
                              + "Seleccione 5 para buscar el precio." + "\n"
                              + "Seleccione 6 para buscar el fabricante." + "\n"
                              + "Pulse enter para salir.");
            Console.WriteLine("####          #######         ####");

            string buscarSelección = Console.ReadLine();

            if (buscarSelección == "1")
            {
                BuscarMueblesMake();
                return true;
            }
            else if (buscarSelección == "2")
            {
                BuscarMueblesModel();
                return true;
            }
            else if (buscarSelección == "3")
            {
                BuscarMueblesColor();
                return true;
            }
            else if (buscarSelección == "4")
            {
                BuscarMueblesYear();
                return true;
            }
            else if (buscarSelección == "5")
            {
                BuscarMueblesPrice();
                return true;
            }
            else if (buscarSelección == "6")
            {
                BuscarMueblesFabricante();
                return true;
            }
            else if (buscarSelección == "7")
            {
                BuscarMueblesIdentificación();
                return true;
            }
            else if (buscarSelección == "8")
            {
                BuscarMueblesTeléfono();
                return true;
            }
            else
            {
                return MenuPrincipal();

            }

        }

        public static void BuscarMueblesMake()
        {
            Console.WriteLine("Escriba el color del mueble y luego presione Intro para iniciar la búsqueda: ");
            string buscarMake = Console.ReadLine();
            int i = 0;

            for (i = 0; i < arrProducto.Length && arrProducto[i] != null; i++)
            {

                if (arrProducto[i].Make.ToLower() == buscarMake.ToLower())
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }
        }

        public static void BuscarMueblesModel()
        {
            Console.WriteLine("Por favor, introduzca descripción: ");
            string buscarModel = Console.ReadLine();
            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && arrProducto[i].Model.ToLower() == buscarModel.ToLower())  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }

            }
        }

        public static void BuscarMueblesColor()
        {
            Console.WriteLine("Por favor. Introduzca el color que desea. ");
            string buscarColor = Console.ReadLine();
            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && arrProducto[i].Color.ToLower() == buscarColor.ToLower())  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }

            }
        }

        public static void BuscarMueblesYear()
        {
            Console.Write("Por favor, escriba el año desde: ");
            int buscarYearDesde = int.Parse(Console.ReadLine());
            Console.Write("Por favor, escriba el año hasta: ");
            int buscarYearHacia = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && ((arrProducto[i].Year >= buscarYearDesde) && (arrProducto[i].Year <= buscarYearHacia)))  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }
        }

        public static void BuscarMueblesPrice()
        {
            Console.Write("Por favor, escriba el precio desde: ");
            int buscarPriceDesde = int.Parse(Console.ReadLine());
            Console.Write("Por favor, escriba el precio máximo: ");
            int buscarPriceHacia = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && ((arrProducto[i].Price >= buscarPriceDesde) && (arrProducto[i].Price <= buscarPriceHacia)))  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }

        }
        public static void BuscarMueblesFabricante() // se pide incluir fabricante en el menú
        {
            Console.WriteLine("Por favor. Introduzca el color que desea. ");
            string buscarFabricante = Console.ReadLine();
            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && arrProducto[i].Fabricante.ToLower() == buscarFabricante.ToLower())  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }

            }
        }
        public static void BuscarMueblesIdentificación() // se pide añadir identificación al menú
        {
            Console.Write("Por favor, escriba la identificación: ");
            int buscarIdentificaciónDesde = int.Parse(Console.ReadLine());
            Console.Write("Por favor, escriba la identificación: ");
            int buscarIdentificaciónHacia = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && ((arrProducto[i].Identificación >= buscarIdentificaciónDesde) && (arrProducto[i].Identificación <= buscarIdentificaciónHacia)))  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }
        }
        public static void BuscarMueblesTeléfono() // se pide añadir teléfono al menú
        {
            Console.Write("Por favor, escriba el teléfono particular: ");
            int buscarTeléfonoDesde = int.Parse(Console.ReadLine());
            Console.Write("Por favor, escriba el teléfono de empresa: ");
            int buscarTeléfonoHacia = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 0; i < arrProducto.Length; i++)
            {
                if (arrProducto[i] != null && ((arrProducto[i].Teléfono >= buscarTeléfonoDesde) && (arrProducto[i].Teléfono <= buscarTeléfonoHacia)))  
                {
                    Console.WriteLine("Mueble no. {0} Producto: {1}, Modelo: {2}, Color: {3}, Año: {4}, Precio: {5}, Fabricante: {6}, Identificación: {7}, Teléfono: {8}"
                    , i + 1, arrProducto[i].Make, arrProducto[i].Model, arrProducto[i].Color, arrProducto[i].Year, 
                    arrProducto[i].Price, arrProducto[i].Fabricante, arrProducto[i].Identificación, arrProducto[i].Teléfono);
                }
            }

        }


    }


    class Mueble
    {
        string make, model, color, fabricante;
        int year, price, identificación, teléfono;

        public string Make { get { return make; } set { make = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Year { get { return year; } set { year = value; } }
        public int Price { get { return price; } set { price = value; } }
        public string Fabricante { get { return fabricante; } set { fabricante = value; } }
        public int Identificación { get { return identificación; } set { identificación = value; } }
        public int Teléfono { get { return teléfono; } set { teléfono = value; } }
        public Mueble()                                                                  
        {
            make = model = color = "Desconocido";
            year = price = 0;
        }

        public Mueble(string make, string model, string color, int year, int price, string fabricante,  int identificación, int teléfono)   
        {
            Make = make;                                                               
            Model = model;
            Color = color;
            Year = year;
            Price = price;
            Fabricante = fabricante;
            Identificación = identificación;
            Teléfono = teléfono;
        }

    }

}
