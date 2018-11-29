using System;
using System.Collections.Generic;
using System.Text;

namespace CantinaApp.Core.Entity.Entities
{
    public class MainFood
    {
        public int Id { get; set; }
        public String MainFoodName { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public List<Allergen> Allergens { get; set; }
        public FoodIcon FoodIconType { get; set; }
    }
}
