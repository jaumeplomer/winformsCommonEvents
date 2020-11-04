namespace CommonEventsPractice
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.eventLabel = new System.Windows.Forms.Label();
            this.eventNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.eventTestBox = new System.Windows.Forms.TextBox();
            this.eventPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.messagesTextBox.ForeColor = System.Drawing.Color.White;
            this.messagesTextBox.Location = new System.Drawing.Point(402, 8);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messagesTextBox.Size = new System.Drawing.Size(511, 541);
            this.messagesTextBox.TabIndex = 0;
            // 
            // eventLabel
            // 
            this.eventLabel.AutoSize = true;
            this.eventLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.eventLabel.Location = new System.Drawing.Point(22, 36);
            this.eventLabel.Name = "eventLabel";
            this.eventLabel.Size = new System.Drawing.Size(112, 17);
            this.eventLabel.TabIndex = 1;
            this.eventLabel.Text = "Double Click Me!";
            // 
            // eventNumericUpDown
            // 
            this.eventNumericUpDown.Location = new System.Drawing.Point(25, 86);
            this.eventNumericUpDown.Name = "eventNumericUpDown";
            this.eventNumericUpDown.Size = new System.Drawing.Size(173, 22);
            this.eventNumericUpDown.TabIndex = 2;
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.ItemHeight = 16;
            this.eventListBox.Items.AddRange(new object[] {
            "First line",
            "Second line",
            "Third line"});
            this.eventListBox.Location = new System.Drawing.Point(25, 151);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(173, 68);
            this.eventListBox.TabIndex = 3;
            // 
            // eventTestBox
            // 
            this.eventTestBox.Location = new System.Drawing.Point(25, 253);
            this.eventTestBox.Name = "eventTestBox";
            this.eventTestBox.Size = new System.Drawing.Size(210, 22);
            this.eventTestBox.TabIndex = 4;
            // 
            // eventPictureBox
            // 
            this.eventPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("eventPictureBox.Image")));
            this.eventPictureBox.InitialImage = null;
            this.eventPictureBox.Location = new System.Drawing.Point(25, 307);
            this.eventPictureBox.Name = "eventPictureBox";
            this.eventPictureBox.Size = new System.Drawing.Size(248, 233);
            this.eventPictureBox.TabIndex = 5;
            this.eventPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.eventPictureBox);
            this.Controls.Add(this.eventTestBox);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.eventNumericUpDown);
            this.Controls.Add(this.eventLabel);
            this.Controls.Add(this.messagesTextBox);
            this.Name = "mainForm";
            this.Text = "Windows Forms Components - Common Events";
            ((System.ComponentModel.ISupportInitialize)(this.eventNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.Label eventLabel;
        private System.Windows.Forms.NumericUpDown eventNumericUpDown;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.TextBox eventTestBox;
        private System.Windows.Forms.PictureBox eventPictureBox;
    }
}

