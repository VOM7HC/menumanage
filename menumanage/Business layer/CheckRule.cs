using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_layer;
using Object;

namespace Business_layer
{
    public class CheckRule
    {
        private MonAnObj monAnObj;
        public CheckRule()
        {
            monAnObj = new MonAnObj();
        }
        public string CheckNull(string inputValue)
        {
            if (!String.IsNullOrEmpty(inputValue))
                monAnObj.MaMonAn = inputValue;
            else
                throw new Exception("Not null!");
            return monAnObj.MaMonAn;
        }
    }
}
