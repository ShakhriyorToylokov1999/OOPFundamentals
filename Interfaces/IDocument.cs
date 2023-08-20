using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFundamentals.Interfaces
{
    internal interface IDocument
    {
        string Title { get; set; }
        string[] Authors { get; set; }
        DateTime DatePublished { get; set; }
    }
}
