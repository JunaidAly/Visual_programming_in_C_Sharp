
namespace JunaidPractice
{
    partial class colour_dialog
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
            this.Btn_front_color = new System.Windows.Forms.Button();
            this.Btn_background_color = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_font = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_front_color
            // 
            this.Btn_front_color.Location = new System.Drawing.Point(63, 101);
            this.Btn_front_color.Name = "Btn_front_color";
            this.Btn_front_color.Size = new System.Drawing.Size(121, 66);
            this.Btn_front_color.TabIndex = 0;
            this.Btn_front_color.Text = "Form Front Color";
            this.Btn_front_color.UseVisualStyleBackColor = true;
            this.Btn_front_color.Click += new System.EventHandler(this.Btn_front_color_Click);
            // 
            // Btn_background_color
            // 
            this.Btn_background_color.Location = new System.Drawing.Point(245, 101);
            this.Btn_background_color.Name = "Btn_background_color";
            this.Btn_background_color.Size = new System.Drawing.Size(125, 66);
            this.Btn_background_color.TabIndex = 1;
            this.Btn_background_color.Text = "Background Colour";
            this.Btn_background_color.UseVisualStyleBackColor = true;
            this.Btn_background_color.Click += new System.EventHandler(this.Btn_background_color_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color dialog control";
            // 
            // Btn_font
            // 
            this.Btn_font.Location = new System.Drawing.Point(132, 196);
            this.Btn_font.Name = "Btn_font";
            this.Btn_font.Size = new System.Drawing.Size(134, 80);
            this.Btn_font.TabIndex = 3;
            this.Btn_font.Text = "Font Control";
            this.Btn_font.UseVisualStyleBackColor = true;
            this.Btn_font.Click += new System.EventHandler(this.Btn_font_Click);
            // 
            // colour_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.Btn_font);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_background_color);
            this.Controls.Add(this.Btn_front_color);
            this.Name = "colour_dialog";
            this.Text = "colour_dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_front_color;
        private System.Windows.Forms.Button Btn_background_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_font;
    }
}