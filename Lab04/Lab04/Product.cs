using System;

namespace Lab04
{
    public class Product : IEntity
    {
        private string tenSP = string.Empty;
        private decimal price;
        private int quantity;

        public string MaSP { get; }

        public string Id => MaSP;

        public string TenSP
        {
            get => tenSP;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ten san pham khong duoc rong.");
                tenSP = value.Trim();
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Don gia khong duoc am.");
                price = value;
            }
        }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("So luong khong duoc am.");
                quantity = value;
            }
        }

        public decimal TotalValue => Price * Quantity;

        public Product(string maSP, string tenSP, decimal price, int quantity)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Ma san pham khong duoc rong.");

            MaSP = maSP.Trim();
            TenSP = tenSP;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"Ma: {MaSP,-8} | Ten: {TenSP,-20} | Don gia: {Price,12:N0} | So luong: {Quantity,5}";
        }
    }
}
