
namespace ClientApp
{
    partial class frmAdd
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
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numUD_lat = new System.Windows.Forms.NumericUpDown();
            this.numUD_lon = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_lat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_lon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(101, 30);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(150, 27);
            this.txtbox_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Latitude";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Longtitude";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUD_lat
            // 
            this.numUD_lat.DecimalPlaces = 3;
            this.numUD_lat.Location = new System.Drawing.Point(101, 70);
            this.numUD_lat.Name = "numUD_lat";
            this.numUD_lat.Size = new System.Drawing.Size(150, 27);
            this.numUD_lat.TabIndex = 7;
            // 
            // numUD_lon
            // 
            this.numUD_lon.DecimalPlaces = 3;
            this.numUD_lon.Location = new System.Drawing.Point(101, 122);
            this.numUD_lon.Name = "numUD_lon";
            this.numUD_lon.Size = new System.Drawing.Size(150, 27);
            this.numUD_lon.TabIndex = 8;
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUD_lon);
            this.Controls.Add(this.numUD_lat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_name);
            this.Name = "frmAdd";
            this.Text = "frmAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numUD_lat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_lon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUD_lat;
        private System.Windows.Forms.NumericUpDown numUD_lon;
    }
}