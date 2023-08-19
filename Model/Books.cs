namespace ApiPreview_ThanhTan.Model
{
    public class Books
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public ICollection<Borrowings>? borrowings { get; set; }

    }
}
