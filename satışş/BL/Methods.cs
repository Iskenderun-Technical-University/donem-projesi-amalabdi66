using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace satışş.BL
{
    class Methods
    {
         public MemoryStream ma = new MemoryStream();
        public byte[] by;
        //Convert to byte
        public byte[] convert_byte()
        {
            return ma.ToArray();
        }
        //Convert byte to image
        public MemoryStream convert_image()
        {

            ma = new MemoryStream();
            return ma;
        }

    }
}
