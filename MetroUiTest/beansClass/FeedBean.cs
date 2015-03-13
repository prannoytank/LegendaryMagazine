using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroUiTest.beansClass
{
    class FeedBean
    {
        string _title;
        string _description;
        string _list;

        public string feedTitle
        {
            get { return _title; }
            set { _title = value; }
        }

        public string feedDescription
        {
            get { return _description; }
            set { _description = value; }
        }

        public string feedLink
        {
            get { return _list; }
            set { _list = value; }
        }

    }
}
