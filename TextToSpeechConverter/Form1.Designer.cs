
namespace TextToSpeechConverter
{
    partial class Form1
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
            this.speakBox = new System.Windows.Forms.RichTextBox();
            this.Button_Speak = new System.Windows.Forms.Button();
            this.Button_Pause = new System.Windows.Forms.Button();
            this.Button_Resume = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speakBox
            // 
            this.speakBox.Location = new System.Drawing.Point(60, 32);
            this.speakBox.Name = "speakBox";
            this.speakBox.Size = new System.Drawing.Size(338, 215);
            this.speakBox.TabIndex = 0;
            this.speakBox.Text = "";
            // 
            // Button_Speak
            // 
            this.Button_Speak.Location = new System.Drawing.Point(71, 253);
            this.Button_Speak.Name = "Button_Speak";
            this.Button_Speak.Size = new System.Drawing.Size(75, 23);
            this.Button_Speak.TabIndex = 1;
            this.Button_Speak.Text = "Speak";
            this.Button_Speak.UseVisualStyleBackColor = true;
            this.Button_Speak.Click += new System.EventHandler(this.Button_Speak_Click);
            // 
            // Button_Pause
            // 
            this.Button_Pause.Location = new System.Drawing.Point(152, 253);
            this.Button_Pause.Name = "Button_Pause";
            this.Button_Pause.Size = new System.Drawing.Size(75, 23);
            this.Button_Pause.TabIndex = 2;
            this.Button_Pause.Text = "Pause";
            this.Button_Pause.UseVisualStyleBackColor = true;
            this.Button_Pause.Click += new System.EventHandler(this.Button_Pause_Click);
            // 
            // Button_Resume
            // 
            this.Button_Resume.Location = new System.Drawing.Point(234, 254);
            this.Button_Resume.Name = "Button_Resume";
            this.Button_Resume.Size = new System.Drawing.Size(75, 23);
            this.Button_Resume.TabIndex = 3;
            this.Button_Resume.Text = "Resume";
            this.Button_Resume.UseVisualStyleBackColor = true;
            this.Button_Resume.Click += new System.EventHandler(this.Button_Resume_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Location = new System.Drawing.Point(316, 254);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 23);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 299);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Resume);
            this.Controls.Add(this.Button_Pause);
            this.Controls.Add(this.Button_Speak);
            this.Controls.Add(this.speakBox);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Text to speech converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox speakBox;
        private System.Windows.Forms.Button Button_Speak;
        private System.Windows.Forms.Button Button_Pause;
        private System.Windows.Forms.Button Button_Resume;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Label label1;
    }
}

