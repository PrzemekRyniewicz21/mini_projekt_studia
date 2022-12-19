using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Projekt
{
    internal class ToFile
    {
        StreamWriter sw;
        public ToFile(string path)
        {
            this.sw = new StreamWriter(path);
        }

        public void sw_save(string a)
        {
            this.sw.WriteLine(a);
            this.sw.Close();
        }
    }
}
