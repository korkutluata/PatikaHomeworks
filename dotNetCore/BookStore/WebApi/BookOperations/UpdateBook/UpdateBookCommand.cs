using System;
using System.Linq;
using WebApi.DBOperations;

namespace WebApi.BookOperations.UpdateBook
{
    public class UpdateBookCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int BookId { get; set; }
        public UpdateBookModel Model { get; set; }
        public UpdateBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(x => x.Id == BookId);
            if (book is null)
                throw new InvalidOperationException("Guncellenecek Kitap Bulunamadi!");

            book.Title = Model.Title != default ? Model.Title : book.Title;     //! yapilmak istenen Title degisikligi  defaulttan farkli ise  yeni Title'i al, yok eskisinin aynisi ise eskisi kalsin dedik
            book.GenreId=Model.GenreId != default ? Model.GenreId : book.GenreId;
            _dbContext.SaveChanges();
        }
    }

    public class UpdateBookModel       //! sadece update edilebilmesini istedigimiz ozellikleri  actik
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
    }
}