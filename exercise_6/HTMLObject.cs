using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise_6
{
    class HTMLObject
    {
        public int rowNum;
        public String htmlTag;
        public String startEnd;

        public int No
        {
            get { return rowNum; }
            set { rowNum = value; }
        }

        public string Tag
        {
            get { return htmlTag; }
            set { htmlTag = value; }
        }

        public string StartEnd
        {
            get { return startEnd; }
            set { startEnd = value; }
        }
    }
}
