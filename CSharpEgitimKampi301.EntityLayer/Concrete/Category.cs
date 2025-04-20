using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        #region field variable property farkı
        //int x;
        //public int y { get; set; }
        //void test () {
        //    int z;
        //}
        #endregion
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}
/*
 * field - variable - property
 * 
 */
/* 
 * int x -- > field
 */