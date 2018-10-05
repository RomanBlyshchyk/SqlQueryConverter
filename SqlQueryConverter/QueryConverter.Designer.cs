namespace MobileQueryConverter
{
    partial class QueryConverter
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
            this.rtbBefore = new System.Windows.Forms.RichTextBox();
            this.rtbAfter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbBefore
            // 
            this.rtbBefore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbBefore.Location = new System.Drawing.Point(12, 12);
            this.rtbBefore.Name = "rtbBefore";
            this.rtbBefore.Size = new System.Drawing.Size(960, 256);
            this.rtbBefore.TabIndex = 0;
            this.rtbBefore.Text = "";
            this.rtbBefore.TextChanged += new System.EventHandler(this.rtbBefore_TextChanged);
            // 
            // rtbAfter
            // 
            this.rtbAfter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAfter.Location = new System.Drawing.Point(12, 274);
            this.rtbAfter.Name = "rtbAfter";
            this.rtbAfter.ReadOnly = true;
            this.rtbAfter.Size = new System.Drawing.Size(960, 276);
            this.rtbAfter.TabIndex = 0;
            this.rtbAfter.Text = "";
            // 
            // QueryConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.rtbAfter);
            this.Controls.Add(this.rtbBefore);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "QueryConverter";
            this.Text = "Sql Query Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBefore;
        private System.Windows.Forms.RichTextBox rtbAfter;
    }
}

