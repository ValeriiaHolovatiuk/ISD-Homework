using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_1._8
{
    class Invoice
    {
        private int account;
        private string customer, provider; // покупатель и поставщик

        private string article;  // товары
        private int quantity; // количество

        private int nds = 20;
        bool isInitialized = false;

        public Invoice(int account, string customer, string provider)
        {
            if(isInitialized == false)
            {
                this.account = account;
                this.customer = customer;
                this.provider = provider;
            }
        }

        public void PriceWithNDSAndWithoutNDS(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;

            int price = 0;
            int sum;
            double sumWithNDS;

            switch(article)
            {
                case "Smarphone":
                    price = 5500;
                    break;
                case "TV":
                    price = 12000;
                    break;
                case "Laptop":
                    price = 25000;
                    break;
                case "Camera":
                    price = 10000;
                    break;
                case "Headphones":
                    price = 350;
                    break;
            }

            sum = price * quantity;
            sumWithNDS = sum + sum * nds / 100;
            Console.WriteLine("Article: {0}\nQuantity: {1}\nPrice without NDS: {2}\nPrice with NDS: {3}", article, quantity, sum, sumWithNDS);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1568, "Valeriia", "Foxtrot");
            invoice.PriceWithNDSAndWithoutNDS("Laptop", 10);
        }
    }
}
