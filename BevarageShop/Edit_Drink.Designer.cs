
namespace BevarageShop
{
    partial class Edit_Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Drink));
            this.name_field = new System.Windows.Forms.TextBox();
            this.bought_field = new System.Windows.Forms.TextBox();
            this.price_field = new System.Windows.Forms.TextBox();
            this.date_field = new System.Windows.Forms.TextBox();
            this.CB_distributors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(12, 85);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(100, 23);
            this.name_field.TabIndex = 0;
            // 
            // bought_field
            // 
            this.bought_field.Location = new System.Drawing.Point(147, 85);
            this.bought_field.Name = "bought_field";
            this.bought_field.Size = new System.Drawing.Size(60, 23);
            this.bought_field.TabIndex = 1;
            // 
            // price_field
            // 
            this.price_field.Location = new System.Drawing.Point(238, 85);
            this.price_field.Name = "price_field";
            this.price_field.Size = new System.Drawing.Size(100, 23);
            this.price_field.TabIndex = 2;
            // 
            // date_field
            // 
            this.date_field.Location = new System.Drawing.Point(365, 85);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(100, 23);
            this.date_field.TabIndex = 3;
            // 
            // CB_distributors
            // 
            this.CB_distributors.FormattingEnabled = true;
            this.CB_distributors.Location = new System.Drawing.Point(491, 84);
            this.CB_distributors.Name = "CB_distributors";
            this.CB_distributors.Size = new System.Drawing.Size(121, 23);
            this.CB_distributors.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bought";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date added";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(491, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Distributor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(25, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID: ";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(491, 135);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(89, 23);
            this.save_btn.TabIndex = 11;
            this.save_btn.Text = "Save changes ";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Edit_Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 181);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_distributors);
            this.Controls.Add(this.date_field);
            this.Controls.Add(this.price_field);
            this.Controls.Add(this.bought_field);
            this.Controls.Add(this.name_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Drink";
            this.Text = "Edit Drink"; 
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.TextBox bought_field;
        private System.Windows.Forms.TextBox price_field;
        private System.Windows.Forms.TextBox date_field;
        private System.Windows.Forms.ComboBox CB_distributors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button save_btn;
    }
}