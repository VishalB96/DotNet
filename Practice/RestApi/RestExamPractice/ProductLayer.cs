using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestExamPractice
{
    public class ProductLayer
    {
        private static ProductLayer productLayer = new ProductLayer();

        public static ProductLayer PInstance { 
            
            get 
            { if (productLayer != null)
                 productLayer = new ProductLayer();
                return productLayer;
            } 
        }

        private ProductLayer() { }

        public List<product> PList() {
            MyDbEntities db = new MyDbEntities();
            return db.products.ToList<product>();
        }

        public string AddProduct(product p) {

            MyDbEntities db = new MyDbEntities();
            db.products.Add(p);
            db.SaveChanges();
            return "successfully added : "+p;
        }
    }
}