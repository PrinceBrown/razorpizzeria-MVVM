using System;
namespace RazorPizzeria.Models
{
	public class PizzasModel
	{

        public string ImageTitle { get; set; }
		public string PizzaName { get; set; }
		public double BasePrice { get; set; } = 2;
		public double Price { get; set; } 


		public bool TomatoSauce { get; set;}
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Beef { get; set; }
        public bool Mushroom { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }

        public PizzasModel()
		{
		}
	}
}

