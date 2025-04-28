using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStoreManagement.ImportExport
{
    internal class ReceiptExportDetails
    {
        internal string ProductId { get; set; }
        internal int ProductQuantity { get; set; }
        internal decimal ProductPrice { get; set; }
    }
}
