using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinVowel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        //WHere user enters in stuff
        private void InputUser_TextChanged(object sender, EventArgs e)
        {
            
        }
        //using LINQ below


        private void VowelClick_Click(object sender, EventArgs e)
        {
            string sentence = InputUser.Text;
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            

            int total = sentence.Count(c => vowels.Contains(c));

            string totalVowels = total.ToString();
            textBox2.Text = totalVowels;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            VowelClick.Enabled = true;

        }
        //Consonant click, ConClick is name, button3 is name for stuff that happens in ConClick
        //Below and above was a mess in naming
        private void button3_Click(object sender, EventArgs e)
        {
            string sentence = InputUser.Text;
            var Cons = new HashSet<char> { 'q', 'w', 'r', 't', 'y', 'p','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m' };
            //using LINQ

            int total = sentence.Count(c => Cons.Contains(c));
            string totalCon = total.ToString();
           
            ConCount.Text = totalCon;
        }

        private void ConCount_TextChanged(object sender, EventArgs e)
        {
            ConClick.Enabled = true;
        }

        private void NumClick_Click(object sender, EventArgs e)
        {
            string sentence = InputUser.Text;
            var Number = new HashSet<char> { '1','2','3','4','5','6','7','8','9','0' };
            //using LINQ

            int total = sentence.Count(c => Number.Contains(c));

            string totalNum = total.ToString();
            
            NumCount.Text = totalNum;
        }

        private void NumCount_TextChanged(object sender, EventArgs e)
        {
            NumClick.Enabled = true;
            
        }

        private void SpaceClick_Click(object sender, EventArgs e)
        {
            string sentence = InputUser.Text;
            var Spaces = new HashSet<char> { ' ' };
            //using LINQ

            int total = sentence.Count(c => Spaces.Contains(c));
            string totalSpaces = total.ToString();
            SpaceCount.Text = totalSpaces;
        }

        private void SpaceCount_TextChanged(object sender, EventArgs e)
        {
            SpaceClick.Enabled = true;
        }
    }
}
