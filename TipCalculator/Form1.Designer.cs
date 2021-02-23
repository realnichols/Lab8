
namespace TipCalculator
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
            this.Entertotallabel = new System.Windows.Forms.Label();
            this.billenter = new System.Windows.Forms.TextBox();
            this.tiptotal = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.tippercenttext = new System.Windows.Forms.TextBox();
            this.tippercent = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tiptotallabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Entertotallabel
            // 
            this.Entertotallabel.AutoSize = true;
            this.Entertotallabel.Location = new System.Drawing.Point(23, 30);
            this.Entertotallabel.Name = "Entertotallabel";
            this.Entertotallabel.Size = new System.Drawing.Size(98, 17);
            this.Entertotallabel.TabIndex = 0;
            this.Entertotallabel.Text = "Enter bill total:";
            // 
            // billenter
            // 
            this.billenter.Location = new System.Drawing.Point(139, 30);
            this.billenter.Name = "billenter";
            this.billenter.Size = new System.Drawing.Size(100, 22);
            this.billenter.TabIndex = 1;
            this.billenter.TextChanged += new System.EventHandler(this.DoubleCheck);
            // 
            // tiptotal
            // 
            this.tiptotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiptotal.Location = new System.Drawing.Point(330, 127);
            this.tiptotal.Multiline = true;
            this.tiptotal.Name = "tiptotal";
            this.tiptotal.ReadOnly = true;
            this.tiptotal.Size = new System.Drawing.Size(439, 112);
            this.tiptotal.TabIndex = 3;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(26, 80);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(223, 341);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // tippercenttext
            // 
            this.tippercenttext.Location = new System.Drawing.Point(432, 34);
            this.tippercenttext.Name = "tippercenttext";
            this.tippercenttext.Size = new System.Drawing.Size(45, 22);
            this.tippercenttext.TabIndex = 4;
            this.tippercenttext.TextChanged += new System.EventHandler(this.DoubleCheck);
            // 
            // tippercent
            // 
            this.tippercent.AutoSize = true;
            this.tippercent.Location = new System.Drawing.Point(330, 37);
            this.tippercent.Name = "tippercent";
            this.tippercent.Size = new System.Drawing.Size(96, 17);
            this.tippercent.TabIndex = 5;
            this.tippercent.Text = "Percent to tip:";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(483, 37);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(20, 17);
            this.percent.TabIndex = 6;
            this.percent.Text = "%";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(330, 272);
            this.TotalTextBox.Multiline = true;
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(439, 149);
            this.TotalTextBox.TabIndex = 7;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(327, 242);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 17);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total:";
            // 
            // tiptotallabel
            // 
            this.tiptotallabel.AutoSize = true;
            this.tiptotallabel.Location = new System.Drawing.Point(330, 94);
            this.tiptotallabel.Name = "tiptotallabel";
            this.tiptotallabel.Size = new System.Drawing.Size(63, 17);
            this.tiptotallabel.TabIndex = 9;
            this.tiptotallabel.Text = "Tip total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tiptotallabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.tippercent);
            this.Controls.Add(this.tippercenttext);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.tiptotal);
            this.Controls.Add(this.billenter);
            this.Controls.Add(this.Entertotallabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Entertotallabel;
        private System.Windows.Forms.TextBox billenter;
        private System.Windows.Forms.TextBox tiptotal;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox tippercenttext;
        private System.Windows.Forms.Label tippercent;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tiptotallabel;
    }
}

