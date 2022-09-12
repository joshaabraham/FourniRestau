namespace webApi_course.Models
{
    public class Account
    {
        public int AccountID { get; set; }
        public int Role { get; set; }
        public string Nom { get; set; }
        public bool IsSubscriptionPayed {get;set;}

        public Account()
        {

        }




    }
}
