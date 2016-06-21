namespace StopWatch0
{
    partial class FormStopWatch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStopWatch));
            this.labelTime = new System.Windows.Forms.Label();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.coStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coTimer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTime
            // 
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(2, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(156, 54);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "00:00:00";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textNotes
            // 
            this.textNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNotes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textNotes.Location = new System.Drawing.Point(164, 3);
            this.textNotes.Multiline = true;
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(250, 54);
            this.textNotes.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(420, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(87, 54);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coStart,
            this.coNotes,
            this.coTimer});
            this.grid.Location = new System.Drawing.Point(2, 63);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(505, 192);
            this.grid.TabIndex = 3;
            // 
            // coStart
            // 
            this.coStart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coStart.HeaderText = "Start";
            this.coStart.Name = "coStart";
            this.coStart.ReadOnly = true;
            // 
            // coNotes
            // 
            this.coNotes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coNotes.HeaderText = "Notes";
            this.coNotes.Name = "coNotes";
            this.coNotes.ReadOnly = true;
            // 
            // coTimer
            // 
            this.coTimer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.coTimer.HeaderText = "Timer";
            this.coTimer.Name = "coTimer";
            this.coTimer.ReadOnly = true;
            // 
            // timer
            // 
            this.timer.Interval = 950;
            // 
            // FormStopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 260);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.labelTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 100);
            this.Name = "FormStopWatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SopWatch Notes";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn coNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn coTimer;
        private System.Windows.Forms.Timer timer;
    }
}

