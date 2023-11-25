
namespace Project
{
    partial class show_data
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_show_data = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(554, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_show_data
            // 
            this.Btn_show_data.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_show_data.Location = new System.Drawing.Point(99, 273);
            this.Btn_show_data.Name = "Btn_show_data";
            this.Btn_show_data.Size = new System.Drawing.Size(111, 59);
            this.Btn_show_data.TabIndex = 1;
            this.Btn_show_data.Text = "Show Data";
            this.Btn_show_data.UseVisualStyleBackColor = true;
            this.Btn_show_data.Click += new System.EventHandler(this.Btn_show_data_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_back.Location = new System.Drawing.Point(348, 273);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(115, 59);
            this.Btn_back.TabIndex = 2;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // show_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.stuffcontentmgrfiles20a2889156e4cbcb9bda9eed3192dadfcmiscshow_me_the_data;
            this.ClientSize = new System.Drawing.Size(549, 355);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_show_data);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show_data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show_data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_show_data;
        private System.Windows.Forms.Button Btn_back;
    }
}