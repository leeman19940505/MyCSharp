﻿namespace AsyncTest
{
    partial class SyncTest
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
            //this.components = new System.ComponentModel.Container();
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.ClientSize = new System.Drawing.Size(800, 450);
            //this.Text = "SyncTest";

            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbState = new System.Windows.Forms.RichTextBox();
            this.txbUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownLoad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbState);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态：";
            // 
            // rtbState
            // 
            this.rtbState.Location = new System.Drawing.Point(7, 13);
            this.rtbState.Name = "rtbState";
            this.rtbState.Size = new System.Drawing.Size(411, 81);
            this.rtbState.TabIndex = 0;
            this.rtbState.Text = "";
            // 
            // txbUrl
            // 
            this.txbUrl.Location = new System.Drawing.Point(75, 12);
            this.txbUrl.Name = "txbUrl";
            this.txbUrl.Size = new System.Drawing.Size(286, 21);
            this.txbUrl.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "下载地址：";
            // 
            // btnDownLoad
            // 
            this.btnDownLoad.Location = new System.Drawing.Point(367, 10);
            this.btnDownLoad.Name = "btnDownLoad";
            this.btnDownLoad.Size = new System.Drawing.Size(63, 23);
            this.btnDownLoad.TabIndex = 4;
            this.btnDownLoad.Text = "下载";
            this.btnDownLoad.UseVisualStyleBackColor = true;
            this.btnDownLoad.Click += new System.EventHandler(this.btnDownLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 181);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownLoad);
            this.Name = "SyncTest";
            this.Text = "SyncTest";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbState;
        private System.Windows.Forms.TextBox txbUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownLoad;
    }
}