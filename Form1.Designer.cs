namespace gif2images
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblInputGif = new System.Windows.Forms.Label();
            this.txtInputGif = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.lblOutputDir = new System.Windows.Forms.Label();
            this.txtOutputDir = new System.Windows.Forms.TextBox();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.lblStartFrame = new System.Windows.Forms.Label();
            this.txtStartFrame = new System.Windows.Forms.TextBox();
            this.lblEndFrame = new System.Windows.Forms.Label();
            this.txtEndFrame = new System.Windows.Forms.TextBox();
            this.lblStep = new System.Windows.Forms.Label();
            this.txtStep = new System.Windows.Forms.TextBox();
            this.btnCreateCombinedImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputGif
            // 
            this.lblInputGif.AutoSize = true;
            this.lblInputGif.Location = new System.Drawing.Point(22, 23);
            this.lblInputGif.Name = "lblInputGif";
            this.lblInputGif.Size = new System.Drawing.Size(81, 20);
            this.lblInputGif.TabIndex = 0;
            this.lblInputGif.Text = "Input GIF:";
            // 
            // txtInputGif
            // 
            this.txtInputGif.Location = new System.Drawing.Point(109, 20);
            this.txtInputGif.Name = "txtInputGif";
            this.txtInputGif.Size = new System.Drawing.Size(431, 27);
            this.txtInputGif.TabIndex = 1;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(558, 18);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseInput.TabIndex = 2;
            this.btnBrowseInput.Text = "Browse";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.btnBrowseInput_Click);
            // 
            // lblOutputDir
            // 
            this.lblOutputDir.AutoSize = true;
            this.lblOutputDir.Location = new System.Drawing.Point(11, 74);
            this.lblOutputDir.Name = "lblOutputDir";
            this.lblOutputDir.Size = new System.Drawing.Size(92, 20);
            this.lblOutputDir.TabIndex = 3;
            this.lblOutputDir.Text = "Output Dir:";
            // 
            // txtOutputDir
            // 
            this.txtOutputDir.Location = new System.Drawing.Point(109, 71);
            this.txtOutputDir.Name = "txtOutputDir";
            this.txtOutputDir.Size = new System.Drawing.Size(431, 27);
            this.txtOutputDir.TabIndex = 4;
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(558, 69);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(94, 29);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Browse";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(456, 118);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(121, 46);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lblStartFrame
            // 
            this.lblStartFrame.AutoSize = true;
            this.lblStartFrame.Location = new System.Drawing.Point(11, 118);
            this.lblStartFrame.Name = "lblStartFrame";
            this.lblStartFrame.Size = new System.Drawing.Size(89, 20);
            this.lblStartFrame.TabIndex = 7;
            this.lblStartFrame.Text = "Start Frame:";
            // 
            // txtStartFrame
            // 
            this.txtStartFrame.Location = new System.Drawing.Point(109, 115);
            this.txtStartFrame.Name = "txtStartFrame";
            this.txtStartFrame.Size = new System.Drawing.Size(78, 27);
            this.txtStartFrame.TabIndex = 8;
            // 
            // lblEndFrame
            // 
            this.lblEndFrame.AutoSize = true;
            this.lblEndFrame.Location = new System.Drawing.Point(197, 118);
            this.lblEndFrame.Name = "lblEndFrame";
            this.lblEndFrame.Size = new System.Drawing.Size(83, 20);
            this.lblEndFrame.TabIndex = 9;
            this.lblEndFrame.Text = "End Frame:";
            // 
            // txtEndFrame
            // 
            this.txtEndFrame.Location = new System.Drawing.Point(286, 115);
            this.txtEndFrame.Name = "txtEndFrame";
            this.txtEndFrame.Size = new System.Drawing.Size(78, 27);
            this.txtEndFrame.TabIndex = 10;
            // 
            // lblStep
            // 
            this.lblStep.AutoSize = true;
            this.lblStep.Location = new System.Drawing.Point(11, 154);
            this.lblStep.Name = "lblStep";
            this.lblStep.Size = new System.Drawing.Size(41, 20);
            this.lblStep.TabIndex = 11;
            this.lblStep.Text = "Step:";
            // 
            // txtStep
            // 
            this.txtStep.Location = new System.Drawing.Point(109, 151);
            this.txtStep.Name = "txtStep";
            this.txtStep.Size = new System.Drawing.Size(78, 27);
            this.txtStep.TabIndex = 12;
            // 
            // btnCreateCombinedImage
            // 
            this.btnCreateCombinedImage.Location = new System.Drawing.Point(286, 151);
            this.btnCreateCombinedImage.Name = "btnCreateCombinedImage";
            this.btnCreateCombinedImage.Size = new System.Drawing.Size(145, 29);
            this.btnCreateCombinedImage.TabIndex = 13;
            this.btnCreateCombinedImage.Text = "Create Combined Image";
            this.btnCreateCombinedImage.UseVisualStyleBackColor = true;
            this.btnCreateCombinedImage.Click += new System.EventHandler(this.btnCreateCombinedImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 202);
            this.Controls.Add(this.btnCreateCombinedImage);
            this.Controls.Add(this.txtStep);
            this.Controls.Add(this.lblStep);
            this.Controls.Add(this.txtEndFrame);
            this.Controls.Add(this.lblEndFrame);
            this.Controls.Add(this.txtStartFrame);
            this.Controls.Add(this.lblStartFrame);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutputDir);
            this.Controls.Add(this.lblOutputDir);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txtInputGif);
            this.Controls.Add(this.lblInputGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gif to Images Extractor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblInputGif;
        private TextBox txtInputGif;
        private Button btnBrowseInput;
        private Label lblOutputDir;
        private TextBox txtOutputDir;
        private Button btnBrowseOutput;
        private Button btnExtract;
        private Label lblStartFrame;
        private TextBox txtStartFrame;
        private Label lblEndFrame;
        private TextBox txtEndFrame;
        private Label lblStep;
        private TextBox txtStep;
        private Button btnCreateCombinedImage;
    }
}