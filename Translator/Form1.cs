using System;
using System.ComponentModel;
using System.Windows.Forms;
using Translator.Data;

namespace Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] objCollection;
        long counter = 0;

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            
            try
            {
                backgroundWorker.RunWorkerAsync();
            }
            catch (Exception)
            { }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            lblTranslationsLeft.Visible = false;
            lblTranslationsLeft.Text = "НЕПРЕВЕДЕНИ РЕДОВЕ: ";
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Focus();
            btnCopy.Visible = false;
            try
            {
                string s = Clipboard.GetText();
                string[] lines = s.Split(new string[] { "\r", "\r\n" }, StringSplitOptions.None);

                for (int i = 0; i < lines.Length; i++)
                {
                    if (i < lines.Length - 1)
                    {
                        listBox1.Items.Add(lines[i].Trim());
                    }
                    else
                    {
                        break;
                    }
                }

                objCollection = new string[listBox1.Items.Count];
                listBox1.Items.CopyTo(objCollection, 0);
                btnTranslate.Visible = true;
                progressBar.Maximum = objCollection.Length;
                progressBar.Minimum = 1;
                progressBar.Value = 1;
                progressBar.Step = 1;
            }
            catch (Exception)
            {

            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            btnPaste.Enabled = false;
            btnCopy.Visible = false;
            btnTranslate.Enabled = false;
            if (rbnFootball.Checked)
            {
                try
                {
                    for (int i = 0; i < objCollection.Length; i++)
                    {                        
                        string itemString = objCollection[i].ToString().ToLower();

                        for (int j = 0; j < TeamsData.Football.GetLength(0); j++)
                        {
                            int index = itemString.IndexOf(TeamsData.Football[j, 0]);

                            if (index != -1)
                            {
                                int number = TeamsData.Football[j, 0].Length;
                                string subString = itemString.Substring(index, number);
                                string translate = TeamsData.Football[j, 1];
                                itemString = itemString.Replace(subString, translate);
                                objCollection[i] = itemString;
                                j--;
                            }
                        }
                        progressBar.PerformStep();
                        foreach (char asc in itemString)
                        {
                            if ((asc != 73 && asc != 105 && asc != 88 && asc != 120) && ((asc < 91 && asc > 64) || (asc < 123 && asc > 96)))
                            {
                                counter++;
                                break;
                            }
                        }
                    }
                    btnTranslate.Visible = false;
                }
                catch (Exception)
                {

                }
            }
            else if (true)
            {

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            listBox2.Items.AddRange(objCollection);
            btnPaste.Enabled = true;
            btnTranslate.Enabled = true;
            btnCopy.Visible = true;
            btnTranslate.Visible = false;
            progressBar.Visible = false;
            if (counter > 0)
            {
                lblTranslationsLeft.Visible = true;
                lblTranslationsLeft.Text += counter + " / " + listBox2.Items.Count;
                counter = 0;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                string s1 = "";
                foreach (object item in listBox2.Items)
                    s1 += item.ToString() + "\r\n";
                Clipboard.SetText(s1);
            }
            catch { }
        }
    }
}
