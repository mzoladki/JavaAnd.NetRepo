namespace JTTT
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CityName = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.MessageBoxWindow = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Miasto";
            // 
            // CityName
            // 
            this.CityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CityName.Location = new System.Drawing.Point(68, 45);
            this.CityName.Name = "CityName";
            this.CityName.ReadOnly = true;
            this.CityName.Size = new System.Drawing.Size(240, 23);
            this.CityName.TabIndex = 2;
            this.CityName.TextChanged += new System.EventHandler(this.CityName_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(247, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(61, 51);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // MessageBoxWindow
            // 
            this.MessageBoxWindow.Location = new System.Drawing.Point(16, 131);
            this.MessageBoxWindow.Multiline = true;
            this.MessageBoxWindow.Name = "MessageBoxWindow";
            this.MessageBoxWindow.ReadOnly = true;
            this.MessageBoxWindow.Size = new System.Drawing.Size(225, 136);
            this.MessageBoxWindow.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 310);
            this.Controls.Add(this.MessageBoxWindow);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.CityName);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox MessageBoxWindow;
    }
}