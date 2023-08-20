using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Entities
{
    internal class Patent : Document
    {
        public string UniqueId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

}
