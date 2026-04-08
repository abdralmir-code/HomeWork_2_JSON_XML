namespace Symphony_Orchestra
{
    partial class SymphonyForm
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
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Дирижёр");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Музыкант");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Инструмент");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Сущности", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.essence = new System.Windows.Forms.TreeView();
            this.orchestraGrid = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer_1 = new System.Windows.Forms.SplitContainer();
            this.button_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orchestraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_1)).BeginInit();
            this.splitContainer_1.Panel1.SuspendLayout();
            this.splitContainer_1.Panel2.SuspendLayout();
            this.splitContainer_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // essence
            // 
            this.essence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.essence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.essence.Location = new System.Drawing.Point(3, 193);
            this.essence.Name = "essence";
            treeNode17.Name = "Дирижёр";
            treeNode17.Text = "Дирижёр";
            treeNode18.Name = "Музыкант";
            treeNode18.Text = "Музыкант";
            treeNode19.Name = "Инструмент";
            treeNode19.Text = "Инструмент";
            treeNode20.Name = "Сущности";
            treeNode20.Text = "Сущности";
            this.essence.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.essence.Size = new System.Drawing.Size(239, 160);
            this.essence.TabIndex = 0;
            this.essence.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.essence_AfterSelect);
            // 
            // orchestraGrid
            // 
            this.orchestraGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orchestraGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.orchestraGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orchestraGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.orchestraGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orchestraGrid.DefaultCellStyle = dataGridViewCellStyle10;
            this.orchestraGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orchestraGrid.Location = new System.Drawing.Point(0, 0);
            this.orchestraGrid.Name = "orchestraGrid";
            this.orchestraGrid.RowHeadersWidth = 51;
            this.orchestraGrid.RowTemplate.Height = 24;
            this.orchestraGrid.Size = new System.Drawing.Size(898, 603);
            this.orchestraGrid.TabIndex = 1;
            this.orchestraGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orchestraGrid_CellDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Symphony_Orchestra.Properties.Resources.Tree;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer_1
            // 
            this.splitContainer_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_1.Name = "splitContainer_1";
            // 
            // splitContainer_1.Panel1
            // 
            this.splitContainer_1.Panel1.Controls.Add(this.button_load);
            this.splitContainer_1.Panel1.Controls.Add(this.essence);
            this.splitContainer_1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer_1.Panel2
            // 
            this.splitContainer_1.Panel2.Controls.Add(this.orchestraGrid);
            this.splitContainer_1.Size = new System.Drawing.Size(1182, 603);
            this.splitContainer_1.SplitterDistance = 280;
            this.splitContainer_1.TabIndex = 3;
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(204)))));
            this.button_load.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.button_load.Location = new System.Drawing.Point(3, 378);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(239, 73);
            this.button_load.TabIndex = 3;
            this.button_load.Text = "Загрузить";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // SymphonyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1182, 603);
            this.Controls.Add(this.splitContainer_1);
            this.Name = "SymphonyForm";
            this.Text = "SymphonyForm";
            ((System.ComponentModel.ISupportInitialize)(this.orchestraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer_1.Panel1.ResumeLayout(false);
            this.splitContainer_1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_1)).EndInit();
            this.splitContainer_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView essence;
        private System.Windows.Forms.DataGridView orchestraGrid;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer_1;
        private System.Windows.Forms.Button button_load;
    }
}