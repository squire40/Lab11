using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public class Movie : IComparable
    {
        private string _title;
        private string _category;

        public string Title {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public int CompareTo(object obj)
        {
            Movie movieObject = (Movie) obj;

            return movieObject.Title.CompareTo(Title);
        }
    }
}
