using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_Code_Decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Dictionary<string, char> morseCodeMap = new Dictionary<string, char>()
{
    { ".-", 'A' }, { "-...", 'B' }, { "-.-.", 'C' }, { "-..", 'D' }, { ".", 'E' },
    { "..-.", 'F' }, { "--.", 'G' }, { "....", 'H' }, { "..", 'I' }, { ".---", 'J' },
    { "-.-", 'K' }, { ".-..", 'L' }, { "--", 'M' }, { "-.", 'N' }, { "---", 'O' },
    { ".--.", 'P' }, { "--.-", 'Q' }, { ".-.", 'R' }, { "...", 'S' }, { "-", 'T' },
    { "..-", 'U' }, { "...-", 'V' }, { ".--", 'W' }, { "-..-", 'X' }, { "-.--", 'Y' },
    { "--..", 'Z' }, { "-----", '0' }, { ".----", '1' }, { "..---", '2' },
    { "...--", '3' }, { "....-", '4' }, { ".....", '5' }, { "-....", '6' },
    { "--...", '7' }, { "---..", '8' }, { "----.", '9' }
};

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string morseInput = txtMorseCode.Text.Trim();
            string[] morseWords = morseInput.Split(new[] { "   " }, StringSplitOptions.None);  // Triple spaces to separate words
            string decodedMessage = "";

            foreach (string word in morseWords)
            {
                string[] morseLetters = word.Split(' ');
                foreach (string morseLetter in morseLetters)
                {
                    if (morseCodeMap.TryGetValue(morseLetter, out char decodedChar))
                    {
                        decodedMessage += decodedChar;
                    }
                    else
                    {
                        decodedMessage += "?";  // If an invalid sequence is entered
                    }
                }
                decodedMessage += " ";  // Space between words
            }

            lblDecodedText.Text = decodedMessage.Trim();
        }
    }
}
