using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Page
    {
        public string Content { get; }
        public uint Number { get; }

        public Page(string content, uint pageNumber)
        {
            Content = content;
            Number = pageNumber;    
        }
    }
}
