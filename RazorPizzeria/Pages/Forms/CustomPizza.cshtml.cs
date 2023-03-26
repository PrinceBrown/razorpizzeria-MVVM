using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages.Forms
{
	public class CustomPizzaModel : PageModel
    {

        [BindProperty]
        public PizzasModel Pizza { get; set;}
        public double PizzaPrice { get; set; }
        
        public void OnGet()
        {
        }


        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 1;
            if (Pizza.Cheese) PizzaPrice += 1.5;
            if (Pizza.Peperoni) PizzaPrice += 3;
            if (Pizza.Beef) PizzaPrice += 4;
            if (Pizza.Mushroom) PizzaPrice += 2.5;
            if (Pizza.Tuna) PizzaPrice += 3;
            if (Pizza.Pineapple) PizzaPrice += 15;


            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice});
        }
    }
}
