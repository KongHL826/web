using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Model
{
    public class Book
    {
        private string displayname;
        public string DispalyName
        {
            get { return displayname; }
            set { displayname = value; }
        }
        private bool newbook;
        public bool NewBook
        {
            get { return newbook; }
            set { newbook = value; }
        }
        private int page;
        public int Page
        {
            get { return page; }
            set { page = value; }
        }
        public Book()
        {
            
        }
        public Book(string displayName)
        {
            this.displayname = displayName;
        }
        public Book(string displayName, bool newbook, int page)
        {
            this.displayname = displayName;
            this.newbook = newbook;
            this.page = page;
        }
        public string BookDetail() 
        {
            var newbookstring = newbook ? "是" : "不是";
            return "这本书名字是" + displayname + ".他有" + page + "页.这本书" + newbookstring + "一本新书.又学到新东西，今天很成功.";
        }
    }
}

