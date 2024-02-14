using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public class Recipe
    {
        public string Name { get; set; } = "";
        public List<string> Images { get; set; } = [];
        public List<string> Ingredients { get; set; } = []; //search Ingredients
        public string Instructions { get; set; } = "";
    }
}
