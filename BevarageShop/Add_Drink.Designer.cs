
namespace BevarageShop
{
    partial class Add_Drink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Drink));
            this.label1 = new System.Windows.Forms.Label();
            this.id_drink_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bought_field = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_field = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.CB_DistributorId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "id drink";
            // 
            // id_drink_field
            // 
            this.id_drink_field.Location = new System.Drawing.Point(169, 56);
            this.id_drink_field.Name = "id_drink_field";
            this.id_drink_field.Size = new System.Drawing.Size(110, 23);
            this.id_drink_field.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // bought_field
            // 
            this.bought_field.Location = new System.Drawing.Point(169, 150);
            this.bought_field.Name = "bought_field";
            this.bought_field.Size = new System.Drawing.Size(110, 23);
            this.bought_field.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number Bought";
            // 
            // price_field
            // 
            this.price_field.Location = new System.Drawing.Point(169, 200);
            this.price_field.Name = "price_field";
            this.price_field.Size = new System.Drawing.Size(110, 23);
            this.price_field.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "price(cents)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distributor ID";
            // 
            // date_field
            // 
            this.date_field.Location = new System.Drawing.Point(169, 300);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(110, 23);
            this.date_field.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Added";
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(169, 106);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(110, 23);
            this.name_field.TabIndex = 3;
            // 
            // CB_DistributorId
            // 
            this.CB_DistributorId.FormattingEnabled = true;
            this.CB_DistributorId.Location = new System.Drawing.Point(169, 258);
            this.CB_DistributorId.Name = "CB_DistributorId";
            this.CB_DistributorId.Size = new System.Drawing.Size(121, 23);
            this.CB_DistributorId.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(240, 376);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(0, 15);
            this.Status_label.TabIndex = 14;
            // 
            // Add_Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 431);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CB_DistributorId);
            this.Controls.Add(this.date_field);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.price_field);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bought_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_drink_field);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Drink";
            this.Text = "Add_Drink";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_drink_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bought_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox date_field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.ComboBox CB_DistributorId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Status_label;
    }
}