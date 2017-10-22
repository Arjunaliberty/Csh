using Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double price;
            double discount;

            ProductClass[] product = new ProductClass[2];

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите наименование первого продукта: ");
                name = Console.ReadLine();

                Console.WriteLine("Введите цену продукта: ");
                price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите скидку на товар (%): ");
                discount = Double.Parse(Console.ReadLine());

                product[i] = new ProductClass(name, price, discount);

            }

            Console.WriteLine("Стоимость первого товара с учетом скидки {0}", product[0].PriceDiscount());
            Console.WriteLine("Стоимость второго товара с учетом скидки {0}", product[1].PriceDiscount());
            Console.WriteLine("Общая стоимость двух товаров равна {0}", product[0] + product[1]);
           



            Console.ReadKey();
        }
    }
}
