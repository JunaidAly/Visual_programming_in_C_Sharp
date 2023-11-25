
namespace Linq_to_Sql
{
    partial class Linq_form
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_save_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(555, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_save_data
            // 
            this.Btn_save_data.BackColor = System.Drawing.Color.Transparent;
            this.Btn_save_data.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_save_data.Location = new System.Drawing.Point(227, 312);
            this.Btn_save_data.Name = "Btn_save_data";
            this.Btn_save_data.Size = new System.Drawing.Size(116, 57);
            this.Btn_save_data.TabIndex = 1;
            this.Btn_save_data.Text = "Save Data";
            this.Btn_save_data.UseVisualStyleBackColor = false;
            this.Btn_save_data.Click += new System.EventHandler(this.Btn_save_data_Click);
            // 
            // Linq_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(579, 381);
            this.Controls.Add(this.Btn_save_data);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Linq_form";
            this.Text = "Data Display Form";
            this.Load += new System.EventHandler(this.Linq_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_save_data;
    }
}

