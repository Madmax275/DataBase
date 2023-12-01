namespace WindowsFormsApp2
{
    partial class DataWork
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
            this.tx1Post = new System.Windows.Forms.TextBox();
            this.tx2Indetificator = new System.Windows.Forms.TextBox();
            this.buttonload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tx1Post
            // 
            this.tx1Post.Location = new System.Drawing.Point(57, 82);
            this.tx1Post.Name = "tx1Post";
            this.tx1Post.Size = new System.Drawing.Size(100, 20);
            this.tx1Post.TabIndex = 1;
            // 
            // tx2Indetificator
            // 
            this.tx2Indetificator.Location = new System.Drawing.Point(57, 141);
            this.tx2Indetificator.Name = "tx2Indetificator";
            this.tx2Indetificator.Size = new System.Drawing.Size(100, 20);
            this.tx2Indetificator.TabIndex = 2;
            // 
            // buttonload
            // 
            this.buttonload.Location = new System.Drawing.Point(389, 289);
            this.buttonload.Name = "buttonload";
            this.buttonload.Size = new System.Drawing.Size(143, 23);
            this.buttonload.TabIndex = 4;
            this.buttonload.Text = "Загрузить данные";
            this.buttonload.UseVisualStyleBackColor = true;
            this.buttonload.Click += new System.EventHandler(this.buttonload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(47, 205);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(119, 23);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Записать данные";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // DataWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 535);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonload);
            this.Controls.Add(this.tx2Indetificator);
            this.Controls.Add(this.tx1Post);
            this.Name = "DataWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataWork";
            this.Load += new System.EventHandler(this.DataWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tx1Post;
        private System.Windows.Forms.TextBox tx2Indetificator;
        private System.Windows.Forms.Button buttonload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCreate;
    }
}