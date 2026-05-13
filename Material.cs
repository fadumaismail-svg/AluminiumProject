using System;

namespace AluminumProject
{
    public class Material
    {
        // material properties 
        public string? MaterialName { get; set; }
        public string? MaterialType { get; set; }
        public string? Unit { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string? SupplierCompany { get; set; }

        // Converting object to a single line for filr storage (File-based)
        public override string ToString()
        {
            return $"{MaterialName};{MaterialType};{Unit};{Price};{StockQuantity};{SupplierCompany}";
        }
    }
}