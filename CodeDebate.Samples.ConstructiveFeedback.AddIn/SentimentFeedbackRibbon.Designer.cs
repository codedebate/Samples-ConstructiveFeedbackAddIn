namespace CodeDebate.Samples.ConstructiveFeedback.AddIn
{
    partial class SentimentFeedbackRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public SentimentFeedbackRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentimentFeedbackRibbon));
            this.CodeDebateTab = this.Factory.CreateRibbonTab();
            this.ConstructiveFeedbackGroup = this.Factory.CreateRibbonGroup();
            this.AnalyizeSentimentButton = this.Factory.CreateRibbonButton();
            this.CodeDebateTab.SuspendLayout();
            this.ConstructiveFeedbackGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CodeDebateTab
            // 
            this.CodeDebateTab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.CodeDebateTab.Groups.Add(this.ConstructiveFeedbackGroup);
            this.CodeDebateTab.Label = "CodeDebate";
            this.CodeDebateTab.Name = "CodeDebateTab";
            // 
            // ConstructiveFeedbackGroup
            // 
            this.ConstructiveFeedbackGroup.Items.Add(this.AnalyizeSentimentButton);
            this.ConstructiveFeedbackGroup.Label = "Constructive Feedback Sample";
            this.ConstructiveFeedbackGroup.Name = "ConstructiveFeedbackGroup";
            // 
            // AnalyizeSentimentButton
            // 
            this.AnalyizeSentimentButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.AnalyizeSentimentButton.Image = ((System.Drawing.Image)(resources.GetObject("AnalyizeSentimentButton.Image")));
            this.AnalyizeSentimentButton.Label = "Analyze Sentiment";
            this.AnalyizeSentimentButton.Name = "AnalyizeSentimentButton";
            this.AnalyizeSentimentButton.ShowImage = true;
            this.AnalyizeSentimentButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AnalyizeSentimentButton_Click);
            // 
            // SentimentFeedbackRibbon
            // 
            this.Name = "SentimentFeedbackRibbon";
            this.RibbonType = "Microsoft.Outlook.Mail.Compose";
            this.Tabs.Add(this.CodeDebateTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.SentimentFeedbackRibbon_Load);
            this.CodeDebateTab.ResumeLayout(false);
            this.CodeDebateTab.PerformLayout();
            this.ConstructiveFeedbackGroup.ResumeLayout(false);
            this.ConstructiveFeedbackGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab CodeDebateTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ConstructiveFeedbackGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton AnalyizeSentimentButton;
    }

    partial class ThisRibbonCollection
    {
        internal SentimentFeedbackRibbon SentimentFeedbackRibbon
        {
            get { return this.GetRibbon<SentimentFeedbackRibbon>(); }
        }
    }
}
