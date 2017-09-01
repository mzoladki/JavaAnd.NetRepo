namespace JTTT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.TagTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddToList = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeSerializeButton = new System.Windows.Forms.Button();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Demot = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.Pogoda = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.Temperature = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CityName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comPage = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.TaskName2 = new System.Windows.Forms.TextBox();
            this.mailPage = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.Demot.SuspendLayout();
            this.Pogoda.SuspendLayout();
            this.comPage.SuspendLayout();
            this.mailPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "URL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tekst";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(47, 68);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(311, 23);
            this.UrlTextBox.TabIndex = 4;
            // 
            // TagTextBox
            // 
            this.TagTextBox.Location = new System.Drawing.Point(47, 102);
            this.TagTextBox.Name = "TagTextBox";
            this.TagTextBox.Size = new System.Drawing.Size(311, 23);
            this.TagTextBox.TabIndex = 5;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SendButton.Location = new System.Drawing.Point(536, 220);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(96, 47);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "Wykonaj!";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jeżeli to:";
            // 
            // AddToList
            // 
            this.AddToList.Location = new System.Drawing.Point(144, 405);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(145, 23);
            this.AddToList.TabIndex = 10;
            this.AddToList.Text = "Dodaj do listy";
            this.AddToList.UseVisualStyleBackColor = true;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Comic Sans MS", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ClearButton.Location = new System.Drawing.Point(638, 220);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(105, 47);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Czyść";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // DeSerializeButton
            // 
            this.DeSerializeButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DeSerializeButton.Location = new System.Drawing.Point(750, 220);
            this.DeSerializeButton.Name = "DeSerializeButton";
            this.DeSerializeButton.Size = new System.Drawing.Size(85, 20);
            this.DeSerializeButton.TabIndex = 14;
            this.DeSerializeButton.Text = "DeSerialize";
            this.DeSerializeButton.UseVisualStyleBackColor = true;
            this.DeSerializeButton.Click += new System.EventHandler(this.DeSerializeButton_Click);
            // 
            // SerializeButton
            // 
            this.SerializeButton.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerializeButton.Location = new System.Drawing.Point(750, 246);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(85, 21);
            this.SerializeButton.TabIndex = 15;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(536, 41);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(299, 154);
            this.listBox.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Demot);
            this.tabControl1.Controls.Add(this.Pogoda);
            this.tabControl1.Location = new System.Drawing.Point(56, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 173);
            this.tabControl1.TabIndex = 17;
            // 
            // Demot
            // 
            this.Demot.Controls.Add(this.label7);
            this.Demot.Controls.Add(this.UrlTextBox);
            this.Demot.Controls.Add(this.label2);
            this.Demot.Controls.Add(this.label4);
            this.Demot.Controls.Add(this.TagTextBox);
            this.Demot.Location = new System.Drawing.Point(4, 24);
            this.Demot.Name = "Demot";
            this.Demot.Padding = new System.Windows.Forms.Padding(3);
            this.Demot.Size = new System.Drawing.Size(364, 145);
            this.Demot.TabIndex = 0;
            this.Demot.Text = "Demot";
            this.Demot.UseVisualStyleBackColor = true;
            this.Demot.Click += new System.EventHandler(this.Demot_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(42, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Pobierz demota";
            // 
            // Pogoda
            // 
            this.Pogoda.Controls.Add(this.label10);
            this.Pogoda.Controls.Add(this.Temperature);
            this.Pogoda.Controls.Add(this.label9);
            this.Pogoda.Controls.Add(this.CityName);
            this.Pogoda.Controls.Add(this.label8);
            this.Pogoda.Location = new System.Drawing.Point(4, 24);
            this.Pogoda.Name = "Pogoda";
            this.Pogoda.Padding = new System.Windows.Forms.Padding(3);
            this.Pogoda.Size = new System.Drawing.Size(364, 145);
            this.Pogoda.TabIndex = 1;
            this.Pogoda.Text = "Pogoda";
            this.Pogoda.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(46, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sprawdz pogode";
            // 
            // Temperature
            // 
            this.Temperature.Location = new System.Drawing.Point(84, 103);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(140, 23);
            this.Temperature.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Temperatura";
            // 
            // CityName
            // 
            this.CityName.Location = new System.Drawing.Point(84, 74);
            this.CityName.Name = "CityName";
            this.CityName.Size = new System.Drawing.Size(246, 23);
            this.CityName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Miasto";
            // 
            // comPage
            // 
            this.comPage.Controls.Add(this.label5);
            this.comPage.Controls.Add(this.TaskName2);
            this.comPage.Location = new System.Drawing.Point(4, 24);
            this.comPage.Name = "comPage";
            this.comPage.Padding = new System.Windows.Forms.Padding(3);
            this.comPage.Size = new System.Drawing.Size(364, 151);
            this.comPage.TabIndex = 1;
            this.comPage.Text = "Komunikat";
            this.comPage.UseVisualStyleBackColor = true;
            this.comPage.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nazwa tasku";
            // 
            // TaskName2
            // 
            this.TaskName2.Location = new System.Drawing.Point(84, 34);
            this.TaskName2.Name = "TaskName2";
            this.TaskName2.Size = new System.Drawing.Size(252, 23);
            this.TaskName2.TabIndex = 12;
            this.TaskName2.TextChanged += new System.EventHandler(this.TaskName2_TextChanged);
            // 
            // mailPage
            // 
            this.mailPage.Controls.Add(this.label12);
            this.mailPage.Controls.Add(this.EmailTextBox);
            this.mailPage.Controls.Add(this.TaskName);
            this.mailPage.Controls.Add(this.label3);
            this.mailPage.Controls.Add(this.label6);
            this.mailPage.Location = new System.Drawing.Point(4, 24);
            this.mailPage.Name = "mailPage";
            this.mailPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailPage.Size = new System.Drawing.Size(364, 151);
            this.mailPage.TabIndex = 0;
            this.mailPage.Text = "Mail";
            this.mailPage.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(42, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 28);
            this.label12.TabIndex = 14;
            this.label12.Text = "Wyślij maila";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(89, 70);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(252, 23);
            this.EmailTextBox.TabIndex = 6;
            // 
            // TaskName
            // 
            this.TaskName.Location = new System.Drawing.Point(89, 112);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(252, 23);
            this.TaskName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nazwa tasku";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.mailPage);
            this.tabControl2.Controls.Add(this.comPage);
            this.tabControl2.Location = new System.Drawing.Point(56, 220);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(372, 179);
            this.tabControl2.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 444);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.SerializeButton);
            this.Controls.Add(this.DeSerializeButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendButton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Demot.ResumeLayout(false);
            this.Demot.PerformLayout();
            this.Pogoda.ResumeLayout(false);
            this.Pogoda.PerformLayout();
            this.comPage.ResumeLayout(false);
            this.comPage.PerformLayout();
            this.mailPage.ResumeLayout(false);
            this.mailPage.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.TextBox TagTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeSerializeButton;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Demot;
        private System.Windows.Forms.TabPage Pogoda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox CityName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Temperature;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage comPage;
        private System.Windows.Forms.TabPage mailPage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TaskName2;
    }
}

