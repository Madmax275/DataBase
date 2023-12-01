namespace WindowsFormsApp2
{
    partial class Mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.Mainpanel1 = new System.Windows.Forms.Panel();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.button_enter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tx2PassField = new System.Windows.Forms.TextBox();
            this.tx1Login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Mainpanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel1
            // 
            this.Mainpanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mainpanel1.BackgroundImage")));
            this.Mainpanel1.Controls.Add(this.buttonRegistr);
            this.Mainpanel1.Controls.Add(this.button_enter);
            this.Mainpanel1.Controls.Add(this.label4);
            this.Mainpanel1.Controls.Add(this.label3);
            this.Mainpanel1.Controls.Add(this.tx2PassField);
            this.Mainpanel1.Controls.Add(this.tx1Login);
            this.Mainpanel1.Controls.Add(this.panel2);
            this.Mainpanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel1.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel1.Name = "Mainpanel1";
            this.Mainpanel1.Size = new System.Drawing.Size(351, 354);
            this.Mainpanel1.TabIndex = 0;
            this.Mainpanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainpanel1_MouseDown);
            this.Mainpanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mainpanel1_MouseMove);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegistr.AutoSize = true;
            this.buttonRegistr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRegistr.ForeColor = System.Drawing.SystemColors.Window;
            this.buttonRegistr.Location = new System.Drawing.Point(252, 328);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(99, 23);
            this.buttonRegistr.TabIndex = 7;
            this.buttonRegistr.Text = "Нет аккаунта?";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // button_enter
            // 
            this.button_enter.BackColor = System.Drawing.Color.Green;
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_enter.Location = new System.Drawing.Point(148, 286);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 32);
            this.button_enter.TabIndex = 6;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = false;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(71, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(85, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин:";
            // 
            // tx2PassField
            // 
            this.tx2PassField.Location = new System.Drawing.Point(158, 198);
            this.tx2PassField.Name = "tx2PassField";
            this.tx2PassField.PasswordChar = '#';
            this.tx2PassField.Size = new System.Drawing.Size(100, 20);
            this.tx2PassField.TabIndex = 3;
            this.tx2PassField.UseSystemPasswordChar = true;
            // 
            // tx1Login
            // 
            this.tx1Login.Location = new System.Drawing.Point(158, 136);
            this.tx1Login.Name = "tx1Login";
            this.tx1Login.PasswordChar = '#';
            this.tx1Login.Size = new System.Drawing.Size(100, 20);
            this.tx1Login.TabIndex = 2;
            this.tx1Login.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(39)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 70);
            this.panel2.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(331, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(20, 20);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 354);
            this.Controls.Add(this.Mainpanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Mainpanel1.ResumeLayout(false);
            this.Mainpanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx2PassField;
        private System.Windows.Forms.TextBox tx1Login;
    }
}

