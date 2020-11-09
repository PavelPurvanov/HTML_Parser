using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercise_6
{
    internal class Scanner
    {

        public static void input(string text, LinkLabel linkLabel1, DataGridView dataGridView1) 
        {
            
            List<String> words = new List<String>();

            Form1 fm = new Form1();

            removeSymbols(text, words);
            removeWhiteSpaces(words);
            
            List<HTMLObject> HTMLwordsList = new List<HTMLObject>();
  
            for (int i = 1; i < words.Count; i++)
            {
                TSymbolType symbol = new TSymbolType();
                if (words[i].Equals("html"))
                {
                    symbol = TSymbolType.html_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/html"))
                {
                    symbol = TSymbolType.html_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("b"))
                {
                    symbol = TSymbolType.b_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/b"))
                {
                    symbol = TSymbolType.b_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("p"))
                {
                    symbol = TSymbolType.p_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/p"))
                {
                    symbol = TSymbolType.p_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h1"))
                {
                    symbol = TSymbolType.h1_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h1"))
                {
                    symbol = TSymbolType.h1_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h2"))
                {
                    symbol = TSymbolType.h2_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h2"))
                {
                    symbol = TSymbolType.h2_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h3"))
                {
                    symbol = TSymbolType.h3_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h3"))
                {
                    symbol = TSymbolType.h3_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h4"))
                {
                    symbol = TSymbolType.h4_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h4"))
                {
                    symbol = TSymbolType.h4_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h5"))
                {
                    symbol = TSymbolType.h5_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h5"))
                {
                    symbol = TSymbolType.h5_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("h6"))
                {
                    symbol = TSymbolType.h6_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/h6"))
                {
                    symbol = TSymbolType.h6_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("head"))
                {
                    symbol = TSymbolType.head_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/head"))
                {
                    symbol = TSymbolType.head_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("i"))
                {
                    symbol = TSymbolType.i_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/i"))
                {
                    symbol = TSymbolType.i_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("ol"))
                {
                    symbol = TSymbolType.ol_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/ol"))
                {
                    symbol = TSymbolType.ol_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("ul"))
                {
                    symbol = TSymbolType.ul_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/ul"))
                {
                    symbol = TSymbolType.ul_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("meta"))
                {
                    symbol = TSymbolType.meta_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/meta"))
                {
                    symbol = TSymbolType.meta_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("li"))
                {
                    symbol = TSymbolType.li_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/li"))
                {
                    symbol = TSymbolType.li_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("title"))
                {
                    symbol = TSymbolType.title_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/title"))
                {
                    symbol = TSymbolType.title_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("table"))
                {
                    symbol = TSymbolType.table_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/table"))
                {
                    symbol = TSymbolType.table_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("tr"))
                {
                    symbol = TSymbolType.tr_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/tr"))
                {
                    symbol = TSymbolType.tr_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("td"))
                {
                    symbol = TSymbolType.td_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/td"))
                {
                    symbol = TSymbolType.td_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("body"))
                {
                    symbol = TSymbolType.body_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Equals("/body"))
                {
                    symbol = TSymbolType.body_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Contains("href"))
                {
                    symbol = TSymbolType.a_tagS;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                    linkLabel1.Text = words[i].Substring(8, words[i].Length - 9);
                }
                else if (words[i].Contains("/a"))
                {
                    symbol = TSymbolType.a_tagE;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Contains(" "))
                {
                    symbol = TSymbolType.plaintext;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Contains("\n"))
                {
                    symbol = TSymbolType.plaintext;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else if (words[i].Contains("\r"))
                {
                    symbol = TSymbolType.plaintext;
                    HTMLwordsList = Tokenizer.SyntaxFunc(HTMLwordsList, symbol, i, words[i]);
                }
                else
                {
                    symbol = TSymbolType.othertag;

                    if (MessageBox.Show("Неразпознат таг след ред :  " + i.ToString() + Environment.NewLine + "Продължение ?", "HTML Parser", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        fm.Close();
                        break;
                    }
                }
            }

            dataGridView1.DataSource = HTMLwordsList;
        
        }


        public static void removeSymbols(string text, List<string> list)
        {
            string buff = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '<' && text[i] != '>')
                {
                    buff = buff + text[i];
                    continue;
                }
                list.Add(buff);
                buff = "";
            }
        }


        public static void removeWhiteSpaces(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals("\r\n")
                    || list[i].Equals("\r\n\r\n")
                    || list[i].Equals("\r\n ")
                    || list[i].Equals("\r\n  ")
                    || list[i].Equals("\r\n\r\n   ")
                    || list[i].Equals("\r\n    ")
                    || list[i].Equals(" ")
                    || list[i].Equals("/r")
                    || list[i].Equals("n")
                    || list[i].Equals(" \r\n")
                    || list[i].Equals(" \r\n  ")
                    || list[i].Equals(" \r\n     ")
                    || list[i].Equals("\r\n   ")
                    || list[i].Equals(" \r\n   ")
                    || list[i].Equals(" \r\n       ")
                    || list[i].Equals("\r\n      ")
                    || list[i].Equals("  ")
                    || list[i].Equals("\r\n\r\n      ")
                    )
                {
                    list.RemoveAt(i);
                }
            }
        }
        
        }
    }