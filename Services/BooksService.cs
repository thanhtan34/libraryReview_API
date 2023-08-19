using ApiPreview_ThanhTan.Model;
using ApiPreview_ThanhTan.Repositories;

namespace ApiPreview_ThanhTan.Services
{
    public interface IBooksService
    {
        public Task<ICollection<Books>> GetBooks();
        public Task<Books>CreateBooks(Books book);
    }
    public class BooksService : IBooksService
    {
        private readonly BooksRepository _booksRepository;

        public BooksService(BooksRepository booksRepository) 
        {
            _booksRepository = booksRepository;
        }

        public async Task<Books> CreateBooks(Books book)
        {
            await _booksRepository.Add(book);
            return book;
        }

        public async Task<ICollection<Books>> GetBooks()
        {
            var listProduct = await _booksRepository.GetAll();
            return listProduct.ToList();
        }


    }
}
