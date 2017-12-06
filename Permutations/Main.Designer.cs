namespace Permutations
{
    partial class Main
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
            this.lblText = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.btnPermuting = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AllowDrop = true;
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(36, 27);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(422, 54);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Please, choose how many members \r\n             do you want for the permutations.." +
    ".";
            // 
            // txbInput
            // 
            this.txbInput.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInput.Location = new System.Drawing.Point(355, 94);
            this.txbInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(103, 38);
            this.txbInput.TabIndex = 1;
            this.txbInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPermuting
            // 
            this.btnPermuting.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermuting.Location = new System.Drawing.Point(355, 150);
            this.btnPermuting.Name = "btnPermuting";
            this.btnPermuting.Size = new System.Drawing.Size(103, 39);
            this.btnPermuting.TabIndex = 2;
            this.btnPermuting.Text = "Permuting...";
            this.btnPermuting.UseVisualStyleBackColor = true;
            this.btnPermuting.Click += new System.EventHandler(this.btnPermuting_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(12, 138);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 18);
            this.lblError.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 201);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnPermuting);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permutations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txbInput;
        private System.Windows.Forms.Button btnPermuting;
        private System.Windows.Forms.Label lblError;
    }
}

