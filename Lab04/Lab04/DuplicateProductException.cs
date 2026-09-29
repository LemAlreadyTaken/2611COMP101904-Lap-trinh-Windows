using System;

namespace Lab04
{
    public class DuplicateProductException : Exception
    {
        public string ProductId { get; }

        public DuplicateProductException(string productId)
            : base($"Ma san pham '{productId}' da ton tai.")
        {
            ProductId = productId;
        }
    }
}
