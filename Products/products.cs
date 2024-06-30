namespace Products
{
    internal class Product
    {
        public int Pcode;
        public string Pname;
        public int QtyInStock;
        public double Discount;
        public static string Brand = "Brand";

        public Product(int pcode, string pname, int qtyInStock, double discount)
        {
            Pcode = pcode;
            Pname = pname;
            QtyInStock = qtyInStock;
            Discount = discount;
        }

        public void Display()
        {
            Console.WriteLine($"PCode: {Pcode}, PName: {Pname}, QtyInStock: {QtyInStock}, Discount: {Discount}%, Brand: {Brand}");
        }
    }
}
