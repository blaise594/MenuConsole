using System;
using System.Collections.Generic;
using System.Text;

namespace MenuConsole
{
    class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }


        public DateTime DateAdded { get; set; } = DateTime.Now;

        public MenuItem(
            string Name, 
            string Desription, 
            double Price, 
            string Category)
        {
            this.Name = Name;
            this.Description = Description;
            this.Price = Price;
            this.Category = Category;
            this.DateAdded = DateAdded;
        }
        
    }
}
