
namespace BevarageShop
{
    partial class Edit_Client_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Client_Form));
            this.egn_field = new System.Windows.Forms.TextBox();
            this.name_field = new System.Windows.Forms.TextBox();
            this.adress_field = new System.Windows.Forms.TextBox();
            this.number_field = new System.Windows.Forms.TextBox();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Client_ID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // egn_field
            // 
            this.egn_field.Location = new System.Drawing.Point(40, 68);
            this.egn_field.Name = "egn_field";
            this.egn_field.Size = new System.Drawing.Size(100, 23);
            this.egn_field.TabIndex = 0;
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(180, 68);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(100, 23);
            this.name_field.TabIndex = 1;
            // 
            // adress_field
            // 
            this.adress_field.Location = new System.Drawing.Point(320, 68);
            this.adress_field.Name = "adress_field";
            this.adress_field.Size = new System.Drawing.Size(100, 23);
            this.adress_field.TabIndex = 2;
            // 
            // number_field
            // 
            this.number_field.Location = new System.Drawing.Point(460, 68);
            this.number_field.Name = "number_field";
            this.number_field.Size = new System.Drawing.Size(100, 23);
            this.number_field.TabIndex = 3;
            // 
            // Edit_btn
            // 
            this.Edit_btn.Location = new System.Drawing.Point(472, 129);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(112, 25);
            this.Edit_btn.TabIndex = 4;
            this.Edit_btn.Text = "Save changes!";
            this.Edit_btn.UseVisualStyleBackColor = true;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "EGN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adress";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(460, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number";
            // 
            // Client_ID_label
            // 
            this.Client_ID_label.AutoSize = true;
            this.Client_ID_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Client_ID_label.ForeColor = System.Drawing.Color.Maroon;
            this.Client_ID_label.Location = new System.Drawing.Point(40, 13);
            this.Client_ID_label.Name = "Client_ID_label";
            this.Client_ID_label.Size = new System.Drawing.Size(93, 25);
            this.Client_ID_label.TabIndex = 11;
            this.Client_ID_label.Text = "Client ID: ";
            // 
            // Edit_Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 181);
            this.Controls.Add(this.Client_ID_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.number_field);
            this.Controls.Add(this.adress_field);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.egn_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Client_Form";
            this.Text = "Edit Client Row ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox egn_field;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.TextBox adress_field;
        private System.Windows.Forms.TextBox number_field;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Client_ID_label;
    }
}