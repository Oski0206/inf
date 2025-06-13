namespace WindowsFormsApp1
{
    partial class Form
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textTextBox = new System.Windows.Forms.TextBox();
            this.codeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.codedLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wartosc klucza";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(82, 45);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(50, 20);
            this.keyTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj tekst";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTextBox
            // 
            this.textTextBox.Location = new System.Drawing.Point(15, 94);
            this.textTextBox.Multiline = true;
            this.textTextBox.Name = "textTextBox";
            this.textTextBox.Size = new System.Drawing.Size(182, 171);
            this.textTextBox.TabIndex = 3;
            // 
            // codeButton
            // 
            this.codeButton.BackColor = System.Drawing.Color.LightBlue;
            this.codeButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.codeButton.FlatAppearance.BorderSize = 0;
            this.codeButton.Location = new System.Drawing.Point(203, 94);
            this.codeButton.Name = "codeButton";
            this.codeButton.Size = new System.Drawing.Size(75, 23);
            this.codeButton.TabIndex = 4;
            this.codeButton.Text = "Zakoduj";
            this.codeButton.UseVisualStyleBackColor = false;
            this.codeButton.Click += new System.EventHandler(this.codeButton_Click);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.label3.Location = new System.Drawing.Point(293, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tekst zaszyfrowany";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codedLabel
            // 
            this.codedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codedLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.codedLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.codedLabel.Location = new System.Drawing.Point(296, 60);
            this.codedLabel.Name = "codedLabel";
            this.codedLabel.Size = new System.Drawing.Size(235, 185);
            this.codedLabel.TabIndex = 6;
            this.codedLabel.Text = "(to ma miec zaokraglone rogi jak cos)";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.Location = new System.Drawing.Point(296, 248);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(235, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Zapisz do pliku";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(599, 298);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.codedLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeButton);
            this.Controls.Add(this.textTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Szyfrowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textTextBox;
        private System.Windows.Forms.Button codeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label codedLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

