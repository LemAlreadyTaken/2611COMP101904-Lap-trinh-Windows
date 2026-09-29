using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab04
{
    public class ProductService
    {
        private readonly Repository<Product> repository = new Repository<Product>();

        public event Action<Product>? ProductAdded;
        public event Action<Product>? ProductRemoved;

        // Kiem tra ma hop le va chua bi trung; dung som de khoi bat nguoi dung nhap het roi moi bao loi.
        public void EnsureIdAvailable(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new ArgumentException("Ma san pham khong duoc rong.");
            if (repository.Exists(id.Trim()))
                throw new DuplicateProductException(id.Trim());
        }

        public void AddProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            EnsureIdAvailable(product.Id);
            repository.Add(product);
            ProductAdded?.Invoke(product);
        }

        public void RemoveProduct(string id)
        {
            Product? product = repository.FindById(id);
            if (product == null || !repository.Remove(product.Id))
                throw new ProductNotFoundException(id);

            ProductRemoved?.Invoke(product);
        }

        public List<Product> GetAll()
        {
            return repository.GetAll();
        }

        public Product? FindById(string id)
        {
            return repository.FindById(id);
        }

        public List<Product> SearchByName(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
                throw new ArgumentException("Tu khoa khong duoc rong.");

            return Filter(p => p.TenSP.Contains(keyword.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public List<Product> FilterByPrice(decimal min, decimal max)
        {
            if (min < 0 || max < 0)
                throw new ArgumentException("Gia khong duoc am.");
            if (min > max)
                throw new ArgumentException("Gia nho nhat phai <= gia lon nhat.");

            return Filter(p => p.Price >= min && p.Price <= max);
        }

        public List<Product> Filter(Func<Product, bool> condition)
        {
            return repository.Find(condition);
        }

        public decimal GetTotalValue()
        {
            return repository.GetAll().Sum(p => p.TotalValue);
        }
    }
}
