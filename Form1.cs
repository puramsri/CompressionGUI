using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CompressionGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Compress button click event
        private void btnCompress_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Compress(txtInput.Text);
        }

        // Decompress button click event
        private void btnDecompress_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Decompress(txtInput.Text);
        }

        // Compression logic
        private string Compress(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            StringBuilder compressed = new();
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                    count++;
                else
                {
                    compressed.Append(count).Append(input[i - 1]);
                    count = 1;
                }
            }
            compressed.Append(count).Append(input[^1]);

            return compressed.Length < input.Length ? compressed.ToString() : input;
        }

        // Decompression logic
        private string Decompress(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            StringBuilder decompressed = new();
            MatchCollection matches = Regex.Matches(input, @"(\d+)(\D)");

            foreach (Match match in matches)
            {
                int count = int.Parse(match.Groups[1].Value);
                char character = match.Groups[2].Value[0];
                decompressed.Append(character, count);
            }
            return decompressed.ToString();
        }
    }
}