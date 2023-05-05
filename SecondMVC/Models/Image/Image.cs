namespace MVC_Lab2.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
