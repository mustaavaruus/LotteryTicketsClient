
namespace LotteryTicketsClient
{
    partial class FormEdit
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
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxCirculation = new System.Windows.Forms.TextBox();
            this.textBoxChoosedNumbersCount = new System.Windows.Forms.TextBox();
            this.textBoxChoosedNumbers = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelChoosedNumbersCount = new System.Windows.Forms.Label();
            this.labelCirculation = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelChoosedNumbers = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNumber.Location = new System.Drawing.Point(12, 30);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.PlaceholderText = "Номер билета будет присвоен после сохранения";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(533, 29);
            this.textBoxNumber.TabIndex = 4;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // textBoxCirculation
            // 
            this.textBoxCirculation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCirculation.Location = new System.Drawing.Point(12, 90);
            this.textBoxCirculation.Name = "textBoxCirculation";
            this.textBoxCirculation.Size = new System.Drawing.Size(533, 29);
            this.textBoxCirculation.TabIndex = 5;
            this.textBoxCirculation.TextChanged += new System.EventHandler(this.textBoxCirculation_TextChanged);
            // 
            // textBoxChoosedNumbersCount
            // 
            this.textBoxChoosedNumbersCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChoosedNumbersCount.Location = new System.Drawing.Point(12, 152);
            this.textBoxChoosedNumbersCount.Name = "textBoxChoosedNumbersCount";
            this.textBoxChoosedNumbersCount.PlaceholderText = "Автоматический подсчет";
            this.textBoxChoosedNumbersCount.ReadOnly = true;
            this.textBoxChoosedNumbersCount.Size = new System.Drawing.Size(533, 29);
            this.textBoxChoosedNumbersCount.TabIndex = 6;
            // 
            // textBoxChoosedNumbers
            // 
            this.textBoxChoosedNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChoosedNumbers.Location = new System.Drawing.Point(12, 211);
            this.textBoxChoosedNumbers.Name = "textBoxChoosedNumbers";
            this.textBoxChoosedNumbers.Size = new System.Drawing.Size(533, 29);
            this.textBoxChoosedNumbers.TabIndex = 7;
            this.textBoxChoosedNumbers.TextChanged += new System.EventHandler(this.textBoxChoosedNumbers_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(232, 261);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(147, 41);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.White;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(395, 261);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 41);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelChoosedNumbersCount
            // 
            this.labelChoosedNumbersCount.AutoSize = true;
            this.labelChoosedNumbersCount.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChoosedNumbersCount.Location = new System.Drawing.Point(12, 137);
            this.labelChoosedNumbersCount.Name = "labelChoosedNumbersCount";
            this.labelChoosedNumbersCount.Size = new System.Drawing.Size(217, 12);
            this.labelChoosedNumbersCount.TabIndex = 2;
            this.labelChoosedNumbersCount.Text = "Количество выбранных чисел в билете (от 6 до 17): ";
            // 
            // labelCirculation
            // 
            this.labelCirculation.AutoSize = true;
            this.labelCirculation.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCirculation.Location = new System.Drawing.Point(12, 75);
            this.labelCirculation.Name = "labelCirculation";
            this.labelCirculation.Size = new System.Drawing.Size(156, 12);
            this.labelCirculation.TabIndex = 1;
            this.labelCirculation.Text = "Номер тиража (число от 1 до 65535):";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(12, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 12);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Номер билета: ";
            // 
            // labelChoosedNumbers
            // 
            this.labelChoosedNumbers.AutoSize = true;
            this.labelChoosedNumbers.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChoosedNumbers.Location = new System.Drawing.Point(12, 196);
            this.labelChoosedNumbers.Name = "labelChoosedNumbers";
            this.labelChoosedNumbers.Size = new System.Drawing.Size(110, 12);
            this.labelChoosedNumbers.TabIndex = 3;
            this.labelChoosedNumbers.Text = "Список выбранных чисел:";
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 318);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxChoosedNumbers);
            this.Controls.Add(this.textBoxChoosedNumbersCount);
            this.Controls.Add(this.textBoxCirculation);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.labelChoosedNumbers);
            this.Controls.Add(this.labelChoosedNumbersCount);
            this.Controls.Add(this.labelCirculation);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEdit";
            this.Text = "Редактирование билета";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxCirculation;
        private System.Windows.Forms.TextBox textBoxChoosedNumbersCount;
        private System.Windows.Forms.TextBox textBoxChoosedNumbers;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelChoosedNumbersCount;
        private System.Windows.Forms.Label labelCirculation;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChoosedNumbers;
    }
}