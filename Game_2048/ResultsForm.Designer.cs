namespace Game_2048
{
    partial class ResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsForm));
            this.resultsCloseButton = new System.Windows.Forms.Button();
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsCloseButton
            // 
            this.resultsCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsCloseButton.BackColor = System.Drawing.Color.LightSalmon;
            this.resultsCloseButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultsCloseButton.Location = new System.Drawing.Point(647, 379);
            this.resultsCloseButton.Name = "resultsCloseButton";
            this.resultsCloseButton.Size = new System.Drawing.Size(126, 41);
            this.resultsCloseButton.TabIndex = 0;
            this.resultsCloseButton.Text = "Close";
            this.resultsCloseButton.UseVisualStyleBackColor = false;
            this.resultsCloseButton.Click += new System.EventHandler(this.resultsCloseButton_Click);
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.resultsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.userScoreColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(60, 51);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersWidth = 62;
            this.resultsDataGridView.RowTemplate.Height = 33;
            this.resultsDataGridView.Size = new System.Drawing.Size(687, 225);
            this.resultsDataGridView.TabIndex = 1;
            // 
            // userNameColumn
            // 
            this.userNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userNameColumn.HeaderText = "Name";
            this.userNameColumn.MinimumWidth = 8;
            this.userNameColumn.Name = "userNameColumn";
            // 
            // userScoreColumn
            // 
            this.userScoreColumn.HeaderText = "Score";
            this.userScoreColumn.MinimumWidth = 8;
            this.userScoreColumn.Name = "userScoreColumn";
            this.userScoreColumn.Width = 150;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultsDataGridView);
            this.Controls.Add(this.resultsCloseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button resultsCloseButton;
        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn userNameColumn;
        private DataGridViewTextBoxColumn userScoreColumn;
    }
}