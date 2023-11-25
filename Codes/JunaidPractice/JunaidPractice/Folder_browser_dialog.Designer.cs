
namespace JunaidPractice
{
    partial class Folder_browser_dialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_load = new System.Windows.Forms.Button();
            this.Btn_show = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Browser Dialog";
            // 
            // Btn_load
            // 
            this.Btn_load.Location = new System.Drawing.Point(294, 105);
            this.Btn_load.Name = "Btn_load";
            this.Btn_load.Size = new System.Drawing.Size(88, 31);
            this.Btn_load.TabIndex = 1;
            this.Btn_load.Text = "Load Image";
            this.Btn_load.UseVisualStyleBackColor = true;
            this.Btn_load.Click += new System.EventHandler(this.Btn_load_Click);
            // 
            // Btn_show
            // 
            this.Btn_show.Location = new System.Drawing.Point(294, 151);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(88, 32);
            this.Btn_show.TabIndex = 2;
            this.Btn_show.Text = "Show Image";
            this.Btn_show.UseVisualStyleBackColor = true;
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(59, 105);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 184);
            this.listBox1.TabIndex = 4;
            // 
            // Folder_browser_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 315);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.Btn_load);
            this.Controls.Add(this.label1);
            this.Name = "Folder_browser_dialog";
            this.Text = "Folder_browser_dialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_load;
        private System.Windows.Forms.Button Btn_show;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}