namespace BlackJack
{
    partial class FrmSkorlar
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
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lblPuan1 = new Label();
            lblPuan2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 31;
            listBox1.Location = new Point(24, 85);
            listBox1.Margin = new Padding(5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(377, 438);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 1;
            label1.Text = "Oyuncu1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(291, 9);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 1;
            label2.Text = "Oyuncu2";
            // 
            // lblPuan1
            // 
            lblPuan1.AutoSize = true;
            lblPuan1.Location = new Point(58, 41);
            lblPuan1.Margin = new Padding(5, 0, 5, 0);
            lblPuan1.Name = "lblPuan1";
            lblPuan1.Size = new Size(27, 32);
            lblPuan1.TabIndex = 1;
            lblPuan1.Text = "0";
            // 
            // lblPuan2
            // 
            lblPuan2.AutoSize = true;
            lblPuan2.Location = new Point(328, 48);
            lblPuan2.Margin = new Padding(5, 0, 5, 0);
            lblPuan2.Name = "lblPuan2";
            lblPuan2.Size = new Size(27, 32);
            lblPuan2.TabIndex = 1;
            lblPuan2.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(126, 531);
            button1.Name = "button1";
            button1.Size = new Size(177, 67);
            button1.TabIndex = 2;
            button1.Text = "Kapat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmSkorlar
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 610);
            Controls.Add(button1);
            Controls.Add(lblPuan2);
            Controls.Add(label2);
            Controls.Add(lblPuan1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSkorlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmSkorlar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label lblPuan1;
        private Label lblPuan2;
        private Button button1;
    }
}