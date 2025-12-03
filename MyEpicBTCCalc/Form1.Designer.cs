namespace MyEpicBTCCalc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btcoinAmountInput = new TextBox();
            btcLabel = new Label();
            comboBox1 = new ComboBox();
            toCurrencyLabel = new Label();
            getRate = new Button();
            SuspendLayout();
            // 
            // btcoinAmountInput
            // 
            btcoinAmountInput.Location = new Point(396, 58);
            btcoinAmountInput.Name = "btcoinAmountInput";
            btcoinAmountInput.Size = new Size(121, 23);
            btcoinAmountInput.TabIndex = 0;
            // 
            // btcLabel
            // 
            btcLabel.AutoSize = true;
            btcLabel.Location = new Point(396, 40);
            btcLabel.Name = "btcLabel";
            btcLabel.Size = new Size(82, 15);
            btcLabel.TabIndex = 1;
            btcLabel.Text = "Bitcoini kogus";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "EUR", "USD" });
            comboBox1.Location = new Point(396, 123);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // toCurrencyLabel
            // 
            toCurrencyLabel.AutoSize = true;
            toCurrencyLabel.Location = new Point(396, 105);
            toCurrencyLabel.Name = "toCurrencyLabel";
            toCurrencyLabel.Size = new Size(69, 15);
            toCurrencyLabel.TabIndex = 3;
            toCurrencyLabel.Text = "Sihtvaluuta:";
            // 
            // getRate
            // 
            getRate.Location = new Point(442, 180);
            getRate.Name = "getRate";
            getRate.Size = new Size(75, 23);
            getRate.TabIndex = 4;
            getRate.Text = "Arvuta";
            getRate.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1018, 390);
            Controls.Add(getRate);
            Controls.Add(toCurrencyLabel);
            Controls.Add(comboBox1);
            Controls.Add(btcLabel);
            Controls.Add(btcoinAmountInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox btcoinAmountInput;
        private Label btcLabel;
        private ComboBox comboBox1;
        private Label toCurrencyLabel;
        private Button getRate;
    }
}
