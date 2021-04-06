
namespace lab13
{
    partial class Time
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
            this.Exit_Bottom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Text_PriceCommunication = new System.Windows.Forms.Label();
            this.kiev = new System.Windows.Forms.Label();
            this.Lviv = new System.Windows.Forms.Label();
            this.Odesa = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_Bottom
            // 
            this.Exit_Bottom.AutoSize = true;
            this.Exit_Bottom.BackColor = System.Drawing.SystemColors.Highlight;
            this.Exit_Bottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Bottom.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Bottom.Location = new System.Drawing.Point(348, 9);
            this.Exit_Bottom.Name = "Exit_Bottom";
            this.Exit_Bottom.Size = new System.Drawing.Size(23, 22);
            this.Exit_Bottom.TabIndex = 0;
            this.Exit_Bottom.Text = "X";
            this.Exit_Bottom.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Exit_Bottom.Click += new System.EventHandler(this.Exit_Bottom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.Exit_Bottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Text_PriceCommunication
            // 
            this.Text_PriceCommunication.AutoSize = true;
            this.Text_PriceCommunication.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_PriceCommunication.Location = new System.Drawing.Point(12, 44);
            this.Text_PriceCommunication.Name = "Text_PriceCommunication";
            this.Text_PriceCommunication.Size = new System.Drawing.Size(132, 22);
            this.Text_PriceCommunication.TabIndex = 2;
            this.Text_PriceCommunication.Text = "Час розмови";
            // 
            // kiev
            // 
            this.kiev.AutoSize = true;
            this.kiev.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kiev.Location = new System.Drawing.Point(12, 93);
            this.kiev.Name = "kiev";
            this.kiev.Size = new System.Drawing.Size(47, 22);
            this.kiev.TabIndex = 3;
            this.kiev.Text = "Київ";
            // 
            // Lviv
            // 
            this.Lviv.AutoSize = true;
            this.Lviv.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lviv.Location = new System.Drawing.Point(12, 134);
            this.Lviv.Name = "Lviv";
            this.Lviv.Size = new System.Drawing.Size(57, 22);
            this.Lviv.TabIndex = 5;
            this.Lviv.Text = "Львів";
            // 
            // Odesa
            // 
            this.Odesa.AutoSize = true;
            this.Odesa.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Odesa.Location = new System.Drawing.Point(12, 175);
            this.Odesa.Name = "Odesa";
            this.Odesa.Size = new System.Drawing.Size(67, 22);
            this.Odesa.TabIndex = 6;
            this.Odesa.Text = "Одеса";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 135);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(254, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(383, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Odesa);
            this.Controls.Add(this.Lviv);
            this.Controls.Add(this.kiev);
            this.Controls.Add(this.Text_PriceCommunication);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Time";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exit_Bottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Text_PriceCommunication;
        private System.Windows.Forms.Label kiev;
        private System.Windows.Forms.Label Lviv;
        private System.Windows.Forms.Label Odesa;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}
