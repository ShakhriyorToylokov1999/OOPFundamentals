using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Entities
{
    internal class Book : Document
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string Publisher { get; set; }
    }
}
