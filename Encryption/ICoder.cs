using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption
{
    interface ICoder
    {
        public string Encode(string value);

        public string Decode(string value);


    }
}
