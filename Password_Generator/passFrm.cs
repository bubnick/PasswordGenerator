using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Password_Generator
{
    public partial class frmPassGen : Form
    {
        private RNGCryptoServiceProvider rng;
        private Dictionary<String, String> dict;
        List<String> nums;
        List<String> words;
        public frmPassGen()
        {
            InitializeComponent();
            rng = new RNGCryptoServiceProvider();

            dict = File.ReadLines("words.tsv").Select(line => line.Split('\t')).ToDictionary(line => line[0], line => line[1]);

            txtNumWords.ValidatingType = typeof(Int32);
            txtNumWords.MaskInputRejected += new MaskInputRejectedEventHandler(mskTxtNumWords_MaskInputRejected);
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int numWords = 0;

            nums = new List<String>();
            words = new List<String>();
            
            try
            {
                //If we cant parse the txt to an int, notify in tooltip
                numWords = (int)txtNumWords.ValidateText();
                
            }
            catch
            {
                mskTxtNumWords_MaskInputRejected(sender, null);
            }
            //If we parsed successfully
            if(numWords != 0)
            {
                //Generate random numbers for the number of words we want
                for (int i = 0; i < numWords; i++)
                {
                    String roll = "";
                    for (int j = 0; j < 5; j++)
                    {
                        roll += Roll(6);
                    }
                    nums.Add(roll);
                }
                    //Set the data source for data grid view
                    dgGenNums.DataSource = nums.Select(x => new { RollValue = x }).ToList();
                    //Refresh 
                    dgGenNums.Refresh();
                    dgGenNums.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    //Loop for each number we get and add it to our list
                    //From the dictionary we parsed earlier
                    foreach (var num in nums)
                    {
                        if (dict.ContainsKey(num))
                        {
                            words.Add(dict[num]);
                        }
                    }
                    dgGenWords.DataSource = words.Select(x => new { Word = x }).ToList();
                    dgGenWords.Refresh();
                    
                
            }
        }

        private void mskTxtNumWords_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Invalid Input";
            toolTip1.Show("Please enter a valid number.", txtNumWords, txtNumWords.Location, 5000);
        }
        private byte Roll(byte numSides)
        {
            byte[] randomNumber = new byte[1];
            do
            {
                // Fill the array with a random value.
                rng.GetBytes(randomNumber);
            }
            while (!IsFairRoll(randomNumber[0], numSides));
            // Return the random number mod the number 
            // of sides.  The possible values are zero- 
            // based, so we add one. 
            return (byte)((randomNumber[0] % numSides) + 1);
        }

        private static bool IsFairRoll(byte roll, byte numSides)
        {
            int fullSetsOfValues = Byte.MaxValue / numSides;
            return roll < numSides * fullSetsOfValues;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(true)
            {
                StringBuilder str = new StringBuilder();
                try
                {
                    foreach(var word in words)
                    {
                        str.Append(word + " ");
                    }
                    Clipboard.SetText(str.ToString().TrimEnd(' '));
                    txtNumWords.Text = "Password Copied!";
                }
                catch(Exception exp)
                {
                    txtNumWords.Text = "Please Generate a Password First.";
                }
            }
        }

        private void txtNumWords_Click(object sender, EventArgs e)
        {
            txtNumWords.SelectAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form dialog = new Popup();
            
            dialog.ShowDialog();
        }
    }
}
