using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Task_8_1
{
    public enum ProductTypes
    {
        Food,
        HomeAppliances
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double Price {  get; set; }
        public string Image {  get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
