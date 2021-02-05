using foodPicker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace foodPicker.Services
{
    public class ReceptenService
    {
        public Database Whatever_DB { get; set;}

        public ReceptenService()
        {
            Whatever_DB = JsonLoadService.GetJson<Database>(@"Database\db.json");
        }

        public List<Recept> GetRecepten()
        {
            var Recepten = new List<Recept>();

            foreach (var recept in Whatever_DB.Recepten)
            {
                var NewRecept = new Recept();
                NewRecept.Id = recept.Id;
                NewRecept.ReceptNaam = recept.ReceptNaam;
                NewRecept.BenodigdeIngredienten = new List<Ingredient>();

                foreach (var id in recept.BenodigdeIngredienten)
                {
                    //NewRecept.BenodigdeIngredienten.Add(Whatever_DB.Ingredienten[id])
                    NewRecept.BenodigdeIngredienten.Add(Whatever_DB.Ingredienten.Single(x => x.Id == id));

                }

                Recepten.Add(NewRecept);
            }
            return Recepten;
            //Whatever_DB.Recepten[].ReceptNaam
        }


    }
}
