using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Entities
{
    internal class LocalizedBook : Document
    {
        public string ISBN { get; set; }
        public int NumberOfPages { get; set; }
        public string OriginalPublisher { get; set; }
        public string CountryOfLocalization { get; set; }
        public string LocalPublisher { get; set; }
    }
}
