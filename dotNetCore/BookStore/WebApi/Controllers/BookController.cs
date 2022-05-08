using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.DeleteBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.UpdateBook;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]s")]
    public class BookController : ControllerBase
    {
        //! database gecince kapattik buradaki static hazirlanmis ornek verileri
        // private static List<Book> BookList = new List<Book>()
        // {
        //     new Book
        //     {
        //         Id = 1,
        //         Title = "Lean Startup",
        //         GenreId = 1,  // Personal Growth
        //         PageCount = 200,
        //         PublishDate = new DateTime(2001, 06, 12)
        //     },
        //     new Book
        //     {
        //         Id = 2,
        //         Title = "Herland",
        //         GenreId = 2,  // Science Fiction
        //         PageCount = 250,
        //         PublishDate = new DateTime(2010, 05, 23)
        //     },
        //     new Book
        //     {
        //         Id = 3,
        //         Title = "Dune",
        //         GenreId = 2,  // Science Fiction
        //         PageCount = 540,
        //         PublishDate = new DateTime(2001, 12, 21)
        //     }
        // };

        private readonly BookStoreDbContext _context;  //constructorda bir kere set edilsin ve degistirilmesin diye readonly 

        public BookController(BookStoreDbContext context)  // injection yaptik
        {
            _context = context;
        }

        // [HttpGet]
        // public List<Book> GetBooks()
        // {
        //     var bookList = BookList.OrderBy(x => x.Id).ToList<Book>();
        //     return bookList;
        // }

        //! database kullanimina gecince static olusturdugumuz BookList yerine _context.Books kullaniyoruz
        // [HttpGet]
        // public List<Book> GetBooks()
        // {
        //     var bookList = _context.Books.OrderBy(x => x.Id).ToList<Book>();
        //     return bookList;
        // }

        //! ViewModel kullanarak 
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context);
            var result = query.Handle();
            return Ok(result);  //! hem result objemizi hem de http 200 sonucunu donduruyoruz
        }

        [HttpGet("{id}")]       // id'yi route'dan alma sekli
        public IActionResult GetById(int id)
        {
            GetBookDetailQuery query = new GetBookDetailQuery(_context);
            query.BookId = id;
            BookDetailViewModel result;
            try
            {
                result = query.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(result);
        }

        // [HttpGet]       // id'yi FromQuery ile alma sekli
        // public Book Get([FromQuery] string id)
        // {
        //     var book = BookList.Where(x=> x.Id == Convert.ToUInt32(id)).SingleOrDefault();
        //     return book;
        // }


        // Post
        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context);
            try
            {
                command.Model = newBook;
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  //! command icin kendi class'inda hazirlanmis, throw edilmis exception mesaji
            }

            return Ok();
        }

        // Put
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            try
            {
                command.BookId = id;
                command.Model = updatedBook;
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_context);
            command.BookId = id;
            try
            {
                command.Handle();
            }
            catch (Exception ex)
            {                
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}