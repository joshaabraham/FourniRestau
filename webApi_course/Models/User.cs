namespace webApi_course.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserDetail UserDetail { get; set; }



        public User()
        {

        }

    }
}
