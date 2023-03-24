using Microsoft.EntityFrameworkCore;
using PetBlazor.Models;

namespace PetBlazor.Services
{
    public class DbManagerService
    {
        private readonly ApplicationContext db;
        public DbManagerService(ApplicationContext db)
        {
            this.db = db;
        }
        //Prods
        async public Task<List<Product>> GetAllProducts()
        {
            await Task.Delay(2000);
            return await db.Products.ToListAsync();
        }
        public void ValueChanged(Product changedProduct)
        {
            var item = db.Products.Attach(changedProduct); //В отличии от Update обновляет только то поле, которое, действительно изменилось, но требует явного указания изменение экземпляра - item.State
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified; //Указываем что экземпляр изменился
            db.SaveChanges();
        }
        public void AddProduct(Product product)
        {
            Product newProduct = product;
            db.Products.Add(newProduct);
            db.SaveChanges();
        }
        public void DeleteProduct(int id)
        {
            var deletedProduct = db.Products.Find(id);
            if (deletedProduct != null)
            {
                db.Products.Remove(deletedProduct);
                db.SaveChanges();
            }
        }
        //Manufs
        async public Task<List<Manufacturer>> GetAllManufs()
        {
            return await db.Manufacturers.ToListAsync();
        }
        //Categs
        async public Task<List<Category>> GetAllCategs()
        {
            return await db.Categories.ToListAsync();
        }
        //Bucket
        async public Task<List<Bucket>> GetAllBuckets()
        {
            return await db.Buckets.ToListAsync();
        }
        public void AddToBucket(Bucket item)
        {
            db.Buckets.Add(item);
            db.SaveChanges();
        }
        public void ValueChanged(Bucket changedBucket)
        {
            var item = db.Buckets.Attach(changedBucket); //В отличии от Up
            item.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
