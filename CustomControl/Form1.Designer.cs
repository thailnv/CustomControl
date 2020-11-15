namespace CustomControl
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
            this.btnAddCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddCard
            // 
            this.btnAddCard.Location = new System.Drawing.Point(90, 597);
            this.btnAddCard.Name = "btnAddCard";
            this.btnAddCard.Size = new System.Drawing.Size(659, 61);
            this.btnAddCard.TabIndex = 0;
            this.btnAddCard.Text = "Add a random card";
            this.btnAddCard.UseVisualStyleBackColor = true;
            this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 744);
            this.Controls.Add(this.btnAddCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CustomCard";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCard;
    }
}

