using System;
using System.Collections.Generic;

namespace AluminumProject
{
    public class Quotation
    {
        public string QuoteId { get; set; }
        public string ClientCompanyName { get; set; }
        public string ProjectName { get; set; }
        public List<Material> SelectedMaterials { get; set; } = new List<Material>();

        // Function to calculate the total pricce of materials 
        public double CalculateTotalAmount()
        {
            double total = 0;
            foreach (var item in SelectedMaterials)
            {
                total += item.Price;
            }
            return total;
        }
    }
}