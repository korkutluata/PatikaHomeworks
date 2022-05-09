using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public List<BooksViewModel> Handle()
        {
            var bookList = _dbContext.Books.OrderBy(x => x.Id).ToList();
            //! AutoMapper sonrasi gerek kalmadi
            // List<BooksViewModel> vm = new List<BooksViewModel>();
            // foreach (var book in bookList)
            // {
            //     vm.Add(new BooksViewModel(){
            //         Title = book.Title,
            //         PageCount = book.PageCount,
            //         PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
            //         Genre = ((GenreEnum)book.GenreId).ToString()
            //     });
            // }
            List<BooksViewModel> vm = _mapper.Map<List<BooksViewModel>>(bookList);
            return vm;
        }
    }

    //! BooksViewModel class'ini burada namespace altinda olusturmamizin nedeni, buraya ozel bir ViewModel olmasi.  Explorer icerisinde klasor altinda ayri yeni bir file olarak gostermeyerek, disaridan ilgisiz mudahalelerin onune gecmis de oluyoruz
    public class BooksViewModel    //* UI gosterilecek olan veri tiplerimizi viewmodel olusturarak tanimladik
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
        public string Genre { get; set; }
    }
}