using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Title { get; }
        public string Author { get; }

        private Page[] pages;
        public uint CurrentPage { get; set; }

        public Book(string title, string author, uint countOfPages, string[] pages)
        {
            Title = title;
            Author = author;
            this.pages = new Page[countOfPages];
            InitPages(pages);
        }
        private void InitPages(string[] pages)
        {
            uint currentPage = 1;
            foreach (string content in pages)
            {
                this.pages[currentPage - 1] = new Page(content, currentPage);
                currentPage++;
            }
        }

        public string GetAllPages()
        {
            string output = string.Empty;
            foreach (var page in pages)
            {
                output += page?.Content;
            }
            return output;
        }
        public string? GetCurrentPage() => GetPageByNumber(CurrentPage);
        private string? GetPageByNumber(uint number) => (number > 0 && number <= pages.Length) ? pages[number-1]?.Content : "Error! Page number is less or exceeds book size";
        public void AddPage(string content, uint number) => pages.Append(new Page(content, number));

        public string StartReading()
        {
            CurrentPage = 1;
            return GetPageByNumber(CurrentPage);
        }
        public string? NextPage() => GetPageByNumber(++CurrentPage);
        public string? PreviousPage() => GetPageByNumber(--CurrentPage);
    }
}
