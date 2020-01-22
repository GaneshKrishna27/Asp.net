using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
    public class sellerbo:Iseller
    {
        private List<seller> se;
        public sellerbo()
        {
            se = new List<seller>() { new seller("gany", 7, "cts", "001111", "eluru") };

        }
        public seller GetSeller(int id)
        {
            seller s = se.FirstOrDefault(s => s.Id1== id);
            return s;

        }
        public List<seller>Display()
        {
            return se;
        }

    }
}
