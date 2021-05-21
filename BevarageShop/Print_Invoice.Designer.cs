
namespace BevarageShop
{
    partial class Print_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print_Invoice));
            this.label1 = new System.Windows.Forms.Label();
            this.date_label = new System.Windows.Forms.Label();
            this.client_label = new System.Windows.Forms.Label();
            this.items_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(109, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simon\'s Beverages  invoice";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Location = new System.Drawing.Point(163, 64);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(34, 15);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "Date:";
            // 
            // client_label
            // 
            this.client_label.AutoSize = true;
            this.client_label.Location = new System.Drawing.Point(63, 118);
            this.client_label.Name = "client_label";
            this.client_label.Size = new System.Drawing.Size(44, 15);
            this.client_label.TabIndex = 2;
            this.client_label.Text = "Client: ";
            // 
            // items_label
            // 
            this.items_label.AutoSize = true;
            this.items_label.Location = new System.Drawing.Point(63, 157);
            this.items_label.Name = "items_label";
            this.items_label.Size = new System.Drawing.Size(81, 15);
            this.items_label.TabIndex = 3;
            this.items_label.Text = "Items bought:";
            // 
            // Print_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.items_label);
            this.Controls.Add(this.client_label);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Print_Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Print_Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label client_label;
        private System.Windows.Forms.Label items_label;
    }
}