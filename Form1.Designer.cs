﻿namespace conveyorSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serviceProbability = new System.Windows.Forms.Label();
            this.falureProbability = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modelingTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.queueSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countOfHeandlers = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // serviceProbability
            // 
            this.serviceProbability.AutoSize = true;
            this.serviceProbability.Location = new System.Drawing.Point(9, 112);
            this.serviceProbability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serviceProbability.Name = "serviceProbability";
            this.serviceProbability.Size = new System.Drawing.Size(148, 13);
            this.serviceProbability.TabIndex = 0;
            this.serviceProbability.Text = "Вероятность обслуживания";
            // 
            // falureProbability
            // 
            this.falureProbability.AutoSize = true;
            this.falureProbability.Location = new System.Drawing.Point(9, 144);
            this.falureProbability.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.falureProbability.Name = "falureProbability";
            this.falureProbability.Size = new System.Drawing.Size(110, 13);
            this.falureProbability.TabIndex = 1;
            this.falureProbability.Text = "Вероятность отказа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Запуск моделирования";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelingTime
            // 
            this.modelingTime.Location = new System.Drawing.Point(810, 308);
            this.modelingTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelingTime.Name = "modelingTime";
            this.modelingTime.Size = new System.Drawing.Size(76, 20);
            this.modelingTime.TabIndex = 3;
            this.modelingTime.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(634, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время моделирвания в минутах";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(734, 91);
            this.label4.TabIndex = 5;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер буфера перед каждым обработчиком";
            // 
            // queueSize
            // 
            this.queueSize.Location = new System.Drawing.Point(810, 264);
            this.queueSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.queueSize.Name = "queueSize";
            this.queueSize.Size = new System.Drawing.Size(76, 20);
            this.queueSize.TabIndex = 6;
            this.queueSize.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(659, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество обработчиков";
            // 
            // countOfHeandlers
            // 
            this.countOfHeandlers.Location = new System.Drawing.Point(810, 229);
            this.countOfHeandlers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.countOfHeandlers.Name = "countOfHeandlers";
            this.countOfHeandlers.Size = new System.Drawing.Size(76, 20);
            this.countOfHeandlers.TabIndex = 8;
            this.countOfHeandlers.Text = "5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(9, 174);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(545, 156);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "номер обработчика";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ср. время обслуживания";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ср. время простоя";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ср. время ожидания в очереди";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(810, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0,2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(684, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "точность от 0 до 1";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 531);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countOfHeandlers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queueSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelingTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.falureProbability);
            this.Controls.Add(this.serviceProbability);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serviceProbability;
        private System.Windows.Forms.Label falureProbability;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox modelingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox queueSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countOfHeandlers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
    }
}

