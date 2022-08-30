namespace Practica_2kyrs
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2_Resume = new System.Windows.Forms.Button();
            this.button_Pause = new System.Windows.Forms.Button();
            this.button_Info = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2_Resume
            // 
            this.button2_Resume.Location = new System.Drawing.Point(210, 26);
            this.button2_Resume.Name = "button2_Resume";
            this.button2_Resume.Size = new System.Drawing.Size(75, 23);
            this.button2_Resume.TabIndex = 1;
            this.button2_Resume.Text = "Restart";
            this.button2_Resume.UseVisualStyleBackColor = true;
            this.button2_Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // button_Pause
            // 
            this.button_Pause.Location = new System.Drawing.Point(125, 26);
            this.button_Pause.Name = "button_Pause";
            this.button_Pause.Size = new System.Drawing.Size(75, 23);
            this.button_Pause.TabIndex = 2;
            this.button_Pause.Text = "Pause";
            this.button_Pause.UseVisualStyleBackColor = true;
            this.button_Pause.Click += new System.EventHandler(this.button_Pause_Click);
            // 
            // button_Info
            // 
            this.button_Info.Location = new System.Drawing.Point(291, 26);
            this.button_Info.Name = "button_Info";
            this.button_Info.Size = new System.Drawing.Size(75, 23);
            this.button_Info.TabIndex = 3;
            this.button_Info.Text = "Info";
            this.button_Info.UseVisualStyleBackColor = true;
            this.button_Info.Click += new System.EventHandler(this.button_Info_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 361);
            this.Controls.Add(this.button_Info);
            this.Controls.Add(this.button_Pause);
            this.Controls.Add(this.button2_Resume);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(810, 400);
            this.MinimumSize = new System.Drawing.Size(810, 400);
            this.Name = "Form1";
            this.Text = "Дружная компания";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2_Resume;
        private System.Windows.Forms.Button button_Pause;
        private System.Windows.Forms.Button button_Info;
    }
}

