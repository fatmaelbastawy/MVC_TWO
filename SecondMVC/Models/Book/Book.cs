using SecondMVC.Models;

namespace MVC_Lab2.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc{ get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Image> Images { get; set; }
    }
}
