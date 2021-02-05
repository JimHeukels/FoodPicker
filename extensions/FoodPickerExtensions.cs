using foodPicker.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace foodPicker.extensions
{
    public static class FoodPickerExtensions
    {
        public static void Represent(this Recept r)
        {
            Console.WriteLine(r.ReceptNaam);
            Console.WriteLine("Met ingredienten: ");
            foreach (var ing in r.BenodigdeIngredienten)
            {
                Console.WriteLine(ing.IngredientNaam);
            }
        }
    }
}
