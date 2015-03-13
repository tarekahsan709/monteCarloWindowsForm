namespace carlosForm
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.retriveInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPai = new System.Windows.Forms.Label();
            this.graphArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.graphArea)).BeginInit();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(104, 9);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(122, 26);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // retriveInput
            // 
            this.retriveInput.ForeColor = System.Drawing.Color.Red;
            this.retriveInput.Location = new System.Drawing.Point(104, 53);
            this.retriveInput.Name = "retriveInput";
            this.retriveInput.Size = new System.Drawing.Size(75, 23);
            this.retriveInput.TabIndex = 1;
            this.retriveInput.Text = "Click ";
            this.retriveInput.UseVisualStyleBackColor = true;
            this.retriveInput.Click += new System.EventHandler(this.retriveInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Radius";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelPai
            // 
            this.labelPai.AutoSize = true;
            this.labelPai.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelPai.Location = new System.Drawing.Point(15, 114);
            this.labelPai.Name = "labelPai";
            this.labelPai.Size = new System.Drawing.Size(83, 13);
            this.labelPai.TabIndex = 3;
            this.labelPai.Text = "Average of Pai=";
            this.labelPai.Click += new System.EventHandler(this.label2_Click);
            // 
            // graphArea
            // 
            this.graphArea.Location = new System.Drawing.Point(311, 25);
            this.graphArea.Name = "graphArea";
            this.graphArea.Size = new System.Drawing.Size(287, 252);
            this.graphArea.TabIndex = 4;
            this.graphArea.TabStop = false;
            this.graphArea.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 352);
            this.Controls.Add(this.graphArea);
            this.Controls.Add(this.labelPai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.retriveInput);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Button retriveInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPai;
        private System.Windows.Forms.PictureBox graphArea;

    }
}

