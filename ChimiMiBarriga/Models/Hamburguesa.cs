using System;
using System.Collections.Generic;

namespace ChimichurriBurgerApp.Models
{
    public class Hamburguesa
    {
        protected string tipoPan;
        protected string tipoCarne;
        protected decimal precioBase;
        protected List<(string, decimal)> ingredientesAdicionales;

        public Hamburguesa(string tipoPan, string tipoCarne, decimal precioBase)
        {
            this.tipoPan = tipoPan;
            this.tipoCarne = tipoCarne;
            this.precioBase = precioBase;
            this.ingredientesAdicionales = new List<(string, decimal)>();
        }

        public void AgregarIngrediente(string nombreIngrediente, decimal precioAdicional)
        {
            ingredientesAdicionales.Add((nombreIngrediente, precioAdicional));
        }

        public virtual void MostrarPrecio()
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
