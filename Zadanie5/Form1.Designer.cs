namespace Zadanie5
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
            buttonCalculate = new Button();
            comboDishes = new ComboBox();
            comboSolutions = new ComboBox();
            textCapacity = new TextBox();
            textPercent = new TextBox();
            textQuantity = new TextBox();
            labelScore = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonClear = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textPureSubstance = new TextBox();
            textTotalVolume = new TextBox();
            label6 = new Label();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(582, 218);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(195, 73);
            buttonCalculate.TabIndex = 0;
            buttonCalculate.Text = "Oblicz";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += button1_Click;
            // 
            // comboDishes
            // 
            comboDishes.FormattingEnabled = true;
            comboDishes.Location = new Point(315, 47);
            comboDishes.Name = "comboDishes";
            comboDishes.Size = new Size(219, 28);
            comboDishes.TabIndex = 1;
            comboDishes.SelectedIndexChanged += comboDishes_SelectedIndexChanged;
            // 
            // comboSolutions
            // 
            comboSolutions.FormattingEnabled = true;
            comboSolutions.Location = new Point(315, 145);
            comboSolutions.Name = "comboSolutions";
            comboSolutions.Size = new Size(219, 28);
            comboSolutions.TabIndex = 2;
            comboSolutions.SelectedIndexChanged += comboSolutions_SelectedIndexChanged;
            // 
            // textCapacity
            // 
            textCapacity.Location = new Point(315, 93);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new Size(73, 27);
            textCapacity.TabIndex = 3;
            // 
            // textPercent
            // 
            textPercent.Location = new Point(315, 202);
            textPercent.Name = "textPercent";
            textPercent.Size = new Size(73, 27);
            textPercent.TabIndex = 4;
            // 
            // textQuantity
            // 
            textQuantity.Location = new Point(315, 264);
            textQuantity.Name = "textQuantity";
            textQuantity.Size = new Size(151, 27);
            textQuantity.TabIndex = 5;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(22, 44);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(189, 20);
            labelScore.TabIndex = 6;
            labelScore.Text = "Laczna objetosc plynu (ml):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 7;
            label1.Text = "Typowe naczynie:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 96);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 8;
            label2.Text = "Pojemność [ml]:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 148);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 9;
            label3.Text = "Typowy roztwór:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 205);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 10;
            label4.Text = "Zawartość [%]:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 267);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 11;
            label5.Text = "Liczba naczyń [szt.]:";
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(294, 409);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 12;
            buttonClear.Text = "Czysc";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(22, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 282);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane wejściowe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textPureSubstance);
            groupBox2.Controls.Add(textTotalVolume);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(labelScore);
            groupBox2.Location = new Point(416, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 125);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Wyniki";
            // 
            // textPureSubstance
            // 
            textPureSubstance.Location = new Point(276, 78);
            textPureSubstance.Name = "textPureSubstance";
            textPureSubstance.Size = new Size(70, 27);
            textPureSubstance.TabIndex = 9;
            // 
            // textTotalVolume
            // 
            textTotalVolume.Location = new Point(276, 41);
            textTotalVolume.Name = "textTotalVolume";
            textTotalVolume.Size = new Size(70, 27);
            textTotalVolume.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 85);
            label6.Name = "label6";
            label6.Size = new Size(219, 20);
            label6.TabIndex = 7;
            label6.Text = "Objetosc czystej substancji (ml):";
            // 
            // Form1
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonClear);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textQuantity);
            Controls.Add(textPercent);
            Controls.Add(textCapacity);
            Controls.Add(comboSolutions);
            Controls.Add(comboDishes);
            Controls.Add(buttonCalculate);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Kalkulator Substancji Czynnej";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCalculate;
        private ComboBox comboDishes;
        private ComboBox comboSolutions;
        private TextBox textCapacity;
        private TextBox textPercent;
        private TextBox textQuantity;
        private Label labelScore;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonClear;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textPureSubstance;
        private TextBox textTotalVolume;
        private Label label6;
    }
}
