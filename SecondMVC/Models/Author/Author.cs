

using MVC_Lab2.Models;

namespace SecondMVC.Models;

public class Author
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}
