using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBooks;
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
        public Book GetById(int id)
        {
            var book = _context.Books.Where(x => x.Id == id).SingleOrDefault();
            return book;
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
        public IActionResult UpdateBook(int id, [FromBody] Book updatedBook)
        {
            var book = _context.Books.SingleOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();

            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;
            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            _context.SaveChanges();
            return Ok();
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();

            _context.Books.Remove(book);
            _context.SaveChanges();
            return Ok();
        }
    }
}