namespace File_Converter
{
    partial class SelectConverterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectConverterForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonVideoConverter = new System.Windows.Forms.Button();
            this.buttonAudioConverter = new System.Windows.Forms.Button();
            this.buttonTextConverter = new System.Windows.Forms.Button();
            this.groupButtons = new System.Windows.Forms.GroupBox();
            this.groupButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(257, 31);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Mikatsu File Converter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "In this app you can convert from one file \r\nformat to another one";
            // 
            // buttonVideoConverter
            // 
            this.buttonVideoConverter.Location = new System.Drawing.Point(6, 26);
            this.buttonVideoConverter.Name = "buttonVideoConverter";
            this.buttonVideoConverter.Size = new System.Drawing.Size(115, 61);
            this.buttonVideoConverter.TabIndex = 2;
            this.buttonVideoConverter.Tag = "Video";
            this.buttonVideoConverter.Text = "Video Converter";
            this.buttonVideoConverter.UseVisualStyleBackColor = true;
            this.buttonVideoConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // buttonAudioConverter
            // 
            this.buttonAudioConverter.Location = new System.Drawing.Point(127, 26);
            this.buttonAudioConverter.Name = "buttonAudioConverter";
            this.buttonAudioConverter.Size = new System.Drawing.Size(115, 61);
            this.buttonAudioConverter.TabIndex = 3;
            this.buttonAudioConverter.Tag = "Audio";
            this.buttonAudioConverter.Text = "Audio Converter";
            this.buttonAudioConverter.UseVisualStyleBackColor = true;
            this.buttonAudioConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // buttonTextConverter
            // 
            this.buttonTextConverter.Location = new System.Drawing.Point(248, 26);
            this.buttonTextConverter.Name = "buttonTextConverter";
            this.buttonTextConverter.Size = new System.Drawing.Size(115, 61);
            this.buttonTextConverter.TabIndex = 4;
            this.buttonTextConverter.Tag = "Text";
            this.buttonTextConverter.Text = "Text File Converter";
            this.buttonTextConverter.UseVisualStyleBackColor = true;
            this.buttonTextConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // groupButtons
            // 
            this.groupButtons.Controls.Add(this.buttonVideoConverter);
            this.groupButtons.Controls.Add(this.buttonTextConverter);
            this.groupButtons.Controls.Add(this.buttonAudioConverter);
            this.groupButtons.Location = new System.Drawing.Point(12, 111);
            this.groupButtons.Name = "groupButtons";
            this.groupButtons.Size = new System.Drawing.Size(369, 97);
            this.groupButtons.TabIndex = 5;
            this.groupButtons.TabStop = false;
            this.groupButtons.Text = "Select Converter";
            // 
            // SelectConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 218);
            this.Controls.Add(this.groupButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectConverterForm";
            this.Text = "Coverter Selector";
            this.groupButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVideoConverter;
        private System.Windows.Forms.Button buttonAudioConverter;
        private System.Windows.Forms.Button buttonTextConverter;
        private System.Windows.Forms.GroupBox groupButtons;
    }
}