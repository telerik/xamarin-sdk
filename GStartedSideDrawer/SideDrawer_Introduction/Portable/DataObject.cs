using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portable
{
    public class DataObject
    {
        public DataObject(string platformName, string binaryName)
        {
            this.Platform = platformName;
            this.BinaryName = binaryName;
        }
        public string Platform { get; set; }
        public string BinaryName { get; set; }
    }
}
