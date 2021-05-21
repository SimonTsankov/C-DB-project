
namespace BevarageShop
{
    partial class Edit_Invoice_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Invoice_Item));
            this.CB_id_invoice = new System.Windows.Forms.ComboBox();
            this.quantity_field = new System.Windows.Forms.TextBox();
            this.CB_Drink = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_id_invoice
            // 
            this.CB_id_invoice.FormattingEnabled = true;
            this.CB_id_invoice.Location = new System.Drawing.Point(350, 90);
            this.CB_id_invoice.Name = "CB_id_invoice";
            this.CB_id_invoice.Size = new System.Drawing.Size(120, 23);
            this.CB_id_invoice.TabIndex = 0;
            // 
            // quantity_field
            // 
            this.quantity_field.Location = new System.Drawing.Point(210, 90);
            this.quantity_field.Name = "quantity_field";
            this.quantity_field.Size = new System.Drawing.Size(100, 23);
            this.quantity_field.TabIndex = 1;
            // 
            // CB_Drink
            // 
            this.CB_Drink.FormattingEnabled = true;
            this.CB_Drink.Location = new System.Drawing.Point(50, 90);
            this.CB_Drink.Name = "CB_Drink";
            this.CB_Drink.Size = new System.Drawing.Size(120, 23);
            this.CB_Drink.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drink";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Invoice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(50, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID: ";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(500, 136);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(90, 30);
            this.Save_btn.TabIndex = 7;
            this.Save_btn.Text = "Save changes";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Edit_Invoice_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 181);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Drink);
            this.Controls.Add(this.quantity_field);
            this.Controls.Add(this.CB_id_invoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Invoice_Item";
            this.Text = "Edit Invoice Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_id_invoice;
        private System.Windows.Forms.TextBox quantity_field;
        private System.Windows.Forms.ComboBox CB_Drink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save_btn;
    }
}