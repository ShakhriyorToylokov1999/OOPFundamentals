using OOPFundamentals.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Entities
{
    internal abstract class Document : IDocument
    {
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
