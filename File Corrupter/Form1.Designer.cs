namespace File_Corrupter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button2 = new Button();
            button3 = new Button();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            timeout = new System.Windows.Forms.Timer(components);
            button4 = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 0;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.Location = new Point(93, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(318, 36);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "No File";
            linkLabel1.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.Location = new Point(93, 58);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(318, 40);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "No Path";
            linkLabel2.TextAlign = ContentAlignment.MiddleLeft;
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(12, 58);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 2;
            button2.Text = "Save to";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(12, 191);
            button3.Name = "button3";
            button3.Size = new Size(118, 25);
            button3.TabIndex = 4;
            button3.Text = "Corrupt";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371, 81);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Corrupting";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(193, 22);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(172, 43);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Corruption Type";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Randomized NOT", "Randomized AND", "Randomized OR", "Randomized XOR", "Randomized Left Shift", "Randomized Right Shift", "Randomized Swap", "NOT", "AND", "OR", "XOR", "Left Shift", "Right Shift", "Reverse", "Sort ascending", "Sort descending" });
            comboBox1.Location = new Point(3, 19);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 23);
            comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(181, 43);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Iteration (For Randomized)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Dock = DockStyle.Fill;
            numericUpDown1.Location = new Point(3, 19);
            numericUpDown1.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(175, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Location = new Point(136, 193);
            label1.Name = "label1";
            label1.Size = new Size(275, 45);
            label1.TabIndex = 6;
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timeout
            // 
            timeout.Interval = 5000;
            timeout.Tick += timeout_Tick;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(12, 215);
            button4.Name = "button4";
            button4.Size = new Size(118, 25);
            button4.TabIndex = 7;
            button4.Text = "Open Corrupted";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 252);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button3);
            Controls.Add(linkLabel2);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimumSize = new Size(0, 291);
            Name = "Form1";
            Text = "File Corrupter";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private Button button2;
        private Button button3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private System.Windows.Forms.Timer timeout;
        private GroupBox groupBox3;
        private ComboBox comboBox1;
        private Button button4;
    }
}