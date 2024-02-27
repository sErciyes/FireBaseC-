namespace FireBaseC_
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNewUsername = new System.Windows.Forms.TextBox();
            this.txtNewSurname = new System.Windows.Forms.TextBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 26);
            this.textBox2.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.labelControl1.LineVisible = true;
            this.labelControl1.Location = new System.Drawing.Point(14, 94);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.LineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.label1.LineVisible = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "İsim";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.Location = new System.Drawing.Point(243, 31);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(164, 26);
            this.txtNewUsername.TabIndex = 8;
            // 
            // txtNewSurname
            // 
            this.txtNewSurname.Location = new System.Drawing.Point(243, 86);
            this.txtNewSurname.Margin = new System.Windows.Forms.Padding(5);
            this.txtNewSurname.Name = "txtNewSurname";
            this.txtNewSurname.Size = new System.Drawing.Size(164, 26);
            this.txtNewSurname.TabIndex = 9;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.ImageOptions.Image = global::FireBaseC_.Properties.Resources.download_32x32;
            this.simpleButton4.Location = new System.Drawing.Point(243, 221);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(164, 54);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "Read";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.ImageOptions.Image = global::FireBaseC_.Properties.Resources.delete_32x32;
            this.simpleButton3.Location = new System.Drawing.Point(54, 221);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(164, 54);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Delete";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.Image = global::FireBaseC_.Properties.Resources.refreshallpivottable_32x32;
            this.simpleButton2.Location = new System.Drawing.Point(243, 134);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(164, 54);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Update";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.ImageOptions.Image = global::FireBaseC_.Properties.Resources.publish_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(54, 134);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 54);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Insert";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(54, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 186);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.txtNewSurname);
            this.Controls.Add(this.txtNewUsername);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.TextBox txtNewSurname;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

