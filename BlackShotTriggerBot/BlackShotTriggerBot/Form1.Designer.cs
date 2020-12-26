
namespace BlackShotTriggerBot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Customcursor_checkBox = new System.Windows.Forms.CheckBox();
            this.Triggerbot_checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Customcursor_checkBox
            // 
            this.Customcursor_checkBox.AutoSize = true;
            this.Customcursor_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.Customcursor_checkBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customcursor_checkBox.ForeColor = System.Drawing.Color.Red;
            this.Customcursor_checkBox.Location = new System.Drawing.Point(63, 197);
            this.Customcursor_checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Customcursor_checkBox.Name = "Customcursor_checkBox";
            this.Customcursor_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Customcursor_checkBox.Size = new System.Drawing.Size(270, 49);
            this.Customcursor_checkBox.TabIndex = 1;
            this.Customcursor_checkBox.Text = "Custom Cursor";
            this.Customcursor_checkBox.UseVisualStyleBackColor = false;
            this.Customcursor_checkBox.CheckedChanged += new System.EventHandler(this.Customcursor_checkBox_CheckedChanged);
            // 
            // Triggerbot_checkBox
            // 
            this.Triggerbot_checkBox.AutoSize = true;
            this.Triggerbot_checkBox.BackColor = System.Drawing.Color.Transparent;
            this.Triggerbot_checkBox.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Triggerbot_checkBox.ForeColor = System.Drawing.Color.Red;
            this.Triggerbot_checkBox.Location = new System.Drawing.Point(63, 106);
            this.Triggerbot_checkBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Triggerbot_checkBox.Name = "Triggerbot_checkBox";
            this.Triggerbot_checkBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Triggerbot_checkBox.Size = new System.Drawing.Size(228, 49);
            this.Triggerbot_checkBox.TabIndex = 2;
            this.Triggerbot_checkBox.Text = "Trigger Bot";
            this.Triggerbot_checkBox.UseVisualStyleBackColor = false;
            this.Triggerbot_checkBox.CheckedChanged += new System.EventHandler(this.Triggerbot_checkBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BlackShotTriggerBot.Properties.Resources.bswallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 682);
            this.Controls.Add(this.Triggerbot_checkBox);
            this.Controls.Add(this.Customcursor_checkBox);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Blackshot Hack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox Customcursor_checkBox;
        private System.Windows.Forms.CheckBox Triggerbot_checkBox;
    }
}

