using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exercise_6
{
    internal class Tokenizer
    {
        public static List<HTMLObject> SyntaxFunc(List<HTMLObject> list, TSymbolType symbol, int i, string str)
        {
            HTMLObject HTML = new HTMLObject();

            if (symbol == TSymbolType.html_tagS)
            {
                HTML.htmlTag = "<html>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.html_tagE)
            {
                HTML.htmlTag = "</html>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.b_tagS)
            {
                HTML.htmlTag = "<b>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.b_tagE)
            {
                HTML.htmlTag = "</b>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.p_tagS)
            {
                HTML.htmlTag = "<p>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.p_tagE)
            {
                HTML.htmlTag = "</p>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h1_tagS)
            {
                HTML.htmlTag = "<h1>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h1_tagE)
            {
                HTML.htmlTag = "</h1>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h2_tagS)
            {
                HTML.htmlTag = "<h2>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h2_tagE)
            {
                HTML.htmlTag = "</h2>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h3_tagS)
            {
                HTML.htmlTag = "<h3>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h3_tagE)
            {
                HTML.htmlTag = "</h3>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h4_tagS)
            {
                HTML.htmlTag = "<h4>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h4_tagE)
            {
                HTML.htmlTag = "</h4>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h5_tagS)
            {
                HTML.htmlTag = "<h5>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h5_tagE)
            {
                HTML.htmlTag = "</h5>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h6_tagS)
            {
                HTML.htmlTag = "<h6>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.h6_tagE)
            {
                HTML.htmlTag = "</h6>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.head_tagS)
            {
                HTML.htmlTag = "<head>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.head_tagE)
            {
                HTML.htmlTag = "</head>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.i_tagS)
            {
                HTML.htmlTag = "<i>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.i_tagE)
            {
                HTML.htmlTag = "</i>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.ol_tagS)
            {
                HTML.htmlTag = "<ol>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.ol_tagE)
            {
                HTML.htmlTag = "</ol>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.ul_tagS)
            {
                HTML.htmlTag = "<ul>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.ul_tagE)
            {
                HTML.htmlTag = "</ul>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.meta_tagS)
            {
                HTML.htmlTag = "<meta>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.meta_tagE)
            {
                HTML.htmlTag = "</meta>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.li_tagS)
            {
                HTML.htmlTag = "<li>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.li_tagE)
            {
                HTML.htmlTag = "</li>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.title_tagS)
            {
                HTML.htmlTag = "<title>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.title_tagE)
            {
                HTML.htmlTag = "</title>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.table_tagS)
            {
                HTML.htmlTag = "<table>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.table_tagE)
            {
                HTML.htmlTag = "</table>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.tr_tagS)
            {
                HTML.htmlTag = "<tr>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.tr_tagE)
            {
                HTML.htmlTag = "</tr>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.td_tagS)
            {
                HTML.htmlTag = "<td>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.td_tagE)
            {
                HTML.htmlTag = "</td>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.body_tagS)
            {
                HTML.htmlTag = "<body>";
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            if (symbol == TSymbolType.body_tagE)
            {
                HTML.htmlTag = "</body>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            else if (symbol == TSymbolType.plaintext)
            {
                HTML.htmlTag = str;
                HTML.startEnd = "Text";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            else if (symbol == TSymbolType.a_tagS)
            {
                HTML.htmlTag = "<a> URL: " + str.Substring(8, str.Length - 9);
                HTML.startEnd = "Start";
                HTML.rowNum = i;
                list.Add(HTML);
            }
            else if (symbol == TSymbolType.a_tagE)
            {
                HTML.htmlTag = "</a>";
                HTML.startEnd = "End";
                HTML.rowNum = i;
                list.Add(HTML);
            }

            return list;
        }
    }
}
