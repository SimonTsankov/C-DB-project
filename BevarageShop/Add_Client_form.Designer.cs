
namespace BevarageShop
{
    partial class Add_Client_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Client_form));
            this.Client_add_btn = new System.Windows.Forms.Button();
            this.id_client_field = new System.Windows.Forms.TextBox();
            this.EGN_field = new System.Windows.Forms.TextBox();
            this.Name_field = new System.Windows.Forms.TextBox();
            this.Adress_field = new System.Windows.Forms.TextBox();
            this.Number_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Status_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Client_add_btn
            // 
            this.Client_add_btn.Location = new System.Drawing.Point(508, 329);
            this.Client_add_btn.Name = "Client_add_btn";
            this.Client_add_btn.Size = new System.Drawing.Size(75, 23);
            this.Client_add_btn.TabIndex = 0;
            this.Client_add_btn.Text = "Add";
            this.Client_add_btn.UseVisualStyleBackColor = true;
            this.Client_add_btn.Click += new System.EventHandler(this.Client_add_btn_Click);
            // 
            // id_client_field
            // 
            this.id_client_field.Location = new System.Drawing.Point(122, 60);
            this.id_client_field.Name = "id_client_field";
            this.id_client_field.Size = new System.Drawing.Size(100, 23);
            this.id_client_field.TabIndex = 1;
            // 
            // EGN_field
            // 
            this.EGN_field.Location = new System.Drawing.Point(122, 120);
            this.EGN_field.Name = "EGN_field";
            this.EGN_field.Size = new System.Drawing.Size(100, 23);
            this.EGN_field.TabIndex = 2;
            // 
            // Name_field
            // 
            this.Name_field.Location = new System.Drawing.Point(122, 180);
            this.Name_field.Name = "Name_field";
            this.Name_field.Size = new System.Drawing.Size(100, 23);
            this.Name_field.TabIndex = 3;
            // 
            // Adress_field
            // 
            this.Adress_field.Location = new System.Drawing.Point(122, 240);
            this.Adress_field.Name = "Adress_field";
            this.Adress_field.Size = new System.Drawing.Size(100, 23);
            this.Adress_field.TabIndex = 4;
            // 
            // Number_field
            // 
            this.Number_field.Location = new System.Drawing.Point(122, 300);
            this.Number_field.Name = "Number_field";
            this.Number_field.Size = new System.Drawing.Size(100, 23);
            this.Number_field.TabIndex = 5;
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "id_client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "EGN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number";
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(236, 370);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(0, 15);
            this.Status_label.TabIndex = 11;
            // 
            // Add_Client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 466);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Number_field);
            this.Controls.Add(this.Adress_field);
            this.Controls.Add(this.Name_field);
            this.Controls.Add(this.EGN_field);
            this.Controls.Add(this.id_client_field);
            this.Controls.Add(this.Client_add_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Client_form";
            this.Text = "Add a Client! ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Client_add_btn;
        private System.Windows.Forms.TextBox id_client_field;
        private System.Windows.Forms.TextBox EGN_field;
        private System.Windows.Forms.TextBox Name_field;
        private System.Windows.Forms.TextBox Adress_field;
        private System.Windows.Forms.TextBox Number_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Status_label;
    }
}