
namespace Merge_Intervall
{
    partial class MergeIntervallView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeIntervallView));
            this.pathBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.OpenNRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathBox.Location = new System.Drawing.Point(12, 20);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(261, 21);
            this.pathBox.TabIndex = 0;
            // 
            // resultBox
            // 
            this.resultBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resultBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(12, 46);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(364, 188);
            this.resultBox.TabIndex = 1;
            this.resultBox.Text = "";
            // 
            // OpenNRun
            // 
            this.OpenNRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenNRun.Location = new System.Drawing.Point(283, 18);
            this.OpenNRun.Name = "OpenNRun";
            this.OpenNRun.Size = new System.Drawing.Size(93, 23);
            this.OpenNRun.TabIndex = 2;
            this.OpenNRun.Text = "Open and &Run";
            this.OpenNRun.UseVisualStyleBackColor = true;
            this.OpenNRun.Click += new System.EventHandler(this.OpenNRun_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(291, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "by Burak Sancak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path:";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar.Location = new System.Drawing.Point(12, 239);
            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(160, 13);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 6;
            this.progressBar.Visible = false;
            // 
            // MergeIntervallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 256);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OpenNRun);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.pathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(404, 295);
            this.Name = "MergeIntervallView";
            this.Text = "Merge Intervall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button OpenNRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

