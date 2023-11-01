using System;
using System.Diagnostics;

namespace File_Corrupter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 1)
            {
                groupBox2.Text = "Iterations (For Randomized)";
            }
            else { groupBox2.Text = "Iteration (For Randomized)"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                button3.Enabled = false;
                button4.Enabled = false;
                linkLabel1.Text = openFileDialog1.FileName;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("explorer", string.Format("/select,\"{0}\"", openFileDialog1.FileName));
            }
            catch (Exception exc) { MessageBox.Show("Cannot open File, Exception is:\n" + exc, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "(Corrupted)" + Path.GetExtension(openFileDialog1.FileName);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.Enabled = true;
                linkLabel2.Text = saveFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timeout.Enabled = false;
            label1.Text = "";
            byte[] binaryCode = File.ReadAllBytes(openFileDialog1.FileName);

            Random random = new Random();

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index = random.Next(binaryCode.Length);
                        binaryCode[index] = (byte)~binaryCode[index];
                    }
                    break;
                case 1:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        binaryCode[index1] = (byte)((byte)binaryCode[index1] & (byte)binaryCode[index2]);
                    }
                    break;
                case 2:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        binaryCode[index1] = (byte)((byte)binaryCode[index1] | (byte)binaryCode[index2]);
                    }
                    break;
                case 3:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        binaryCode[index1] = (byte)((byte)binaryCode[index1] ^ (byte)binaryCode[index2]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        binaryCode[index1] = (byte)((byte)binaryCode[index1] << (byte)binaryCode[index2]);
                    }
                    break;
                case 5:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        binaryCode[index1] = (byte)((byte)binaryCode[index1] >> (byte)binaryCode[index2]);
                    }
                    break;
                case 6:
                    for (int i = 0; i < numericUpDown1.Value; i++)
                    {
                        int index1 = random.Next(binaryCode.Length);
                        int index2 = random.Next(binaryCode.Length);
                        (binaryCode[index1], binaryCode[index2]) = (binaryCode[index2], binaryCode[index1]);
                    }
                    break;
                case 7:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)~binaryCode[b];
                    }
                    break;
                case 8:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)((byte)binaryCode[b] & (byte)binaryCode[b]);
                    }
                    break;
                case 9:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)((byte)binaryCode[b] | (byte)binaryCode[b]);
                    }

                    break;
                case 10:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)((byte)binaryCode[b] ^ (byte)binaryCode[b]);
                    }
                    break;
                case 11:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)((byte)binaryCode[b] << (byte)binaryCode[b]);
                    }
                    break;
                case 12:

                    foreach (byte b in binaryCode)
                    {
                        binaryCode[b] = (byte)((byte)binaryCode[b] >> (byte)binaryCode[b]);
                    }
                    break;
                case 13:

                    Array.Reverse(binaryCode);

                    break;
                case 14:

                    Array.Sort(binaryCode);
                    break;
                case 15:

                    Array.Sort(binaryCode);
                    Array.Reverse(binaryCode);

                    break;

            }

            try
            {
                File.WriteAllBytes(saveFileDialog1.FileName, binaryCode);
                label1.Text = "Done, Saved Corrupted file to " + saveFileDialog1.FileName;
                button4.Enabled = true;
            }
            catch (Exception exc) { MessageBox.Show("Exception is:\n" + exc, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            timeout.Enabled = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("explorer", string.Format("/select,\"{0}\"", saveFileDialog1.FileName));
            }
            catch (Exception exc) { MessageBox.Show("Exception is:\n" + exc, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            label1.Text = "";
            timeout.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = saveFileDialog1.FileName,
                    UseShellExecute = true
                });
            }
            catch (Exception exc) { MessageBox.Show("Exception is:\n" + exc, "Exception!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}