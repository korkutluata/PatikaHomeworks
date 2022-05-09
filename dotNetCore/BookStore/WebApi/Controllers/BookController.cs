using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
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
        private readonly BookStoreDbContext _context;  //constructorda bir kere set edilsin ve degistirilmesin diye readonly 
        private readonly IMapper _mapper;
        public BookController(BookStoreDbContext context, IMapper mapper)  // injection yaptik
        {
            _context = context;
            _mapper = mapper;
        }

        //! ViewModel kullanarak 
        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context, _mapper);
            var result = query.Handle();
            return Ok(result);  //! hem result objemizi hem de http 200 sonucunu donduruyoruz
        }

        [HttpGet("{id}")]       // id'yi route'dan alma sekli
        public IActionResult GetById(int id)
        {

            BookDetailViewModel result;
            try
            {
                GetBookDetailQuery query = new GetBookDetailQuery(_context, _mapper);
                query.BookId = id;
                GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
                validator.ValidateAndThrow(query);
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


        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context, _mapper);
            try
            {
                command.Model = newBook;
                CreateBookCommandValidator validator = new CreateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
                // if (!result.IsValid)  //! result validation rule'larimizi karsilamiyor ise ekrana sorunlari yazdirsin istedik
                //     foreach (var item in result.Errors)
                //         Console.WriteLine("Property: " + item.PropertyName + " - Error Message: " + item.ErrorMessage);
                // else
                //command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);  //! command icin kendi class'inda hazirlanmis, throw edilmis exception mesaji
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] UpdateBookModel updatedBook)
        {
            try
            {
                UpdateBookCommand command = new UpdateBookCommand(_context);
                command.BookId = id;
                command.Model = updatedBook;
                UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handle();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            try
            {
                DeleteBookCommand command = new DeleteBookCommand(_context);
                command.BookId = id;
                DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
                validator.ValidateAndThrow(command);
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