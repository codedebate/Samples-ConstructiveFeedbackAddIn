namespace CodeDebate.Samples.ConstructiveFeedback.AddIn
{
    partial class SentimentAnalysisResults
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
            this.SentimentDescription = new System.Windows.Forms.Label();
            this.SentimentVisual = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SentimentVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // SentimentDescription
            // 
            this.SentimentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SentimentDescription.Location = new System.Drawing.Point(162, 12);
            this.SentimentDescription.Name = "SentimentDescription";
            this.SentimentDescription.Size = new System.Drawing.Size(543, 175);
            this.SentimentDescription.TabIndex = 1;
            this.SentimentDescription.Text = "Working on it, please wait...";
            // 
            // SentimentVisual
            // 
            this.SentimentVisual.Image = global::CodeDebate.Samples.ConstructiveFeedback.AddIn.Properties.Resources.invalid;
            this.SentimentVisual.Location = new System.Drawing.Point(12, 12);
            this.SentimentVisual.Name = "SentimentVisual";
            this.SentimentVisual.Size = new System.Drawing.Size(129, 135);
            this.SentimentVisual.TabIndex = 0;
            this.SentimentVisual.TabStop = false;
            // 
            // SentimentAnalysisResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 204);
            this.Controls.Add(this.SentimentDescription);
            this.Controls.Add(this.SentimentVisual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SentimentAnalysisResults";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sentiment Analysis Results";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SentimentAnalysisResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SentimentVisual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SentimentVisual;
        private System.Windows.Forms.Label SentimentDescription;
    }
}