using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Hometask.Models
{
    internal class Book
    {
        public Book(string bookName, string authorName, int count)
        {
            BookName = bookName;
            AuthorName = authorName;
            Count = count;
        }

        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Count { get; set; }
    }
}
