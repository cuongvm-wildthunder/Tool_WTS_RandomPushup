
namespace Tool_WTS_RandomPushup
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
            this.rtbxInput = new System.Windows.Forms.RichTextBox();
            this.rtbxOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxStartCount = new System.Windows.Forms.TextBox();
            this.tbxNextMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNextMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxInput
            // 
            this.rtbxInput.Location = new System.Drawing.Point(12, 110);
            this.rtbxInput.Name = "rtbxInput";
            this.rtbxInput.Size = new System.Drawing.Size(327, 328);
            this.rtbxInput.TabIndex = 0;
            this.rtbxInput.Text = "";
            // 
            // rtbxOutput
            // 
            this.rtbxOutput.Location = new System.Drawing.Point(461, 110);
            this.rtbxOutput.Name = "rtbxOutput";
            this.rtbxOutput.Size = new System.Drawing.Size(327, 328);
            this.rtbxOutput.TabIndex = 1;
            this.rtbxOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số lượng khởi đầu";
            // 
            // tbxStartCount
            // 
            this.tbxStartCount.Location = new System.Drawing.Point(112, 10);
            this.tbxStartCount.Name = "tbxStartCount";
            this.tbxStartCount.Size = new System.Drawing.Size(52, 20);
            this.tbxStartCount.TabIndex = 3;
            // 
            // tbxNextMin
            // 
            this.tbxNextMin.Location = new System.Drawing.Point(287, 10);
            this.tbxNextMin.Name = "tbxNextMin";
            this.tbxNextMin.Size = new System.Drawing.Size(52, 20);
            this.tbxNextMin.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng thêm";
            // 
            // tbxNextMax
            // 
            this.tbxNextMax.Location = new System.Drawing.Point(368, 10);
            this.tbxNextMax.Name = "tbxNextMax";
            this.tbxNextMax.Size = new System.Drawing.Size(52, 20);
            this.tbxNextMax.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(311, 60);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(186, 40);
            this.btnRandom.TabIndex = 8;
            this.btnRandom.Text = "Nhân phẩm";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbxNextMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNextMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxStartCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbxOutput);
            this.Controls.Add(this.rtbxInput);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "[ WILD THUNDER] Vì một tập thể khỏe mạnh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxInput;
        private System.Windows.Forms.RichTextBox rtbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxStartCount;
        private System.Windows.Forms.TextBox tbxNextMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNextMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRandom;
    }
}

