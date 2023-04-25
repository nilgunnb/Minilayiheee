using PizzaMizza.Core.Enums;
using PizzaMizza.Core.Models.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaMizza.Core.Models.MinorModels
{
    public class PizzaModel : BaseModel
    {
        private static int _id;

        public string Name { get; set; }

        public double SizePrice { get; set; }

        public double IngredientPrice { get; set; }

        public double FullPrice { get; set; }

        public PizzaSize Size { get; set; }

        public PizzaIngredients Ingredients { get; set; }

       

        public PizzaModel()
        {
            _id++;
            Id= _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Size: {Size}, Price: {FullPrice}";
        }

        public string GetFullInfo(int id)
        {
            return $"Id: {Id}, Name: {Name}, Size: {Size}, Price: {FullPrice}, Ingredients: {Ingredients}, SizePrice: {SizePrice}";
        }
    }
}
