using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APA201.Models
{
    public abstract class Media
    {
        public string _title;
        public int _year;

        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Trim() != "")
                {
                    _title = value;
                }
                else
                {
                    Console.WriteLine("Title bos yazmaq olmur");
                }
                _title = value; 
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Il menfi ola bilmez");
                }
                _year = value;
            }
        }

        public abstract void DisplayInfo();
       
    }
}
