namespace BitcoinCalc
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
            ArvutaValuuta = new Button();
            bitcoinAmountKogus = new TextBox();
            BitCKogus = new Label();
            Valuuta = new Label();
            bitcoinResultLabel = new Label();
            resultDisplayLabel = new Label();
            currencySelector = new ComboBox();
            SuspendLayout();
            // 
            // ArvutaValuuta
            // 
            ArvutaValuuta.Location = new Point(261, 213);
            ArvutaValuuta.Name = "ArvutaValuuta";
            ArvutaValuuta.Size = new Size(75, 23);
            ArvutaValuuta.TabIndex = 0;
            ArvutaValuuta.Text = "Arvuta";
            ArvutaValuuta.UseVisualStyleBackColor = true;
            ArvutaValuuta.Click += button1_Click;
            // 
            // bitcoinAmountKogus
            // 
            bitcoinAmountKogus.Location = new Point(261, 49);
            bitcoinAmountKogus.Name = "bitcoinAmountKogus";
            bitcoinAmountKogus.Size = new Size(121, 23);
            bitcoinAmountKogus.TabIndex = 1;
            bitcoinAmountKogus.TextChanged += bitcoinAmountKogus_TextChanged;
            // 
            // BitCKogus
            // 
            BitCKogus.AutoSize = true;
            BitCKogus.Location = new Point(261, 31);
            BitCKogus.Name = "BitCKogus";
            BitCKogus.Size = new Size(85, 15);
            BitCKogus.TabIndex = 2;
            BitCKogus.Text = "Bitcoini kogus:";
            // 
            // Valuuta
            // 
            Valuuta.AutoSize = true;
            Valuuta.Location = new Point(261, 122);
            Valuuta.Name = "Valuuta";
            Valuuta.Size = new Size(69, 15);
            Valuuta.TabIndex = 3;
            Valuuta.Text = "Sihtvaluuta:";
            // 
            // bitcoinResultLabel
            // 
            bitcoinResultLabel.AutoSize = true;
            bitcoinResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            bitcoinResultLabel.Location = new Point(12, 349);
            bitcoinResultLabel.Name = "bitcoinResultLabel";
            bitcoinResultLabel.Size = new Size(78, 32);
            bitcoinResultLabel.TabIndex = 4;
            bitcoinResultLabel.Text = "label3";
            bitcoinResultLabel.Click += ArvutuseTulemus_Click;
            // 
            // resultDisplayLabel
            // 
            resultDisplayLabel.AutoSize = true;
            resultDisplayLabel.Location = new Point(12, 322);
            resultDisplayLabel.Name = "resultDisplayLabel";
            resultDisplayLabel.Size = new Size(103, 15);
            resultDisplayLabel.TabIndex = 5;
            resultDisplayLabel.Text = "Arvutuse tulemus:";
            // 
            // currencySelector
            // 
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "EUR", "USD" });
            currencySelector.Location = new Point(261, 140);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(121, 23);
            currencySelector.TabIndex = 6;
            currencySelector.Text = "USD";
            currencySelector.SelectedIndexChanged += currencySelector_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Minupilt;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(818, 470);
            Controls.Add(currencySelector);
            Controls.Add(resultDisplayLabel);
            Controls.Add(bitcoinResultLabel);
            Controls.Add(Valuuta);
            Controls.Add(BitCKogus);
            Controls.Add(bitcoinAmountKogus);
            Controls.Add(ArvutaValuuta);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ArvutaValuuta;
        private TextBox bitcoinAmountKogus;
        private Label BitCKogus;
        private Label Valuuta;
        private Label bitcoinResultLabel;
        private Label resultDisplayLabel;
        private ComboBox currencySelector;
    }
}
