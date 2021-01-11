
namespace WinForms
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
            this.CreateButtonTrain = new System.Windows.Forms.Button();
            this.OutPutButton = new System.Windows.Forms.Button();
            this.TextBoxMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CreateButtonTrain
            // 
            this.CreateButtonTrain.Location = new System.Drawing.Point(665, 31);
            this.CreateButtonTrain.Name = "CreateButtonTrain";
            this.CreateButtonTrain.Size = new System.Drawing.Size(123, 23);
            this.CreateButtonTrain.TabIndex = 0;
            this.CreateButtonTrain.Text = "Создать TRAIN";
            this.CreateButtonTrain.UseVisualStyleBackColor = true;
            this.CreateButtonTrain.Click += new System.EventHandler(this.CreateButtonTrain_Click);
            // 
            // OutPutButton
            // 
            this.OutPutButton.Location = new System.Drawing.Point(665, 79);
            this.OutPutButton.Name = "OutPutButton";
            this.OutPutButton.Size = new System.Drawing.Size(123, 23);
            this.OutPutButton.TabIndex = 1;
            this.OutPutButton.Text = "Вывод";
            this.OutPutButton.UseVisualStyleBackColor = true;
            this.OutPutButton.Click += new System.EventHandler(this.OutPutButton_Click);
            // 
            // TextBoxMain
            // 
            this.TextBoxMain.Location = new System.Drawing.Point(12, 12);
            this.TextBoxMain.Multiline = true;
            this.TextBoxMain.Name = "TextBoxMain";
            this.TextBoxMain.Size = new System.Drawing.Size(517, 90);
            this.TextBoxMain.TabIndex = 2;
            this.TextBoxMain.TextChanged += new System.EventHandler(this.TextBoxMain_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBoxMain);
            this.Controls.Add(this.OutPutButton);
            this.Controls.Add(this.CreateButtonTrain);
            this.Name = "Form1";
            this.Text = "TrainCollectin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateButtonTrain;
        private System.Windows.Forms.Button OutPutButton;
        private System.Windows.Forms.TextBox TextBoxMain;
    }
}

