
namespace pract14_3_5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addOrExportButton = new System.Windows.Forms.Button();
            this.numbersListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numberNTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showPeopleButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listOfPeopleListBox = new System.Windows.Forms.ListBox();
            this.pathToFileTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sortAndShowTextBox = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sortedPeopleTextBox = new System.Windows.Forms.ListBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addOrExportButton);
            this.groupBox1.Controls.Add(this.numbersListBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numberNTextBox);
            this.groupBox1.Location = new System.Drawing.Point(45, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "zadanie3";
            // 
            // addOrExportButton
            // 
            this.addOrExportButton.Location = new System.Drawing.Point(21, 202);
            this.addOrExportButton.Name = "addOrExportButton";
            this.addOrExportButton.Size = new System.Drawing.Size(123, 23);
            this.addOrExportButton.TabIndex = 3;
            this.addOrExportButton.Text = "Добавить значения";
            this.addOrExportButton.UseVisualStyleBackColor = true;
            this.addOrExportButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // numbersListBox
            // 
            this.numbersListBox.FormattingEnabled = true;
            this.numbersListBox.Location = new System.Drawing.Point(21, 76);
            this.numbersListBox.Name = "numbersListBox";
            this.numbersListBox.Size = new System.Drawing.Size(120, 108);
            this.numbersListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите число n(>1)";
            // 
            // numberNTextBox
            // 
            this.numberNTextBox.Location = new System.Drawing.Point(21, 36);
            this.numberNTextBox.Name = "numberNTextBox";
            this.numberNTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberNTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showPeopleButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.listOfPeopleListBox);
            this.groupBox2.Controls.Add(this.pathToFileTextBox);
            this.groupBox2.Location = new System.Drawing.Point(448, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "zadanie4";
            // 
            // showPeopleButton
            // 
            this.showPeopleButton.Location = new System.Drawing.Point(30, 196);
            this.showPeopleButton.Name = "showPeopleButton";
            this.showPeopleButton.Size = new System.Drawing.Size(178, 34);
            this.showPeopleButton.TabIndex = 7;
            this.showPeopleButton.Text = "Вывести и отсортировать людей, которым меньше 40 лет";
            this.showPeopleButton.UseVisualStyleBackColor = true;
            this.showPeopleButton.Click += new System.EventHandler(this.showPeopleButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Укажите путь к файлу";
            // 
            // listOfPeopleListBox
            // 
            this.listOfPeopleListBox.FormattingEnabled = true;
            this.listOfPeopleListBox.Location = new System.Drawing.Point(6, 82);
            this.listOfPeopleListBox.Name = "listOfPeopleListBox";
            this.listOfPeopleListBox.Size = new System.Drawing.Size(267, 108);
            this.listOfPeopleListBox.TabIndex = 6;
            // 
            // pathToFileTextBox
            // 
            this.pathToFileTextBox.Location = new System.Drawing.Point(30, 36);
            this.pathToFileTextBox.Name = "pathToFileTextBox";
            this.pathToFileTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathToFileTextBox.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sortAndShowTextBox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.sortedPeopleTextBox);
            this.groupBox3.Controls.Add(this.pathTextBox);
            this.groupBox3.Location = new System.Drawing.Point(258, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 269);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "zadanie5";
            // 
            // sortAndShowTextBox
            // 
            this.sortAndShowTextBox.Location = new System.Drawing.Point(30, 196);
            this.sortAndShowTextBox.Name = "sortAndShowTextBox";
            this.sortAndShowTextBox.Size = new System.Drawing.Size(142, 34);
            this.sortAndShowTextBox.TabIndex = 7;
            this.sortAndShowTextBox.Text = "Вывести и отсортировать людей по возрасту";
            this.sortAndShowTextBox.UseVisualStyleBackColor = true;
            this.sortAndShowTextBox.Click += new System.EventHandler(this.sortAndShowTextBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Укажите путь к файлу";
            // 
            // sortedPeopleTextBox
            // 
            this.sortedPeopleTextBox.FormattingEnabled = true;
            this.sortedPeopleTextBox.Location = new System.Drawing.Point(6, 82);
            this.sortedPeopleTextBox.Name = "sortedPeopleTextBox";
            this.sortedPeopleTextBox.Size = new System.Drawing.Size(267, 108);
            this.sortedPeopleTextBox.TabIndex = 6;
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(30, 36);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(100, 20);
            this.pathTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 569);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox numbersListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberNTextBox;
        public System.Windows.Forms.Button addOrExportButton;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button showPeopleButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listOfPeopleListBox;
        private System.Windows.Forms.TextBox pathToFileTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button sortAndShowTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox sortedPeopleTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
    }
}

