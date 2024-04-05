using System;

namespace ChimichurriBurgerApp.Models
{
    public class HamburguesaSaludable : Hamburguesa
    {
        public HamburguesaSaludable(string tipoPan, string tipoCarne, decimal precioBase) : base(tipoPan, tipoCarne, precioBase) { }

        public override void MostrarPrecio()
        {
            Console.WriteLine($"Tipo de Pan: {tipoPan}");
            Console.WriteLine($"Tipo de Carne: {tipoCarne}");
            Console.WriteLine($"Precio Base: {precioBase}");

            decimal totalIngredientes = 0;
            foreach (var ingrediente in ingredientesAdicionales)
            {
                Console.WriteLine($"Ingrediente: {ingrediente.Item1} - Precio: {ingrediente.Item2}");
                totalIngredientes += ingrediente.Item2;
            }

            decimal precioTotal = precioBase + totalIngredientes;
            Console.WriteLine($"Precio Total: {precioTotal}");
        }
    }
}
