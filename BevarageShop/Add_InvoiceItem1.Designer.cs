
namespace BevarageShop
{
    partial class Add_InvoiceItem1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_InvoiceItem1));
            this.id_II_field = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.quantity_field = new System.Windows.Forms.Label();
            this.CB_Drink = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.CB_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_II_field
            // 
            this.id_II_field.Location = new System.Drawing.Point(114, 40);
            this.id_II_field.Name = "id_II_field";
            this.id_II_field.Size = new System.Drawing.Size(100, 23);
            this.id_II_field.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "id Invoice item";
            // 
            // quantity_field
            // 
            this.quantity_field.AutoSize = true;
            this.quantity_field.Location = new System.Drawing.Point(12, 109);
            this.quantity_field.Name = "quantity_field";
            this.quantity_field.Size = new System.Drawing.Size(54, 15);
            this.quantity_field.TabIndex = 3;
            this.quantity_field.Text = "quantity ";
            // 
            // CB_Drink
            // 
            this.CB_Drink.FormattingEnabled = true;
            this.CB_Drink.Location = new System.Drawing.Point(324, 39);
            this.CB_Drink.Name = "CB_Drink";
            this.CB_Drink.Size = new System.Drawing.Size(193, 23);
            this.CB_Drink.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Drink";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(398, 142);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(236, 161);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(0, 15);
            this.Status_label.TabIndex = 7;
            // 
            // CB_id
            // 
            this.CB_id.FormattingEnabled = true;
            this.CB_id.Location = new System.Drawing.Point(324, 101);
            this.CB_id.Name = "CB_id";
            this.CB_id.Size = new System.Drawing.Size(193, 23);
            this.CB_id.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Id invoice";
            // 
            // Add_InvoiceItem1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 198);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_id);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_Drink);
            this.Controls.Add(this.quantity_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.id_II_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_InvoiceItem1";
            this.Text = "Add an invoice item ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_II_field;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label quantity_field;
        private System.Windows.Forms.ComboBox CB_Drink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.ComboBox CB_id;
        private System.Windows.Forms.Label label2;
    }
}