namespace EMedicineBE.Models
{
    public class Response
    {
        //lets create some properties
        public int StatusCode{ get; set; }
        public string StatusMessage { get; set; }

        public List<Users> listUsers { get; set; }
        //through this list we will display our users on the admin panel
        public Users user { get; set; } //it will give a particular user

        public List<Medicines> listMedicines { get; set; }
        //through this list we will display our medicines on the admin panel
        public Medicines medicine { get; set; } //it will give a particular medicine

        public List<Cart> listCart { get; set; }
        public List<Orders> listOrders { get; set; }
    }
}
