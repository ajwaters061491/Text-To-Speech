namespace TextToSpeech
{
    partial class Form1
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
            this.TextBoxEntry = new System.Windows.Forms.RichTextBox();
            this.lblTextToSpeech = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxEntry
            // 
            this.TextBoxEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEntry.Location = new System.Drawing.Point(12, 59);
            this.TextBoxEntry.MaxLength = 1000;
            this.TextBoxEntry.Name = "TextBoxEntry";
            this.TextBoxEntry.Size = new System.Drawing.Size(615, 397);
            this.TextBoxEntry.TabIndex = 0;
            this.TextBoxEntry.Text = "";
            // 
            // lblTextToSpeech
            // 
            this.lblTextToSpeech.AutoSize = true;
            this.lblTextToSpeech.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextToSpeech.Location = new System.Drawing.Point(212, 9);
            this.lblTextToSpeech.Name = "lblTextToSpeech";
            this.lblTextToSpeech.Size = new System.Drawing.Size(209, 31);
            this.lblTextToSpeech.TabIndex = 1;
            this.lblTextToSpeech.Text = "Text-To-Speech";
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(218, 462);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(203, 37);
            this.btnRead.TabIndex = 2;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 511);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lblTextToSpeech);
            this.Controls.Add(this.TextBoxEntry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBoxEntry;
        private System.Windows.Forms.Label lblTextToSpeech;
        private System.Windows.Forms.Button btnRead;
    }
}

