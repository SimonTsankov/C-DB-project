
namespace BevarageShop
{
    partial class Edit_Distributor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Distributor));
            this.name_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number_field = new System.Windows.Forms.TextBox();
            this.ID_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(34, 88);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(153, 23);
            this.name_field.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone Number";
            // 
            // number_field
            // 
            this.number_field.Location = new System.Drawing.Point(218, 88);
            this.number_field.Name = "number_field";
            this.number_field.Size = new System.Drawing.Size(136, 23);
            this.number_field.TabIndex = 2;
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID_label.ForeColor = System.Drawing.Color.Maroon;
            this.ID_label.Location = new System.Drawing.Point(46, 20);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(39, 25);
            this.ID_label.TabIndex = 4;
            this.ID_label.Text = "ID: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Edit_Distributor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ID_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Distributor";
            this.Text = "Edit Distributor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number_field;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Button button1;
    }
}