
namespace lab13
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Exit_Bottom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Odesa = new System.Windows.Forms.Label();
            this.Lviv = new System.Windows.Forms.Label();
            this.kiev = new System.Windows.Forms.Label();
            this.kievPrice = new System.Windows.Forms.Label();
            this.lvivPrice = new System.Windows.Forms.Label();
            this.odesaPrice = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.common_text = new System.Windows.Forms.Label();
            this.common = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fioInput = new System.Windows.Forms.TextBox();
            this.fio_reverse = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.quantitySym = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exit_Bottom
            // 
            this.Exit_Bottom.AutoSize = true;
            this.Exit_Bottom.BackColor = System.Drawing.SystemColors.Highlight;
            this.Exit_Bottom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Bottom.Font = new System.Drawing.Font("Microsoft JhengHei Light", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Bottom.Location = new System.Drawing.Point(525, 9);
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
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Exit_Bottom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 41);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Варіант 22";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(40, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вказати ціну";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(202, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Вказати час";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Odesa
            // 
            this.Odesa.AutoSize = true;
            this.Odesa.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Odesa.Location = new System.Drawing.Point(36, 223);
            this.Odesa.Name = "Odesa";
            this.Odesa.Size = new System.Drawing.Size(67, 22);
            this.Odesa.TabIndex = 9;
            this.Odesa.Text = "Одеса";
            // 
            // Lviv
            // 
            this.Lviv.AutoSize = true;
            this.Lviv.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lviv.Location = new System.Drawing.Point(36, 182);
            this.Lviv.Name = "Lviv";
            this.Lviv.Size = new System.Drawing.Size(57, 22);
            this.Lviv.TabIndex = 8;
            this.Lviv.Text = "Львів";
            // 
            // kiev
            // 
            this.kiev.AutoSize = true;
            this.kiev.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kiev.Location = new System.Drawing.Point(36, 141);
            this.kiev.Name = "kiev";
            this.kiev.Size = new System.Drawing.Size(47, 22);
            this.kiev.TabIndex = 7;
            this.kiev.Text = "Київ";
            // 
            // kievPrice
            // 
            this.kievPrice.AutoSize = true;
            this.kievPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kievPrice.Location = new System.Drawing.Point(197, 141);
            this.kievPrice.Name = "kievPrice";
            this.kievPrice.Size = new System.Drawing.Size(133, 25);
            this.kievPrice.TabIndex = 10;
            this.kievPrice.Text = "немає даних";
            // 
            // lvivPrice
            // 
            this.lvivPrice.AutoSize = true;
            this.lvivPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvivPrice.Location = new System.Drawing.Point(197, 182);
            this.lvivPrice.Name = "lvivPrice";
            this.lvivPrice.Size = new System.Drawing.Size(133, 25);
            this.lvivPrice.TabIndex = 11;
            this.lvivPrice.Text = "немає даних";
            // 
            // odesaPrice
            // 
            this.odesaPrice.AutoSize = true;
            this.odesaPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.odesaPrice.Location = new System.Drawing.Point(197, 223);
            this.odesaPrice.Name = "odesaPrice";
            this.odesaPrice.Size = new System.Drawing.Size(133, 25);
            this.odesaPrice.TabIndex = 12;
            this.odesaPrice.Text = "немає даних";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(376, 174);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "Розрахувати";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // common_text
            // 
            this.common_text.AutoSize = true;
            this.common_text.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.common_text.Location = new System.Drawing.Point(36, 263);
            this.common_text.Name = "common_text";
            this.common_text.Size = new System.Drawing.Size(65, 22);
            this.common_text.TabIndex = 14;
            this.common_text.Text = "Разом";
            // 
            // common
            // 
            this.common.AutoSize = true;
            this.common.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.common.Location = new System.Drawing.Point(197, 263);
            this.common.Name = "common";
            this.common.Size = new System.Drawing.Size(133, 25);
            this.common.TabIndex = 15;
            this.common.Text = "немає даних";
            // 
            // fio
            // 
            this.fio.AutoSize = true;
            this.fio.Font = new System.Drawing.Font("Mathcad UniMath", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.Location = new System.Drawing.Point(36, 337);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(41, 22);
            this.fio.TabIndex = 16;
            this.fio.Text = "ПІБ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(2, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 10);
            this.panel2.TabIndex = 17;
            // 
            // fioInput
            // 
            this.fioInput.Location = new System.Drawing.Point(83, 338);
            this.fioInput.Name = "fioInput";
            this.fioInput.Size = new System.Drawing.Size(405, 22);
            this.fioInput.TabIndex = 18;
            // 
            // fio_reverse
            // 
            this.fio_reverse.AutoSize = true;
            this.fio_reverse.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio_reverse.Location = new System.Drawing.Point(35, 439);
            this.fio_reverse.Name = "fio_reverse";
            this.fio_reverse.Size = new System.Drawing.Size(0, 25);
            this.fio_reverse.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(40, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 43);
            this.button4.TabIndex = 20;
            this.button4.Text = "Reverse";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(214, 379);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 43);
            this.button5.TabIndex = 21;
            this.button5.Text = "Зберегти";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Orange;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(386, 379);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 43);
            this.button6.TabIndex = 22;
            this.button6.Text = "Налаштування";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // quantitySym
            // 
            this.quantitySym.AutoSize = true;
            this.quantitySym.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantitySym.Location = new System.Drawing.Point(35, 491);
            this.quantitySym.Name = "quantitySym";
            this.quantitySym.Size = new System.Drawing.Size(0, 25);
            this.quantitySym.TabIndex = 23;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 538);
            this.Controls.Add(this.quantitySym);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fio_reverse);
            this.Controls.Add(this.fioInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.common);
            this.Controls.Add(this.common_text);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.odesaPrice);
            this.Controls.Add(this.lvivPrice);
            this.Controls.Add(this.kievPrice);
            this.Controls.Add(this.Odesa);
            this.Controls.Add(this.Lviv);
            this.Controls.Add(this.kiev);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Odesa;
        private System.Windows.Forms.Label Lviv;
        private System.Windows.Forms.Label kiev;
        private System.Windows.Forms.Label kievPrice;
        private System.Windows.Forms.Label lvivPrice;
        private System.Windows.Forms.Label odesaPrice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label common_text;
        private System.Windows.Forms.Label common;
        private System.Windows.Forms.Label fio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox fioInput;
        private System.Windows.Forms.Label fio_reverse;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label quantitySym;
    }
}

