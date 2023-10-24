using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStorage
{
    class ForClothes : Device
    {
        static int CountInClass = 0;
        private int Count = 0;
        public ForClothes(string type, string company, string model, string yearOfRelease) : base(type, company, model, yearOfRelease)
        {
            Count = ++CountInClass;
            AllForClothes.Add(this);
        }
    }
}
