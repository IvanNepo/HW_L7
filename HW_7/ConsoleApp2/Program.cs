namespace HW_7
{
    internal class Program
    {
        static void Main(string[] args);
           class Product
        {
            public int Id { get; }
            public string Name { get; }
            public decimal Price { get; }
            public int Quantity { get; }
            public Product(int id, string name, decimal price, int quantity)
            {
                Id = id;
                Name = name;
                Price = price;
                Quantity = quantity;
            }
            public override string ToString()
            {
                return $"ID: {Id}, Название: {Name}, Цена: {Price:C}, Количество: {Quantity}";
            }
        }
        class Inventory
        {
            private Product[] products;
            public Inventory(Product[] products)
            {
                this.products = products;
            }
            public void DisplayProducts()
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
            public decimal CalculateInventoryValue()
            {
                decimal totalValue = 0;
                foreach (var product in products)
                {
                    totalValue += product.Price * product.Quantity;
                }
                return totalValue;
            }
        }

        class Produscts
        {
            static void Main(string[] args)
            {
                Product[] products = {
            new Product(1, "Chocolate", 2.99m, 10),
            new Product(2, "Milk", 1.49m, 20),
            new Product(3, "Bread", 0.99m, 15)
        };
                Inventory inventory = new Inventory(products);
                Console.WriteLine("Products in the cart:");
                inventory.DisplayProducts();
                decimal totalValue = inventory.CalculateInventoryValue();
                Console.WriteLine($"Total cart cost: {totalValue:C}");
            }
        }
    }
}

