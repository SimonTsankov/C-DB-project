
namespace BevarageShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.Debuging_label = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.sql_text_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.executeSQL_btn = new System.Windows.Forms.Button();
            this.queryStatus = new System.Windows.Forms.Label();
            this.openFile_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(614, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(128, 45);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 1;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Clients",
            "Invoices",
            "Invoice Items",
            "Drinks",
            "Distributors"});
            this.comboBox1.Location = new System.Drawing.Point(209, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Clients";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(536, 45);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "Add item";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(536, 97);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(117, 22);
            this.del_btn.TabIndex = 4;
            this.del_btn.Text = "Delete row";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // Debuging_label
            // 
            this.Debuging_label.AutoSize = true;
            this.Debuging_label.Location = new System.Drawing.Point(536, 392);
            this.Debuging_label.Name = "Debuging_label";
            this.Debuging_label.Size = new System.Drawing.Size(0, 15);
            this.Debuging_label.TabIndex = 5;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(676, 45);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 23);
            this.edit_btn.TabIndex = 7;
            this.edit_btn.Text = "Edit row";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // sql_text_field
            // 
            this.sql_text_field.AcceptsTab = true;
            this.sql_text_field.Location = new System.Drawing.Point(676, 158);
            this.sql_text_field.Multiline = true;
            this.sql_text_field.Name = "sql_text_field";
            this.sql_text_field.Size = new System.Drawing.Size(187, 136);
            this.sql_text_field.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Execute SQL: ";
            // 
            // executeSQL_btn
            // 
            this.executeSQL_btn.Location = new System.Drawing.Point(768, 301);
            this.executeSQL_btn.Name = "executeSQL_btn";
            this.executeSQL_btn.Size = new System.Drawing.Size(75, 23);
            this.executeSQL_btn.TabIndex = 10;
            this.executeSQL_btn.Text = "Execute";
            this.executeSQL_btn.UseVisualStyleBackColor = true;
            this.executeSQL_btn.Click += new System.EventHandler(this.executeSQL_btn_Click);
            // 
            // queryStatus
            // 
            this.queryStatus.AutoSize = true;
            this.queryStatus.Location = new System.Drawing.Point(676, 350);
            this.queryStatus.Name = "queryStatus";
            this.queryStatus.Size = new System.Drawing.Size(0, 15);
            this.queryStatus.TabIndex = 11;
            // 
            // openFile_btn
            // 
            this.openFile_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.openFile_btn.Location = new System.Drawing.Point(676, 300);
            this.openFile_btn.Name = "openFile_btn";
            this.openFile_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.openFile_btn.Size = new System.Drawing.Size(86, 24);
            this.openFile_btn.TabIndex = 12;
            this.openFile_btn.Text = "Open sql file";
            this.openFile_btn.UseVisualStyleBackColor = true;
            this.openFile_btn.Click += new System.EventHandler(this.openFile_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.openFile_btn);
            this.Controls.Add(this.queryStatus);
            this.Controls.Add(this.executeSQL_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sql_text_field);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.Debuging_label);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.refresh_btn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.01D;
            this.Text = "Beverage Shop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Label Debuging_label;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox sql_text_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button executeSQL_btn;
        private System.Windows.Forms.Label queryStatus;
        private System.Windows.Forms.Button openFile_btn;
    }
}

