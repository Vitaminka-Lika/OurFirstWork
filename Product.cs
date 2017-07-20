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

        public ProductClass(string productName, int productCount, double productKg) // Конструктор класса
        {
            this.productName = productName;
            this.productCount = productCount;
            this.productKg = productKg;
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
