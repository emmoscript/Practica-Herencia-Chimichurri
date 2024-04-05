using System;
using ChimichurriBurgerApp.Models;

namespace ChimichurriBurgerApp.Controllers
{
    public class Controlador
    {
        private Hamburguesa hamburguesa;

        public void Iniciar()
        {
            Console.WriteLine("Bienvenido a Chimi MiBarriga del Sr. Billy Navaja");
            Console.WriteLine("Por favor, seleccione el tipo de hamburguesa que desea:");
            Console.WriteLine("1. Hamburguesa Clásica");
            Console.WriteLine("2. Hamburguesa Saludable");
            Console.WriteLine("3. Hamburguesa Premium");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    hamburguesa = new Hamburguesa("Pan Normal", "Carne Normal", 50);
                    break;
                case 2:
                    hamburguesa = new HamburguesaSaludable("Pan Integral", "Carne de Pollo", 60);
                    break;
                case 3:
                    hamburguesa = new HamburguesaPremium("Pan Normal", "Carne Angus", 100);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    return;
            }

            AgregarIngredientes();

            Console.WriteLine("\nDetalles de la orden:");
            hamburguesa.MostrarPrecio();
        }

        private void AgregarIngredientes()
        {
            while (true)
            {
                Console.WriteLine("\n¿Desea agregar un ingrediente adicional? (S/N)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "s")
                {
                    Console.WriteLine("Ingredientes disponibles:");
                    Console.WriteLine("1. Lechuga");
                    Console.WriteLine("2. Tomate");
                    Console.WriteLine("3. Bacon");
                    Console.WriteLine("4. Cebolla Caramelizada");
                    Console.WriteLine("5. Pepinillos");
                    Console.WriteLine("6. Salsa de la casa");

                    Console.WriteLine("Ingrese el número correspondiente al ingrediente:");
                    int opcion = int.Parse(Console.ReadLine());

                    string nombreIngrediente = "";
                    decimal precioAdicional = 0;

                    switch (opcion)
                    {
                        case 1:
                            nombreIngrediente = "Lechuga";
                            precioAdicional = 5;
                            break;
                        case 2:
                            nombreIngrediente = "Tomate";
                            precioAdicional = 5;
                            break;
                        case 3:
                            nombreIngrediente = "Bacon";
                            precioAdicional = 10;
                            break;
                        case 4:
                            nombreIngrediente = "Cebolla Caramelizada";
                            precioAdicional = 15;
                            break;
                        case 5:
                            nombreIngrediente = "Pepinillos";
                            precioAdicional = 8;
                            break;
                        case 6:
                            nombreIngrediente = "Salsa de la casa";
                            precioAdicional = 5;
                            break;
                        default:
                            Console.WriteLine("Opción no válida.");
                            continue;
                    }

                    hamburguesa.AgregarIngrediente(nombreIngrediente, precioAdicional);
                }
                else if (respuesta.ToLower() == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Respuesta no válida. Por favor, responda con S o N.");
                }
            }
        }
    }
}
