
namespace BevarageShop
{
    partial class Edit_Invoice_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Invoice_Form));
            this.date_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_clients = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Id_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_field
            // 
            this.date_field.Location = new System.Drawing.Point(80, 83);
            this.date_field.Name = "date_field";
            this.date_field.Size = new System.Drawing.Size(100, 23);
            this.date_field.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creation Date";
            // 
            // CB_clients
            // 
            this.CB_clients.FormattingEnabled = true;
            this.CB_clients.Location = new System.Drawing.Point(360, 82);
            this.CB_clients.Name = "CB_clients";
            this.CB_clients.Size = new System.Drawing.Size(121, 23);
            this.CB_clients.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Client";
            // 
            // Save_btn
            // 
            this.Save_btn.Location = new System.Drawing.Point(488, 137);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(110, 22);
            this.Save_btn.TabIndex = 6;
            this.Save_btn.Text = "Save Changes";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Id_label
            // 
            this.Id_label.AutoSize = true;
            this.Id_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id_label.ForeColor = System.Drawing.Color.Maroon;
            this.Id_label.Location = new System.Drawing.Point(80, 20);
            this.Id_label.Name = "Id_label";
            this.Id_label.Size = new System.Drawing.Size(99, 25);
            this.Id_label.TabIndex = 7;
            this.Id_label.Text = "Invoice ID:";
            // 
            // Edit_Invoice_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 181);
            this.Controls.Add(this.Id_label);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CB_clients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_field);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edit_Invoice_Form";
            this.Text = "Edit Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox date_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_clients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label Id_label;
    }
}