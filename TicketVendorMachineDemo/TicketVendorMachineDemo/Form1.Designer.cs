using System;

namespace TicketVendorDemo
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
        // Add this method to the Form1 class
        private void label1_Click(object sender, EventArgs e)
        {
            // You can leave this empty or add functionality if needed
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDestinations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFareDisplay = new System.Windows.Forms.Label();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOutputMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Destination";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbDestinations
            // 
            this.cmbDestinations.FormattingEnabled = true;
            this.cmbDestinations.Location = new System.Drawing.Point(50, 60);
            this.cmbDestinations.Name = "cmbDestinations";
            this.cmbDestinations.Size = new System.Drawing.Size(121, 24);
            this.cmbDestinations.TabIndex = 1;
            this.cmbDestinations.SelectedIndexChanged += new System.EventHandler(this.cmbDestinations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fare";
            // 
            // lblFareDisplay
            // 
            this.lblFareDisplay.AutoSize = true;
            this.lblFareDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFareDisplay.Location = new System.Drawing.Point(120, 110);
            this.lblFareDisplay.Name = "lblFareDisplay";
            this.lblFareDisplay.Size = new System.Drawing.Size(33, 18);
            this.lblFareDisplay.TabIndex = 3;
            this.lblFareDisplay.Text = "0.00";
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Enabled = false;
            this.btnBuyTicket.Location = new System.Drawing.Point(50, 160);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(75, 23);
            this.btnBuyTicket.TabIndex = 4;
            this.btnBuyTicket.Text = "Buy Ticket";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // lblOutputMessage
            // 
            this.lblOutputMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblOutputMessage.Location = new System.Drawing.Point(120, 210);
            this.lblOutputMessage.Name = "lblOutputMessage";
            this.lblOutputMessage.Size = new System.Drawing.Size(100, 23);
            this.lblOutputMessage.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 614);
            this.Controls.Add(this.lblOutputMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.lblFareDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbDestinations);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDestinations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFareDisplay;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOutputMessage;
    }
}

