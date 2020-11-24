using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace RestProduct1
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public int Price { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", ProductId, Name, Category, Price);
        }
    }

    public class ProductLayer {
        private static readonly ProductLayer _Instance = new ProductLayer();

        public static ProductLayer Instance => _Instance;


        private List<Product> Products = new List<Product>()
        {
            new Product(){ProductId=1,Name = "Tv",Price=40000,Category="Electronics" },
            new Product() {ProductId=2,Name="Monitor",Price=23000,Category="Electronics" },
            new Product(){ProductId=3,Name="Ladder",Price=2500,Category="Hardware" },
            new Product() {ProductId=4,Name="Soap",Price=380,Category="BeutyProducts" }
        };

        public List<Product> ProductsList { get { return Products; } }

        public Product GetProduct(int id) {
            var res = (from r in ProductsList where r.ProductId == id select r).ToList<Product>().First<Product>();
            return res;
        }
    }
}