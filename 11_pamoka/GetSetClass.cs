using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_pamoka
{
    class GetSetClass
    {
        private string PrivateText1 = "String1";
        private string PrivateText2 = "string2";
        private string PrivateText3 = "string3";
        private string PrivateText4 = "string4";

        public string text1
        {
            get
            {
                Console.WriteLine("nuskaitytas text1 kintamasis");
                return PrivateText1;
            }
             set
            {
                Console.WriteLine("pakeista text1 kintamojo reiksme i : "+value);
                PrivateText1 = value;
            }
        }
        public string text2
        {
            get
            {               
                return PrivateText2;
            }
            set
            {
                PrivateText2 = value;
            }
        }
        public string text3
        {
            get
            {
                return PrivateText3;
            }
            set
            {
                PrivateText3 = value;
            }
        }
        public string text4
        {
            get
            {
                return PrivateText4;
            }
            set
            {
                PrivateText4 = value;
            }
        }

    }
}
