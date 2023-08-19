namespace ApiPreview_ThanhTan.Model
{
    public class LibraryCards
    {
        public int ID { get; set; }
        public string MemberName { get; set; }
        public DateTime ExpiryDate { get; set; }

        public ICollection<Borrowings>? borrowings { get; set; }
    }
}
