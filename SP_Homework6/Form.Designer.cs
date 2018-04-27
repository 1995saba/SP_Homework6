namespace SP_Homework6
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.workingListView = new System.Windows.Forms.ListView();
            this.waitingListView = new System.Windows.Forms.ListView();
            this.createdListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Работающие потоки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(494, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Созданные потоки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ожидающие потоки";
            // 
            // workingListView
            // 
            this.workingListView.Location = new System.Drawing.Point(13, 65);
            this.workingListView.Name = "workingListView";
            this.workingListView.Size = new System.Drawing.Size(190, 86);
            this.workingListView.TabIndex = 3;
            this.workingListView.UseCompatibleStateImageBehavior = false;
            this.workingListView.View = System.Windows.Forms.View.Details;
            this.workingListView.DoubleClick += new System.EventHandler(this.WorkingListView_DoubleClick);
            // 
            // waitingListView
            // 
            this.waitingListView.Location = new System.Drawing.Point(230, 65);
            this.waitingListView.Name = "waitingListView";
            this.waitingListView.Size = new System.Drawing.Size(190, 86);
            this.waitingListView.TabIndex = 4;
            this.waitingListView.UseCompatibleStateImageBehavior = false;
            this.waitingListView.View = System.Windows.Forms.View.Details;
            this.waitingListView.DoubleClick += new System.EventHandler(this.WaitingListView_DoubleClick);
            // 
            // createdListView
            // 
            this.createdListView.Location = new System.Drawing.Point(446, 65);
            this.createdListView.Name = "createdListView";
            this.createdListView.Size = new System.Drawing.Size(190, 86);
            this.createdListView.TabIndex = 5;
            this.createdListView.UseCompatibleStateImageBehavior = false;
            this.createdListView.View = System.Windows.Forms.View.Details;
            this.createdListView.DoubleClick += new System.EventHandler(this.CreatedListView_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество мест в семафоре";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 217);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(252, 200);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(124, 37);
            this.button.TabIndex = 8;
            this.button.Text = "Создать поток";
            this.button.UseCompatibleTextRendering = true;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 289);
            this.Controls.Add(this.button);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createdListView);
            this.Controls.Add(this.waitingListView);
            this.Controls.Add(this.workingListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView workingListView;
        private System.Windows.Forms.ListView waitingListView;
        private System.Windows.Forms.ListView createdListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button;
    }
}

