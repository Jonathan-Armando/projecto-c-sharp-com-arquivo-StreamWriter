namespace None
{
    partial class SourceForm
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
            this.pathTxt = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pathTxt
            // 
            this.pathTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathTxt.Location = new System.Drawing.Point(180, 56);
            this.pathTxt.Name = "pathTxt";
            this.pathTxt.Size = new System.Drawing.Size(513, 26);
            this.pathTxt.TabIndex = 1;
            this.pathTxt.Text = "None file selected";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(56, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(637, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFilePath.Location = new System.Drawing.Point(61, 57);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(84, 22);
            this.lblFilePath.TabIndex = 3;
            this.lblFilePath.Text = "File Path";
            // 
            // SourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(756, 261);
            this.Controls.Add(this.lblFilePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pathTxt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SourceForm";
            this.Text = "None";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pathTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFilePath;
    }
}

