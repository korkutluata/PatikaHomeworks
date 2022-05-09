using AutoMapper;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;

namespace WebApi.Common
{
    public class MappingProfile : Profile   //* AutoMapper tarafindan bir config dosyasi olarak gorulmesini sagladik
    {
        public MappingProfile()
        {
            CreateMap<CreateBookModel, Book>();   // ilk parametre: source, ikinci parametre: target  
                                                  // CreateBookModel'den Book'a donusum yapabilsin, maplenebilsin dedik
            CreateMap<Book, BookDetailViewModel>().ForMember(dest=> dest.Genre, opt=>opt.MapFrom(src=> ((GenreEnum)src.GenreId).ToString()));
            CreateMap<Book, BooksViewModel>().ForMember(dest=> dest.Genre, opt=> opt.MapFrom(src=> ((GenreEnum)src.GenreId).ToString()));
        }
    }
}