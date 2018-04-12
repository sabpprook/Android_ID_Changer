using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Android_ID_Changer
{
    public class Item
    {
        public Item(string value, string package, string defaultValue)
        {
            this.value = value;
            this.package = package;
            this.defaultValue = defaultValue;
        }
        public string value { get; set; }
        public string package { get; set; }
        public string defaultValue { get; set; }
        public override string ToString()
        {
            return package;
        }
    }
}
