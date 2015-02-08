using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /**
         * Conversion button click handler
         * */
        private void convertBtn_Click(object sender, EventArgs e)
        {
            string [] input;
            string [] output;
            //Check to see if there is text in dokuInput
            input = this.dokuInput.Lines;
            //If text is there, pass that text into the converter
            if (input != null && input.Length > 0)
            {
                output = doku2jsp(input);
                if (output != null)
                {
                    //Take what the converter returns and drop it in jspOutput
                    this.jspOutput.Lines = output;
                    this.jspOutput.Text = postProcess(this.jspOutput.Text);
                }
            } 
        }

        private string postProcess(string p)
        {
            //Code
            p = p.Replace("<code>", "%%prettify" + System.Environment.NewLine + "{{{" + System.Environment.NewLine);
            p = p.Replace("<code javascript>", "%%prettify" + System.Environment.NewLine + "{{{" + System.Environment.NewLine);
            p = p.Replace("</code>", System.Environment.NewLine + "}}}" + System.Environment.NewLine + "/%");

            //Preformatted text
            p = p.Replace("<nowiki>", "{{{" + System.Environment.NewLine);
            p = p.Replace("</nowiki>", System.Environment.NewLine + "}}}");

            return p;
        }

        /**
         * Converts DokuWiki markup to JSPWiki markup
         * for use on TeamForge
         * @return string output
         * @param string input
         * */
        private string[] doku2jsp(string[] input)
        {
            string line;
            string[] splitStr;

            for (int l = 0; l < input.Length; l++)
            {
                line = input[l].Trim();
                //Underline
                if (line.Contains("__"))
                {
                    string[] underlineDelim = { "__" };
                    splitStr = line.Split(underlineDelim, StringSplitOptions.None);
                    line = splitStr[0] + "%%(text-decoration: underline;) " + splitStr[1] + "%%" + splitStr[2];
                    splitStr = null;
                }
                //Bold
                line = line.Replace("**", "__");
                //Italics
                line = line.Replace("//", "''");
                //Subscript
                line = line.Replace("<sub>", "%%sub ");
                line = line.Replace("</sub>", "/%");
                //Superscript
                line = line.Replace("<sup>", "%%sup ");
                line = line.Replace("</sup>", "/%");
                //Superscript
                line = line.Replace("<del>", "%%strike ");
                line = line.Replace("</del>", "/%");
                //Horizonal Rule
                line = line.Replace("----", "-----");
                //Image
                if(line.Contains("{{"))
                { 
                    int firstPos = line.IndexOf("{{") + 2;
                    int length = line.IndexOf("}}") - firstPos;
                    string content = line.Substring(firstPos, length);
                    string [] imageDelim = { "{{" + content + "}}" };

                    splitStr = line.Split(imageDelim, StringSplitOptions.None);
                    line = splitStr[0] + "[{Image src=\"" + content.Trim() + "\"}]" + splitStr[1];
                    splitStr = null;
                }
                //Unordered List
                line = line.Replace('-', '#');
                //H1
                if (line.Contains("====="))
                {
                    int firstPos = line.IndexOf("=====") + 5;
                    int length = line.LastIndexOf("=====") - firstPos;
                    string content = line.Substring(firstPos, length);
                    //Each heading goes on a separate line
                    line = "!!!" + content.Trim();
                }
                //H2
                if (line.Contains("===="))
                {
                    int firstPos = line.IndexOf("====") + 4;
                    int length = line.LastIndexOf("====") - firstPos;
                    string content = line.Substring(firstPos, length);
                    //Each heading goes on a separate line
                    line = "!!" + content.Trim();
                }
                //H3
                if (line.Contains("==="))
                {
                    int firstPos = line.IndexOf("===") + 3;
                    int length = line.LastIndexOf("===") - firstPos;
                    string content = line.Substring(firstPos, length);
                    //Each heading goes on a separate line
                    line = "!" + content.Trim();
                }
                //Table Header
                if (line[line.Length-1] == '^')
                {
                    line = line.Substring(0, line.Length - 2);
                    line = line.Replace("^", "||");
                }
                //Table Cells
                if (line[line.Length - 1] == '|')
                {
                    line = line.Substring(0, line.Length - 2);
                    //Cells are okay because they also use the | delimiter
                }

                //Reset line to new content
                input[l] = line.Trim();
            }
            return input;
        }

        /**
         * Copies text from JSP Output text field to the System Clipboard
         * */
        private void copyBtn_Click(object sender, EventArgs e)
        {
            if (this.jspOutput.Text != null && this.jspOutput.Text.Length > 0)
            {
                Clipboard.SetText(this.jspOutput.Text);
            }
        }
    }
}
