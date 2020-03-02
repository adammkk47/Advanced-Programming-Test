namespace Test
{
    partial class DatabaseHistory
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
            this.dgDatabaseHistory = new System.Windows.Forms.DataGridView();
            this.lblDatabaseHistory = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatabaseHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatabaseHistory
            // 
            this.dgDatabaseHistory.AllowUserToAddRows = false;
            this.dgDatabaseHistory.AllowUserToDeleteRows = false;
            this.dgDatabaseHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatabaseHistory.Location = new System.Drawing.Point(130, 89);
            this.dgDatabaseHistory.Name = "dgDatabaseHistory";
            this.dgDatabaseHistory.ReadOnly = true;
            this.dgDatabaseHistory.RowHeadersWidth = 62;
            this.dgDatabaseHistory.RowTemplate.Height = 28;
            this.dgDatabaseHistory.Size = new System.Drawing.Size(572, 360);
            this.dgDatabaseHistory.TabIndex = 0;
            // 
            // lblDatabaseHistory
            // 
            this.lblDatabaseHistory.AutoSize = true;
            this.lblDatabaseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblDatabaseHistory.Location = new System.Drawing.Point(243, 23);
            this.lblDatabaseHistory.Name = "lblDatabaseHistory";
            this.lblDatabaseHistory.Size = new System.Drawing.Size(326, 46);
            this.lblDatabaseHistory.TabIndex = 1;
            this.lblDatabaseHistory.Text = "Database History";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(672, 474);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 36);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DatabaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblDatabaseHistory);
            this.Controls.Add(this.dgDatabaseHistory);
            this.Name = "DatabaseHistory";
            this.Text = "DatabaseHistory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseHistory_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatabaseHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDatabaseHistory;
        private System.Windows.Forms.Label lblDatabaseHistory;
        private System.Windows.Forms.Button btnReturn;
    }
}