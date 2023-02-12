using System.Linq.Expressions;

namespace NLayer.Code.Repositories
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetByIdAsync(int id);
        // productRepository.GetAll(x=>x.id>5).ToList();
        IQueryable<T> GetAll();
        //productRepository.where(x => x.id >5).OrderBy.ToListAsync(); T classına göre sorgu yapıp sonucu bool döndürüyoruz
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync (T entity);
        //IEnumarable'ı istediğimiz bir tipe dönüştürebiliriz mümkün olduğunca soyut nesnelerle çalışmalıyız.
        Task AddRangeAsync(IEnumerable<T> entities);
        // Update remove async metot yok ef core memory'e alıp takip etmiş olduğu bir product'ı sadece state'ini değiştiriyor bu uzun süren bir işlem olmadığı için bunun async metotuna gerek yok.
        void Update (T entity); 
        void Remove (T entity); 
        void RemoveRange(IEnumerable<T> entities);
    }
}
