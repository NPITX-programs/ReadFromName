﻿namespace ReadFromName
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
            this.lst_readAllText = new System.Windows.Forms.ListBox();
            this.btn_readAllText = new System.Windows.Forms.Button();
            this.lst_readAllLine = new System.Windows.Forms.ListBox();
            this.btn_readAllLine = new System.Windows.Forms.Button();
            this.btn_triggerAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_readAllText
            // 
            this.lst_readAllText.FormattingEnabled = true;
            this.lst_readAllText.HorizontalScrollbar = true;
            this.lst_readAllText.Location = new System.Drawing.Point(81, 0);
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
            this.lst_readAllLine.Location = new System.Drawing.Point(81, 0);
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
            this.groupBox1.Size = new System.Drawing.Size(452, 157);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_triggerAll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
    }
}

