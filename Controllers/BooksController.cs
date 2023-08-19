using ApiPreview_ThanhTan.Model;
using ApiPreview_ThanhTan.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiPreview_ThanhTan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController :ControllerBase
    {
        private readonly IBooksService _booksService;
        private readonly IMapper _mapper;

        public BooksController(IBooksService booksService,IMapper mapper) 
        {
            _booksService = booksService;
            _mapper = mapper;
        }
        [HttpGet("books")]
        public async Task<IActionResult> GetBooks()
        {
            var result = await _booksService.GetBooks();
            return Ok(result);
        }
        [HttpPost("books")]
        public async Task<IActionResult> CreateBooks([FromBody]BooksRequestModel books)
        {
            var mappedBooks = _mapper.Map<Books>(books);
            _booksService.CreateBooks(mappedBooks);
            return Ok("Created Successfully");
        }
    }
}
