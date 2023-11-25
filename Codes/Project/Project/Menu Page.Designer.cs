
namespace Project
{
    partial class Menu_Page
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
            this.Btn_apply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_apply
            // 
            this.Btn_apply.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_apply.Location = new System.Drawing.Point(276, 40);
            this.Btn_apply.Name = "Btn_apply";
            this.Btn_apply.Size = new System.Drawing.Size(155, 57);
            this.Btn_apply.TabIndex = 0;
            this.Btn_apply.Text = "Apply For Contract";
            this.Btn_apply.UseVisualStyleBackColor = true;
            this.Btn_apply.Click += new System.EventHandler(this.Btn_apply_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(277, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel Contract";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(277, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "Search For Contract";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Exit.Location = new System.Drawing.Point(276, 298);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(155, 61);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Display
            // 
            this.Btn_Display.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Display.Location = new System.Drawing.Point(277, 103);
            this.Btn_Display.Name = "Btn_Display";
            this.Btn_Display.Size = new System.Drawing.Size(155, 57);
            this.Btn_Display.TabIndex = 4;
            this.Btn_Display.Text = "Display Contract Details";
            this.Btn_Display.UseVisualStyleBackColor = true;
            this.Btn_Display.Click += new System.EventHandler(this.Btn_Display_Click);
            // 
            // Menu_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources._31939145c822e707b6a4b5d5ec26086e;
            this.ClientSize = new System.Drawing.Size(714, 397);
            this.Controls.Add(this.Btn_Display);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Btn_apply);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_apply;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Display;
    }
}