using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectDemo.Model
{
    public interface Iseller
    {
        seller GetSeller(int id);
        List<seller> Display();
    }
}
