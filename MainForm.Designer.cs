namespace RegistryProgram
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.regBtn = new System.Windows.Forms.Button();
            this.showTempBtn = new System.Windows.Forms.Button();
            this.showSerialBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.demoLb = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passOkBtn = new System.Windows.Forms.Button();
            this.passTb = new System.Windows.Forms.TextBox();
            this.passLb = new System.Windows.Forms.Label();
            this.showInfoBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // regBtn
            // 
            this.regBtn.Enabled = false;
            this.regBtn.Location = new System.Drawing.Point(12, 59);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(306, 34);
            this.regBtn.TabIndex = 0;
            this.regBtn.Text = "Зарегистрировать";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // showTempBtn
            // 
            this.showTempBtn.Enabled = false;
            this.showTempBtn.Location = new System.Drawing.Point(12, 179);
            this.showTempBtn.Name = "showTempBtn";
            this.showTempBtn.Size = new System.Drawing.Size(306, 34);
            this.showTempBtn.TabIndex = 1;
            this.showTempBtn.Text = "Путь папки временных файлов";
            this.showTempBtn.UseVisualStyleBackColor = true;
            this.showTempBtn.Click += new System.EventHandler(this.showTempBtn_Click);
            // 
            // showSerialBtn
            // 
            this.showSerialBtn.Enabled = false;
            this.showSerialBtn.Location = new System.Drawing.Point(12, 139);
            this.showSerialBtn.Name = "showSerialBtn";
            this.showSerialBtn.Size = new System.Drawing.Size(306, 34);
            this.showSerialBtn.TabIndex = 2;
            this.showSerialBtn.Text = "Серийный номер системного раздела";
            this.showSerialBtn.UseVisualStyleBackColor = true;
            this.showSerialBtn.Click += new System.EventHandler(this.getSerialBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(229, 219);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 26);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // demoLb
            // 
            this.demoLb.AutoSize = true;
            this.demoLb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.demoLb.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.demoLb.ForeColor = System.Drawing.Color.Maroon;
            this.demoLb.Location = new System.Drawing.Point(12, 219);
            this.demoLb.Name = "demoLb";
            this.demoLb.Size = new System.Drawing.Size(56, 23);
            this.demoLb.TabIndex = 5;
            this.demoLb.Text = "ДЕМО";
            this.demoLb.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.demoLb.Visible = false;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.passOkBtn);
            this.loginPanel.Controls.Add(this.passTb);
            this.loginPanel.Controls.Add(this.passLb);
            this.loginPanel.Location = new System.Drawing.Point(90, 96);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(167, 86);
            this.loginPanel.TabIndex = 7;
            // 
            // passOkBtn
            // 
            this.passOkBtn.Location = new System.Drawing.Point(45, 56);
            this.passOkBtn.Name = "passOkBtn";
            this.passOkBtn.Size = new System.Drawing.Size(75, 23);
            this.passOkBtn.TabIndex = 2;
            this.passOkBtn.Text = "ОК";
            this.passOkBtn.UseVisualStyleBackColor = true;
            this.passOkBtn.Click += new System.EventHandler(this.passCheckBtn_Click);
            // 
            // passTb
            // 
            this.passTb.Location = new System.Drawing.Point(6, 29);
            this.passTb.Name = "passTb";
            this.passTb.Size = new System.Drawing.Size(154, 20);
            this.passTb.TabIndex = 1;
            // 
            // passLb
            // 
            this.passLb.AutoSize = true;
            this.passLb.Location = new System.Drawing.Point(7, 13);
            this.passLb.Name = "passLb";
            this.passLb.Size = new System.Drawing.Size(157, 13);
            this.passLb.TabIndex = 0;
            this.passLb.Text = "Введите пароль компьютера:";
            // 
            // showInfoBtn
            // 
            this.showInfoBtn.Enabled = false;
            this.showInfoBtn.Location = new System.Drawing.Point(12, 99);
            this.showInfoBtn.Name = "showInfoBtn";
            this.showInfoBtn.Size = new System.Drawing.Size(306, 34);
            this.showInfoBtn.TabIndex = 8;
            this.showInfoBtn.Text = "Информация о компьютере";
            this.showInfoBtn.UseVisualStyleBackColor = true;
            this.showInfoBtn.Click += new System.EventHandler(this.getInfoBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Привязка программы к компьютеру";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.showInfoBtn);
            this.Controls.Add(this.demoLb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.showSerialBtn);
            this.Controls.Add(this.showTempBtn);
            this.Controls.Add(this.regBtn);
            this.Name = "MainForm";
            this.Text = "Чернопрудов А.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button regBtn;
        public System.Windows.Forms.Button showTempBtn;
        public System.Windows.Forms.Button showSerialBtn;
        public System.Windows.Forms.Button exitBtn;
        public System.Windows.Forms.Label demoLb;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button passOkBtn;
        private System.Windows.Forms.TextBox passTb;
        private System.Windows.Forms.Label passLb;
        public System.Windows.Forms.Button showInfoBtn;
        private System.Windows.Forms.Label label1;
    }
}

