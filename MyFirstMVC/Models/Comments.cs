namespace MyFirstMVC.Models
{
    public class Comments
    {
        public int Id { get; set; }

        public string Comment { get; set; }

        public string CommentatorName { get; set; }

        public int RatingId { get; set; }

        public int PhoneId { get; set; }
    }
}