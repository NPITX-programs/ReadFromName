﻿namespace ReadFromName
{
    partial class frm_main
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
            this.lst_readAllText = new System.Windows.Forms.ListBox();
            this.btn_readAllText = new System.Windows.Forms.Button();
            this.lst_readAllLine = new System.Windows.Forms.ListBox();
            this.btn_readAllLine = new System.Windows.Forms.Button();
            this.btn_triggerAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_stringReader = new System.Windows.Forms.Button();
            this.lst_streamReader = new System.Windows.Forms.ListBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_readAllText
            // 
            this.lst_readAllText.FormattingEnabled = true;
            this.lst_readAllText.HorizontalScrollbar = true;
            this.lst_readAllText.Location = new System.Drawing.Point(82, 0);
            this.lst_readAllText.Name = "lst_readAllText";
            this.lst_readAllText.Size = new System.Drawing.Size(370, 108);
            this.lst_readAllText.TabIndex = 0;
            // 
            // btn_readAllText
            // 
            this.btn_readAllText.Location = new System.Drawing.Point(0, 0);
            this.btn_readAllText.Name = "btn_readAllText";
            this.btn_readAllText.Size = new System.Drawing.Size(75, 44);
            this.btn_readAllText.TabIndex = 1;
            this.btn_readAllText.Text = "Read all Text";
            this.btn_readAllText.UseVisualStyleBackColor = true;
            this.btn_readAllText.Click += new System.EventHandler(this.btn_readAllText_Click);
            // 
            // lst_readAllLine
            // 
            this.lst_readAllLine.FormattingEnabled = true;
            this.lst_readAllLine.Location = new System.Drawing.Point(82, 2);
            this.lst_readAllLine.Name = "lst_readAllLine";
            this.lst_readAllLine.Size = new System.Drawing.Size(370, 108);
            this.lst_readAllLine.TabIndex = 2;
            // 
            // btn_readAllLine
            // 
            this.btn_readAllLine.Location = new System.Drawing.Point(0, 0);
            this.btn_readAllLine.Name = "btn_readAllLine";
            this.btn_readAllLine.Size = new System.Drawing.Size(75, 44);
            this.btn_readAllLine.TabIndex = 3;
            this.btn_readAllLine.Text = "Read all Lines";
            this.btn_readAllLine.UseVisualStyleBackColor = true;
            this.btn_readAllLine.Click += new System.EventHandler(this.btn_readAllLine_Click);
            // 
            // btn_triggerAll
            // 
            this.btn_triggerAll.Location = new System.Drawing.Point(12, 12);
            this.btn_triggerAll.Name = "btn_triggerAll";
            this.btn_triggerAll.Size = new System.Drawing.Size(75, 44);
            this.btn_triggerAll.TabIndex = 4;
            this.btn_triggerAll.Text = "Use all formats";
            this.btn_triggerAll.UseVisualStyleBackColor = true;
            this.btn_triggerAll.Click += new System.EventHandler(this.btn_triggerAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_readAllText);
            this.groupBox1.Controls.Add(this.lst_readAllText);
            this.groupBox1.Location = new System.Drawing.Point(345, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 114);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_readAllLine);
            this.groupBox2.Controls.Add(this.lst_readAllLine);
            this.groupBox2.Location = new System.Drawing.Point(345, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_stringReader);
            this.groupBox3.Controls.Add(this.lst_streamReader);
            this.groupBox3.Location = new System.Drawing.Point(345, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 116);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_stringReader
            // 
            this.btn_stringReader.Location = new System.Drawing.Point(0, 0);
            this.btn_stringReader.Name = "btn_stringReader";
            this.btn_stringReader.Size = new System.Drawing.Size(75, 44);
            this.btn_stringReader.TabIndex = 1;
            this.btn_stringReader.Text = "Stream Reader";
            this.btn_stringReader.UseVisualStyleBackColor = true;
            this.btn_stringReader.Click += new System.EventHandler(this.btn_streamReader_Click);
            // 
            // lst_streamReader
            // 
            this.lst_streamReader.FormattingEnabled = true;
            this.lst_streamReader.HorizontalScrollbar = true;
            this.lst_streamReader.Location = new System.Drawing.Point(82, 8);
            this.lst_streamReader.Name = "lst_streamReader";
            this.lst_streamReader.Size = new System.Drawing.Size(370, 108);
            this.lst_streamReader.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(12, 97);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 44);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_triggerAll);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "frm_main";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read from Name";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_readAllText;
        private System.Windows.Forms.Button btn_readAllText;
        private System.Windows.Forms.ListBox lst_readAllLine;
        private System.Windows.Forms.Button btn_readAllLine;
        private System.Windows.Forms.Button btn_triggerAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_stringReader;
        private System.Windows.Forms.ListBox lst_streamReader;
        private System.Windows.Forms.Button btn_close;
    }
}

