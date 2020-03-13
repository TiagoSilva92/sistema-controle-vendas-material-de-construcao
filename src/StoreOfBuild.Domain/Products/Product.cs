namespace StoreOfBuild.Domain.Products
{
    public class Product
    {
        public int Id {get; private set;}
        public string Name {get; private set;}
        public Category Category {get; private set;}
        public decimal Price {get; private set;}
        public int StockQuantity {get; private set;}

        public Product(string name, Category category, decimal price, int stockquantity)
        {
            ValidateValues(name, category, price, stockquantity);
            SetProperties(name, category, price, stockquantity);
        }

        public void Update(string name, Category category, decimal price, int stockquantity) 
        {
            ValidateValues(name, category, price, stockquantity);
            SetProperties(name, category, price, stockquantity);
        }

         private void SetProperties(string name, Category category, decimal price, int stockquantity)
        {
            Name = name;
            Category = category;
            Price = price;
            StockQuantity = stockquantity;
        }

        private static void ValidateValues(string name, Category category, decimal price, int stockquantity)
        {
            DomainException.When(string.IsNullOrEmpty(name), "Name is required");
            DomainException.When(category == null, "Category is required");
            DomainException.When(price < 0, "Price is required");
            DomainException.When(stockquantity < 0, "Stock quantity is required");
        }
    }
}