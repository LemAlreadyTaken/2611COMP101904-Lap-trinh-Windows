using System;

namespace Lab04
{
    public class ProductNotFoundException : Exception
    {
        public string ProductId { get; }

        public ProductNotFoundException(string productId)
            : base($"Khong tim thay san pham co ma '{productId}'.")
        {
            ProductId = productId;
        }
    }
}
