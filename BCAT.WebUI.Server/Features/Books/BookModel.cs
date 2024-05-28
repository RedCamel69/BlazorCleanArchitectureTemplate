namespace BCAT.WebUI.Server.Features.Books
{
    public class BookModel
    {
        public int Id { get; set; }
        public required string Title { get; set; } = string.Empty;
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; } = DateTime.Now;
        public bool IsPublished { get; set; } = false;
    }
}
