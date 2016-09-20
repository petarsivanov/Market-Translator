namespace Translator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.rbnFootball = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbnTennis = new System.Windows.Forms.RadioButton();
            this.rbnBasketball = new System.Windows.Forms.RadioButton();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblTranslationsLeft = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(169, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(376, 559);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(551, 51);
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(376, 559);
            this.listBox2.TabIndex = 1;
            // 
            // btnTranslate
            // 
            this.btnTranslate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTranslate.Location = new System.Drawing.Point(511, 624);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 2;
            this.btnTranslate.Text = "Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Visible = false;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPaste.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPaste.Location = new System.Drawing.Point(311, 624);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 4;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // rbnFootball
            // 
            this.rbnFootball.AutoSize = true;
            this.rbnFootball.Checked = true;
            this.rbnFootball.Location = new System.Drawing.Point(6, 19);
            this.rbnFootball.Name = "rbnFootball";
            this.rbnFootball.Size = new System.Drawing.Size(62, 17);
            this.rbnFootball.TabIndex = 5;
            this.rbnFootball.TabStop = true;
            this.rbnFootball.Text = "Football";
            this.rbnFootball.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.rbnTennis);
            this.groupBox1.Controls.Add(this.rbnBasketball);
            this.groupBox1.Controls.Add(this.rbnFootball);
            this.groupBox1.Location = new System.Drawing.Point(32, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 214);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sport:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 140);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(67, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "Olympics";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 110);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(69, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.Text = "Volleyball";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // rbnTennis
            // 
            this.rbnTennis.AutoSize = true;
            this.rbnTennis.Location = new System.Drawing.Point(6, 80);
            this.rbnTennis.Name = "rbnTennis";
            this.rbnTennis.Size = new System.Drawing.Size(57, 17);
            this.rbnTennis.TabIndex = 7;
            this.rbnTennis.Text = "Tennis";
            this.rbnTennis.UseVisualStyleBackColor = true;
            // 
            // rbnBasketball
            // 
            this.rbnBasketball.AutoSize = true;
            this.rbnBasketball.Location = new System.Drawing.Point(6, 49);
            this.rbnBasketball.Name = "rbnBasketball";
            this.rbnBasketball.Size = new System.Drawing.Size(74, 17);
            this.rbnBasketball.TabIndex = 6;
            this.rbnBasketball.Text = "Baksetball";
            this.rbnBasketball.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(169, 656);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(758, 23);
            this.progressBar.TabIndex = 7;
            this.progressBar.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopy.Location = new System.Drawing.Point(702, 624);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblTranslationsLeft
            // 
            this.lblTranslationsLeft.AutoSize = true;
            this.lblTranslationsLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTranslationsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTranslationsLeft.ForeColor = System.Drawing.Color.Red;
            this.lblTranslationsLeft.Location = new System.Drawing.Point(432, 660);
            this.lblTranslationsLeft.Name = "lblTranslationsLeft";
            this.lblTranslationsLeft.Size = new System.Drawing.Size(207, 16);
            this.lblTranslationsLeft.TabIndex = 9;
            this.lblTranslationsLeft.Text = "НЕПРЕВЕДЕНИ РЕДОВЕ: ";
            this.lblTranslationsLeft.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 687);
            this.Controls.Add(this.lblTranslationsLeft);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Translator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.RadioButton rbnFootball;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbnTennis;
        private System.Windows.Forms.RadioButton rbnBasketball;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblTranslationsLeft;
    }
}

