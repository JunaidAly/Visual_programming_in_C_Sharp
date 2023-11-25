
namespace WinFormsApp5
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
            this.Btn_front_colour = new System.Windows.Forms.Button();
            this.Btn_background = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_text_font = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_front_colour
            // 
            this.Btn_front_colour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_front_colour.Location = new System.Drawing.Point(12, 97);
            this.Btn_front_colour.Name = "Btn_front_colour";
            this.Btn_front_colour.Size = new System.Drawing.Size(146, 36);
            this.Btn_front_colour.TabIndex = 0;
            this.Btn_front_colour.Text = "Form Front Colour";
            this.Btn_front_colour.UseVisualStyleBackColor = true;
            this.Btn_front_colour.Click += new System.EventHandler(this.Btn_front_colour_Click);
            // 
            // Btn_background
            // 
            this.Btn_background.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_background.Location = new System.Drawing.Point(184, 97);
            this.Btn_background.Name = "Btn_background";
            this.Btn_background.Size = new System.Drawing.Size(167, 36);
            this.Btn_background.TabIndex = 1;
            this.Btn_background.Text = "Form Background Colour";
            this.Btn_background.UseVisualStyleBackColor = true;
            this.Btn_background.Click += new System.EventHandler(this.Btn_background_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(121, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Colour Dialog Control";
            // 
            // Btn_text_font
            // 
            this.Btn_text_font.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_text_font.Location = new System.Drawing.Point(121, 154);
            this.Btn_text_font.Name = "Btn_text_font";
            this.Btn_text_font.Size = new System.Drawing.Size(135, 37);
            this.Btn_text_font.TabIndex = 3;
            this.Btn_text_font.Text = "Text Font";
            this.Btn_text_font.UseVisualStyleBackColor = true;
            this.Btn_text_font.Click += new System.EventHandler(this.Btn_text_font_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 203);
            this.Controls.Add(this.Btn_text_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_background);
            this.Controls.Add(this.Btn_front_colour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_front_colour;
        private System.Windows.Forms.Button Btn_background;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_text_font;
    }
}

