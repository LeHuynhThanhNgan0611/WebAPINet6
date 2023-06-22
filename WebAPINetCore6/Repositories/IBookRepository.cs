using WebAPINetCore6.Data;
using WebAPINetCore6.Models;

namespace WebAPINetCore6.Repositories
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBooksAsync(int id);
        public Task<int> AddBookAsync(BookModel model);
        public Task UpdateBookAsync(int i, BookModel model);
        public Task DeleteBookAsync(int id);
    }
}
