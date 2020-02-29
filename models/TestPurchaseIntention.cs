namespace data_soruce_mil.models
{
    public class TestPurchaseIntention
    {
        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public string Type
        {
            get => type;
            set => type = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }

        public string Comment
        {
            get => comment;
            set => comment = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public byte Zipcode
        {
            get => zipcode;
            set => zipcode = value;
        }
        public string Color { get; internal set; }
        public string Size { get; internal set; }

        private string brand;
        private string type;
        private decimal price;
        private string url;
        private string comment;
        private string name;
        private string email;
        private string phone;
        private string city;
        private byte zipcode;
        public TestPurchaseIntention()
        {
        }
        
        
    }
}