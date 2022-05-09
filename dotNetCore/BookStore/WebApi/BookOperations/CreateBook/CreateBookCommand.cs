using System;
using System.Linq;
using AutoMapper;
using WebApi.DBOperations;

namespace WebApi.BookOperations.CreateBook
{
    public class CreateBookCommand
    {
        public CreateBookModel Model { get; set; }
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateBookCommand(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Title == Model.Title);
            if (book is not null)
                throw new InvalidOperationException("Kitap zaten mevcut");

            //! Automapper'dan sonra buna gerek kalmadi
            // book = new Book
            // {
            //     Title = Model.Title,
            //     PublishDate = Model.PublishDate,
            //     PageCount = Model.PageCount,
            //     GenreId = Model.GenreId
            // };
            book = _mapper.Map<Book>(Model);   //! Model'i Book object'ine  map etmesini istedik
            _dbContext.Add(book);
            _dbContext.SaveChanges();
        }
    }

    public class CreateBookModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}