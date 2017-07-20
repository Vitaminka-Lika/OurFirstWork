using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class ProductClass
    {
        string productName; // Название товара
        int productCount; // Количество товара (штук)
        double productKg; // Количество товара (килограмм)

         public ProductClass(string productName) // Конструктор класса
        {
            this.productName = productName;
            productCount = 0;
            productKg = 0;
        }
                      
        public void setProductName(string newProductName) // Задать новое название товара
        {
            productName = newProductName;
        }

        public string getProductName() // Получить название товара
        {
            return productName;
        }

        public void setProductCount(int newProductCount) // Задать новое количество товара (штук)
        {
            productCount = newProductCount;
        }

        public int getProductCount() // Получить количество товара (штук)
        {
            return productCount;
        }
        
        public void setProductKg(double newProductKg) // Задать новое количество товара (килограмм)
        {
            productKg = newProductKg;
        }

        public double getProductKg() // Получить количество товара (килограмм)
        {
            return productKg;
        }
    }
}
