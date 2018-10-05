using System;
using System.Text;
using System.Windows.Forms;

namespace MobileQueryConverter
{
    public partial class QueryConverter : Form
    {
        public QueryConverter()
        {
            InitializeComponent();
        }

        private void rtbBefore_TextChanged(object sender, EventArgs e)
        {
            var result = rtbBefore.Text
                .Replace("SQLStmt.Append(\"", "")
                .Replace("\");", "");

            var lines = result.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            foreach (var line in lines)
            {
                if (!line.StartsWith("//"))
                {
                    if (line.Contains("//"))
                    {
                        sb.AppendLine(line.Split(new string[] { "//" }, StringSplitOptions.RemoveEmptyEntries)[0].Trim());
                    }
                    else
                    {
                        sb.AppendLine(line.Trim());
                    }
                }
            }

            rtbAfter.Text = sb.ToString();
            Clipboard.SetText(rtbAfter.Text);
        }
    }
}
