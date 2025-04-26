using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.Product
{
    internal class ListItem
    {
        internal string Display { get; set; }
        internal string Value { get; set; }

        public override string ToString()
        {
            return Display; // `CheckedListBox` sẽ hiển thị Display
        }
    }
}
