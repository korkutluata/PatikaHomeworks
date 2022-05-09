using System;
using System.Linq;
using AutoMapper;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Where(x => x.Id == BookId).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap Bulunamadi!");

            //! AutoMapper implamentasyonu sonrasinda gerek kalmadi
            // BookDetailViewModel vm = new BookDetailViewModel
            // {
            //     Title = book.Title,
            //     Genre = ((GenreEnum)book.GenreId).ToString(),
            //     PageCount = book.PageCount,
            //     PublishDate = book.PublishDate.ToString("dd/MM/yyyy")
            // };
            BookDetailViewModel vm = _mapper.Map<BookDetailViewModel>(book);
            return vm;
        }
    }

    public class BookDetailViewModel    //* UI gosterilecek olan veri tiplerimizi viewmodel olusturarak tanimladik
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}