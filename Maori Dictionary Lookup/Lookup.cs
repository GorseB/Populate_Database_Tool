using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Populate_Database_Tool
{
    public partial class Lookup : Form
    {
        public Lookup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Result = "N/A";
            try
            {
                Result = GetData.GetSource("http://maoridictionary.co.nz/search?idiom=0&phrase=0&proverb=0&loan=0&histLoanWords=&keywords=" + textBox1.Text.ToString());
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                Application.Exit();
            }
            if (Result == "N/A")
            {
                MessageBox.Show("Result was N/A , Exiting");
                Application.Exit();
            }
            else
            {
                int SIndex = Result.IndexOf(@"<h2 class=""title  "">") + 20;
                int SENDIndex = Result.IndexOf(@"</div><!-- end .detail -->");
                Result = Result.Substring(SIndex, SENDIndex - SIndex);
                Result = GetDenotation(Result);
                Result = GetTranslation(Result);
                Result = GetMaori(Result);
                WriteToFile(Result);
            }
        }

        private int IndexOfOccurence(string s, string match, int occurence)
        {
            int i = 1;
            int index = 0;

            while (i <= occurence && (index = s.IndexOf(match, index + 1)) != -1)
            {
                if (i == occurence)
                    return index;

                i++;
            }

            return -1;
        }

        private void WriteToFile(string Result)
        {
            StreamWriter Writer = new StreamWriter("Result.txt");
            Writer.Write(Result);
            Writer.Close();
        }

        private string GetDenotation(string Result)
        {
            int DIndex = Result.IndexOf("<strong>(") + 9;
            int DENDIndex = Result.LastIndexOf(")</strong>");
            string Denotation = Result.Substring(DIndex, DENDIndex - DIndex);
            Denotation = UppercaseFirst(Denotation);
            Denotation = System.Net.WebUtility.HtmlDecode(Denotation);
            txt_Denotation.Text = Denotation;
            Result = Result.Substring(DENDIndex + 10, Result.Length - (DENDIndex + 10));
            return Result;
        }

        private string GetTranslation(string Result)
        {
            int TIndex = Result.TakeWhile(char.IsWhiteSpace).Count();
            int TENDIndex = Result.IndexOf("</p>");
            string Translation = Result.Substring(TIndex, TENDIndex - TIndex);
            Translation = Regex.Replace(Translation, "<.*?>", String.Empty);
            Translation = System.Net.WebUtility.HtmlDecode(Translation);
            txt_Translation.Text = Translation;
            Result = Result.Substring(TENDIndex + 4, Result.Length - (TENDIndex + 4));
            return Result;
        }

        private string GetMaori(string Result)
        {
            int MIndex = Result.IndexOf("<em>") + 4;
            int MENDIndex = Result.IndexOf("(") - 1;
            string Maori = Result.Substring(MIndex, MENDIndex - MIndex);
            Maori = Regex.Replace(Maori, "<.*?>", String.Empty);
            Maori = System.Net.WebUtility.HtmlDecode(Maori);
            Maori += ".";
            txt_MSentence.Text = Maori;
            Result = Result.Substring(MENDIndex + 5, Result.Length - (MENDIndex + 5));
            return Result;
        }

        private static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}