namespace GTranslator
{
    partial class TranslatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.lnkSourceEnglish = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.lnkTargetEnglish = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkReverse = new System.Windows.Forms.LinkLabel();
            this.rtbSource = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbTarget = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Language:";
            // 
            // cboFrom
            // 
            this.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(7, 26);
            this.cboFrom.MaxDropDownItems = 20;
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(154, 22);
            this.cboFrom.Sorted = true;
            this.cboFrom.TabIndex = 1;
            // 
            // lnkSourceEnglish
            // 
            this.lnkSourceEnglish.AutoSize = true;
            this.lnkSourceEnglish.Location = new System.Drawing.Point(120, 9);
            this.lnkSourceEnglish.Name = "lnkSourceEnglish";
            this.lnkSourceEnglish.Size = new System.Drawing.Size(41, 14);
            this.lnkSourceEnglish.TabIndex = 2;
            this.lnkSourceEnglish.TabStop = true;
            this.lnkSourceEnglish.Text = "English";
            this.lnkSourceEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSource_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Language:";
            // 
            // cboTo
            // 
            this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(183, 26);
            this.cboTo.MaxDropDownItems = 20;
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(154, 22);
            this.cboTo.TabIndex = 4;
            // 
            // lnkTargetEnglish
            // 
            this.lnkTargetEnglish.AutoSize = true;
            this.lnkTargetEnglish.Location = new System.Drawing.Point(298, 9);
            this.lnkTargetEnglish.Name = "lnkTargetEnglish";
            this.lnkTargetEnglish.Size = new System.Drawing.Size(41, 14);
            this.lnkTargetEnglish.TabIndex = 5;
            this.lnkTargetEnglish.TabStop = true;
            this.lnkTargetEnglish.Text = "English";
            this.lnkTargetEnglish.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTarget_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Source Text:";
            // 
            // lnkReverse
            // 
            this.lnkReverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkReverse.AutoSize = true;
            this.lnkReverse.Location = new System.Drawing.Point(291, 56);
            this.lnkReverse.Name = "lnkReverse";
            this.lnkReverse.Size = new System.Drawing.Size(48, 14);
            this.lnkReverse.TabIndex = 7;
            this.lnkReverse.TabStop = true;
            this.lnkReverse.Text = "Reverse";
            this.lnkReverse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkReverse_LinkClicked);
            // 
            // rtbSource
            // 
            this.rtbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbSource.Location = new System.Drawing.Point(7, 74);
            this.rtbSource.Name = "rtbSource";
            this.rtbSource.Size = new System.Drawing.Size(331, 64);
            this.rtbSource.TabIndex = 8;
            this.rtbSource.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Translation:";
            // 
            // rtbTarget
            // 
            this.rtbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTarget.BackColor = System.Drawing.SystemColors.Window;
            this.rtbTarget.Location = new System.Drawing.Point(7, 159);
            this.rtbTarget.Name = "rtbTarget";
            this.rtbTarget.ReadOnly = true;
            this.rtbTarget.Size = new System.Drawing.Size(330, 60);
            this.rtbTarget.TabIndex = 10;
            this.rtbTarget.Text = "";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(4, 222);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(16, 14);
            this.lblStatus.TabIndex = 11;
            this.lblStatus.Text = "   ";
            // 
            // webBrowser
            // 
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(103, 222);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(68, 20);
            this.webBrowser.TabIndex = 12;
            this.webBrowser.Visible = false;
            this.webBrowser.WebBrowserShortcutsEnabled = false;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(183, 222);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 13;
            this.btnTranslate.Text = "&Translate";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSpeak.Location = new System.Drawing.Point(262, 222);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 14;
            this.btnSpeak.Text = "&Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 258);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.rtbTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbSource);
            this.Controls.Add(this.lnkReverse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkTargetEnglish);
            this.Controls.Add(this.cboTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkSourceEnglish);
            this.Controls.Add(this.cboFrom);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(880, 296);
            this.MinimumSize = new System.Drawing.Size(311, 296);
            this.Name = "TranslatorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GTranslator v1.0 by KangZhay";
            this.Load += new System.EventHandler(this.TranslatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.LinkLabel lnkSourceEnglish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.LinkLabel lnkTargetEnglish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkReverse;
        private System.Windows.Forms.RichTextBox rtbSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTarget;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.Button btnSpeak;
    }
}

