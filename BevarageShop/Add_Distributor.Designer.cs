
namespace BevarageShop
{
    partial class Add_Distributor
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
            this.id_field = new System.Windows.Forms.TextBox();
            this.phone_filed = new System.Windows.Forms.TextBox();
            this.name_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id_field
            // 
            this.id_field.Location = new System.Drawing.Point(118, 24);
            this.id_field.Name = "id_field";
            this.id_field.Size = new System.Drawing.Size(100, 23);
            this.id_field.TabIndex = 0;
            // 
            // phone_filed
            // 
            this.phone_filed.Location = new System.Drawing.Point(118, 159);
            this.phone_filed.Name = "phone_filed";
            this.phone_filed.Size = new System.Drawing.Size(100, 23);
            this.phone_filed.TabIndex = 1;
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(118, 96);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(100, 23);
            this.name_field.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "id_distributor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "phone number";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(296, 241);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(118, 248);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(0, 15);
            this.Status_label.TabIndex = 7;
            // 
            // Add_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 298);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.phone_filed);
            this.Controls.Add(this.id_field);
            this.Name = "Add_Distributor";
            this.Text = "Add_Distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_field;
        private System.Windows.Forms.TextBox phone_filed;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Status_label;
    }
}