
namespace BevarageShop
{
    partial class Add_Invoice
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Invoice));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id_invoice = new System.Windows.Forms.TextBox();
            this.Date_field = new System.Windows.Forms.TextBox();
            this.CB_clients = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.Status_label = new System.Windows.Forms.Label();
            this.cost_field = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "id_invoice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "id_client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Creation Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "TotalCost";
            // 
            // id_invoice
            // 
            this.id_invoice.Location = new System.Drawing.Point(106, 60);
            this.id_invoice.Name = "id_invoice";
            this.id_invoice.Size = new System.Drawing.Size(121, 23);
            this.id_invoice.TabIndex = 5;
            // 
            // Date_field
            // 
            this.Date_field.Location = new System.Drawing.Point(106, 180);
            this.Date_field.Name = "Date_field";
            this.Date_field.Size = new System.Drawing.Size(121, 23);
            this.Date_field.TabIndex = 7;
            // 
            // CB_clients
            // 
            this.CB_clients.FormattingEnabled = true;
            this.CB_clients.Location = new System.Drawing.Point(106, 123);
            this.CB_clients.Name = "CB_clients";
            this.CB_clients.Size = new System.Drawing.Size(169, 23);
            this.CB_clients.TabIndex = 9;
            this.CB_clients.Text = "Chose a client!";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(465, 363);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 10;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(236, 371);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(0, 15);
            this.Status_label.TabIndex = 12;
            // 
            // cost_field
            // 
            this.cost_field.AutoSize = true;
            this.cost_field.Location = new System.Drawing.Point(106, 248);
            this.cost_field.Name = "cost_field";
            this.cost_field.Size = new System.Drawing.Size(13, 15);
            this.cost_field.TabIndex = 14;
            this.cost_field.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 445);
            this.Controls.Add(this.cost_field);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.CB_clients);
            this.Controls.Add(this.Date_field);
            this.Controls.Add(this.id_invoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Invoice";
            this.Text = "Add an Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id_invoice;
        private System.Windows.Forms.TextBox Date_field;
        private System.Windows.Forms.ComboBox CB_clients;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Label cost_field;
        private System.Windows.Forms.Timer timer1;
    }
}