using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Properties.Model
{
    public class seller
    {
        string Name;
        string Id;
        string Company;
        string Moblie;
        string Address;

        public string Name1 { get => Name; set => Name = value; }
        public string Id1 { get => Id; set => Id = value; }
        public string Company1 { get => Company; set => Company = value; }
        public string Moblie1 { get => Moblie; set => Moblie = value; }
        public string Address1 { get => Address; set => Address = value; }
        public seller(string Name, string Id,
        string Company,
        string Moblie,
        string Address)
        {
            this.Name = Name;
            this.Id = Id;
            this.Company = Company;
            this.Moblie = Moblie;
            this.Address = Address;
        }
    }
}
