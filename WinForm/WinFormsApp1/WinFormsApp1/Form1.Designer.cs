
namespace WinFormsApp1
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtNode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBananoAddress = new System.Windows.Forms.TextBox();
            this.btnGetBal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHistoryStuff = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(496, 80);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(168, 23);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "7070";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNode
            // 
            this.txtNode.Location = new System.Drawing.Point(151, 80);
            this.txtNode.Name = "txtNode";
            this.txtNode.Size = new System.Drawing.Size(168, 23);
            this.txtNode.TabIndex = 14;
            this.txtNode.Text = "api-beta.banano.cc";
            this.txtNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test grabs address information using Banano RPC calls with NANO API classes for ." +
    "net";
            // 
            // lblBal
            // 
            this.lblBal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBal.Location = new System.Drawing.Point(810, 78);
            this.lblBal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBal.Name = "lblBal";
            this.lblBal.Size = new System.Drawing.Size(202, 25);
            this.lblBal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Your Banano Address";
            // 
            // txtBananoAddress
            // 
            this.txtBananoAddress.Location = new System.Drawing.Point(14, 44);
            this.txtBananoAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtBananoAddress.Name = "txtBananoAddress";
            this.txtBananoAddress.Size = new System.Drawing.Size(650, 23);
            this.txtBananoAddress.TabIndex = 10;
            this.txtBananoAddress.Text = "ban_3pb9kq88qtmy4kcxjwufcifnhztnabr3n5sueinaejefhcmha3bfjszctyge";
            // 
            // btnGetBal
            // 
            this.btnGetBal.Location = new System.Drawing.Point(674, 35);
            this.btnGetBal.Margin = new System.Windows.Forms.Padding(5);
            this.btnGetBal.Name = "btnGetBal";
            this.btnGetBal.Size = new System.Drawing.Size(122, 38);
            this.btnGetBal.TabIndex = 9;
            this.btnGetBal.Text = "Get Balance";
            this.btnGetBal.UseVisualStyleBackColor = true;
            this.btnGetBal.Click += new System.EventHandler(this.btnGetBal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Banano Node to query:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Banano Node Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 83);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Banano Address Balance:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Get Transaction History!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHistoryStuff
            // 
            this.txtHistoryStuff.Location = new System.Drawing.Point(14, 168);
            this.txtHistoryStuff.Multiline = true;
            this.txtHistoryStuff.Name = "txtHistoryStuff";
            this.txtHistoryStuff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistoryStuff.Size = new System.Drawing.Size(586, 208);
            this.txtHistoryStuff.TabIndex = 20;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(904, 168);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(122, 38);
            this.btnSend.TabIndex = 21;
            this.btnSend.Text = "Send Ban";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(717, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 388);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtHistoryStuff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtNode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBananoAddress);
            this.Controls.Add(this.btnGetBal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtNode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBananoAddress;
        private System.Windows.Forms.Button btnGetBal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHistoryStuff;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
    }
}

