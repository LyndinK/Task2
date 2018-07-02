namespace APITryout
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
            this.ADD_button = new System.Windows.Forms.Button();
            this.querybox = new System.Windows.Forms.TextBox();
            this.inserted = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GO_button = new System.Windows.Forms.Button();
            this.RouteInfo = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MapBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ADD_button
            // 
            this.ADD_button.Location = new System.Drawing.Point(13, 56);
            this.ADD_button.Name = "ADD_button";
            this.ADD_button.Size = new System.Drawing.Size(202, 43);
            this.ADD_button.TabIndex = 2;
            this.ADD_button.Text = "Добавить";
            this.ADD_button.UseVisualStyleBackColor = true;
            this.ADD_button.Click += new System.EventHandler(this.ADD_button_ClickAsync);
            // 
            // querybox
            // 
            this.querybox.Location = new System.Drawing.Point(13, 30);
            this.querybox.Name = "querybox";
            this.querybox.Size = new System.Drawing.Size(202, 20);
            this.querybox.TabIndex = 3;
            // 
            // inserted
            // 
            this.inserted.Location = new System.Drawing.Point(12, 314);
            this.inserted.Name = "inserted";
            this.inserted.ReadOnly = true;
            this.inserted.Size = new System.Drawing.Size(203, 216);
            this.inserted.TabIndex = 4;
            this.inserted.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите запрос:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введённые точки:";
            // 
            // GO_button
            // 
            this.GO_button.Location = new System.Drawing.Point(13, 106);
            this.GO_button.Name = "GO_button";
            this.GO_button.Size = new System.Drawing.Size(202, 43);
            this.GO_button.TabIndex = 7;
            this.GO_button.Text = "Поехали";
            this.GO_button.UseVisualStyleBackColor = true;
            this.GO_button.Click += new System.EventHandler(this.GO_button_Click);
            // 
            // RouteInfo
            // 
            this.RouteInfo.Location = new System.Drawing.Point(13, 178);
            this.RouteInfo.Name = "RouteInfo";
            this.RouteInfo.ReadOnly = true;
            this.RouteInfo.Size = new System.Drawing.Size(202, 108);
            this.RouteInfo.TabIndex = 8;
            this.RouteInfo.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Спецификация маршрута:";
            // 
            // MapBox
            // 
            this.MapBox.Location = new System.Drawing.Point(222, 30);
            this.MapBox.Name = "MapBox";
            this.MapBox.Size = new System.Drawing.Size(500, 500);
            this.MapBox.TabIndex = 10;
            this.MapBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 545);
            this.Controls.Add(this.MapBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RouteInfo);
            this.Controls.Add(this.GO_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inserted);
            this.Controls.Add(this.querybox);
            this.Controls.Add(this.ADD_button);
            this.Name = "Form1";
            this.Text = "Bing API Навигатор";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.MapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ADD_button;
        private System.Windows.Forms.TextBox querybox;
        private System.Windows.Forms.RichTextBox inserted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GO_button;
        private System.Windows.Forms.RichTextBox RouteInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox MapBox;
    }
}

