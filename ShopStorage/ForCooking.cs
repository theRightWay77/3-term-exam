using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStorage
{
    class ForCooking : Device 
    {
        static int CountInClass = 0;
        private int Count = 0;
        public ForCooking(string type, string company, string model, string yearOfRelease) : base(type, company, model, yearOfRelease)
        {
            Count = ++CountInClass;
            AllForCooking.Add(this);
        }
    }
}
