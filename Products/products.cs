namespace Products
{
    internal class Product
    {
        int pCode;
        public int Pcode
        {
            get { return pCode; }
            set { pCode = value; }
        }

        string pName;
        public string Pname
        {

            get { return pName; }
            set { pName = value; }
        }

        int qtyInStock;
        public int QtyInStock
        {
            get { return qtyInStock; }
            set { qtyInStock = value; }
        }

        int Discount;
        public int discount
        {
            get { return Discount; }
            set { Discount = value; }
        }

        static string brand;
        public string BrandName
        {
            get { return brand; }
            set { brand = value; }
        }

        int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        static Product()
        {
            brand = "Lewis";
        }


        public void GetProduct()
        {
            Console.WriteLine("Enter Pcode");
            PCode = byteConsole.ReadLine();
        }
    }
}
