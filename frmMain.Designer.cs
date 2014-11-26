namespace TextEditor
{
    partial class frmMain
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.openTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblFileName = new System.Windows.Forms.Label();
            this.saveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.chooseFontDialog = new System.Windows.Forms.FontDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 40);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open...";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(118, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close File";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(772, 560);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtMain
            // 
            this.txtMain.AcceptsReturn = true;
            this.txtMain.AcceptsTab = true;
            this.txtMain.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(12, 59);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMain.Size = new System.Drawing.Size(860, 495);
            this.txtMain.TabIndex = 4;
            // 
            // openTextDialog
            // 
            this.openTextDialog.Filter = "Text Files|*.txt";
            this.openTextDialog.Title = "Open a text file";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(9, 572);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(70, 15);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "Current File";
            // 
            // saveTextDialog
            // 
            this.saveTextDialog.FileName = "*.txt";
            this.saveTextDialog.Filter = "Text Files|*.txt";
            this.saveTextDialog.Title = "Save As...";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Location = new System.Drawing.Point(224, 13);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(100, 40);
            this.btnSaveAs.TabIndex = 7;
            this.btnSaveAs.Text = "Save As...";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(684, 13);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(82, 40);
            this.btnFont.TabIndex = 8;
            this.btnFont.Text = "Display Font...";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // chooseFontDialog
            // 
            this.chooseFontDialog.ShowEffects = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(772, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 40);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "Help/About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 612);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnSaveAs);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Name = "frmMain";
            this.Text = "Text Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.OpenFileDialog openTextDialog;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.SaveFileDialog saveTextDialog;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.FontDialog chooseFontDialog;
        private System.Windows.Forms.Button btnAbout;
    }
}

