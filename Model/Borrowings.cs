namespace ApiPreview_ThanhTan.Model
{
    public class Borrowings
    {
        public int ID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public virtual Books? Books { get; set; }
        public virtual LibraryCards? LibraryCards { get; set; }

    }
}
