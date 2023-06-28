using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSFileCreator
{
    public class creator
    {
        internal int someValue = 55;
        //comment added
        public string log = "Let's have fun!!";

        public void complexcreator()
        {
            System.IO.Directory.CreateDirectory("C:\\FileLogger");
            Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
           
        }
    }
}
