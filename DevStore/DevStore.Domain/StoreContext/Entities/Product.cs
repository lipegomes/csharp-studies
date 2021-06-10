namespace DevStore.Domain.StoreContext.Entities
{
    public class Product
    { 
        public Product(
            string title,
            string desccription,
            string image,
            decimal price,
            decimal quantity
        )
        {
            Title = title;
            Description = desccription;
            Image = image;
            Price = price;
            QuantityOnHand = quantity;
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public decimal QuantityOnHand { get; private set; }

        public override string ToString()
        {
            return Title;
        }
    }
}