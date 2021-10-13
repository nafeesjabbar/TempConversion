
namespace TempConversion
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
            this.lbl_farhenheight = new System.Windows.Forms.Label();
            this.lbl_celsius = new System.Windows.Forms.Label();
            this.lbl_kelvin = new System.Windows.Forms.Label();
            this.txt_farhenheight = new System.Windows.Forms.TextBox();
            this.txt_celsius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_farhenheight = new System.Windows.Forms.Button();
            this.btn_celsius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_farhenheight
            // 
            this.lbl_farhenheight.AutoSize = true;
            this.lbl_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_farhenheight.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_farhenheight.Location = new System.Drawing.Point(20, 124);
            this.lbl_farhenheight.Name = "lbl_farhenheight";
            this.lbl_farhenheight.Size = new System.Drawing.Size(192, 32);
            this.lbl_farhenheight.TabIndex = 0;
            this.lbl_farhenheight.Text = "Farhenheight:";
            // 
            // lbl_celsius
            // 
            this.lbl_celsius.AutoSize = true;
            this.lbl_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_celsius.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_celsius.Location = new System.Drawing.Point(69, 197);
            this.lbl_celsius.Name = "lbl_celsius";
            this.lbl_celsius.Size = new System.Drawing.Size(117, 32);
            this.lbl_celsius.TabIndex = 1;
            this.lbl_celsius.Text = "Celsius:";
            // 
            // lbl_kelvin
            // 
            this.lbl_kelvin.AutoSize = true;
            this.lbl_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kelvin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_kelvin.Location = new System.Drawing.Point(80, 270);
            this.lbl_kelvin.Name = "lbl_kelvin";
            this.lbl_kelvin.Size = new System.Drawing.Size(102, 32);
            this.lbl_kelvin.TabIndex = 2;
            this.lbl_kelvin.Text = "Kelvin:";
            // 
            // txt_farhenheight
            // 
            this.txt_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_farhenheight.Location = new System.Drawing.Point(214, 124);
            this.txt_farhenheight.Name = "txt_farhenheight";
            this.txt_farhenheight.Size = new System.Drawing.Size(173, 39);
            this.txt_farhenheight.TabIndex = 3;
            this.txt_farhenheight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_farhenheight_KeyDown);
            // 
            // txt_celsius
            // 
            this.txt_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celsius.Location = new System.Drawing.Point(214, 197);
            this.txt_celsius.Name = "txt_celsius";
            this.txt_celsius.Size = new System.Drawing.Size(173, 39);
            this.txt_celsius.TabIndex = 4;
            this.txt_celsius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_celsius_KeyDown);
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(214, 270);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(173, 39);
            this.txt_kelvin.TabIndex = 5;
            this.txt_kelvin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kelvin_KeyDown);
            // 
            // btn_farhenheight
            // 
            this.btn_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_farhenheight.Location = new System.Drawing.Point(465, 115);
            this.btn_farhenheight.Name = "btn_farhenheight";
            this.btn_farhenheight.Size = new System.Drawing.Size(81, 41);
            this.btn_farhenheight.TabIndex = 6;
            this.btn_farhenheight.Text = "Convert";
            this.btn_farhenheight.UseVisualStyleBackColor = true;
            this.btn_farhenheight.Click += new System.EventHandler(this.btn_farhenheight_Click);
            // 
            // btn_celsius
            // 
            this.btn_celsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_celsius.Location = new System.Drawing.Point(465, 187);
            this.btn_celsius.Name = "btn_celsius";
            this.btn_celsius.Size = new System.Drawing.Size(81, 41);
            this.btn_celsius.TabIndex = 7;
            this.btn_celsius.Text = "Convert";
            this.btn_celsius.UseVisualStyleBackColor = true;
            this.btn_celsius.Click += new System.EventHandler(this.btn_celsius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kelvin.Location = new System.Drawing.Point(465, 260);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(81, 41);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "Convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 501);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celsius);
            this.Controls.Add(this.btn_farhenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celsius);
            this.Controls.Add(this.txt_farhenheight);
            this.Controls.Add(this.lbl_kelvin);
            this.Controls.Add(this.lbl_celsius);
            this.Controls.Add(this.lbl_farhenheight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_farhenheight;
        private System.Windows.Forms.Label lbl_celsius;
        private System.Windows.Forms.Label lbl_kelvin;
        private System.Windows.Forms.TextBox txt_farhenheight;
        private System.Windows.Forms.TextBox txt_celsius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_farhenheight;
        private System.Windows.Forms.Button btn_celsius;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

