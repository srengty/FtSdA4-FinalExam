using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class CuisineList
    {
        public List<Cuisine> Cuisines { get; set; } = [
            new Cuisine{Name="Khmer", Recipes=[
                new Recipe{
                    Name="Samlor korko",
                    Ingredients=["Prahok", "roasted ground rice", "Pork", "Fish", "Vegetables"],
                    Images=["./Images/Korko.webp"],
                    Instructions="A Cambodian kroeung is a Cambodian herb and spice paste "},

                new Recipe{
                    Name="Chha chou Em",
                    Ingredients=["Prahok", "roasted ground rice", "Pork", "Fish", "Vegetables"],
                    Images=["./Images/Korko.webp"],
                    Instructions="A Cambodian kroeung is a Cambodian herb and spice paste "},

                new Recipe{
                    Name="Trorb Dott",
                    Ingredients=["Prahok", "roasted ground rice", "Pork", "Fish", "Vegetables"],
                    Images=["./Images/Korko.webp"],
                    Instructions="A Cambodian kroeung is a Cambodian herb and spice paste "},
                ]}
            ];
    }
}
