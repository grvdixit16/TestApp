using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class ReverseString
    {
        public string _va = string.Empty;
        public ReverseString(string val) {
        _va = val;
        }

        public string reverseString()
        {
            var result = string.Empty;
            if(_va == string.Empty)
                return _va;
            char[] chars = _va.ToCharArray();
            if(chars.Length > 0)
            {
                Array.Reverse(chars);
                result = new string(chars);
            }


            return result;
        }

    }
}
