namespace MyFirstVisualizer
{
    partial class ArrayVisualizerForm
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
            this.arrayDataGrid = new System.Windows.Forms.DataGridView();
            this.kdataCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // arrayDataGrid
            // 
            this.arrayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kdataCol});
            this.arrayDataGrid.Location = new System.Drawing.Point(0, 0);
            this.arrayDataGrid.Name = "arrayDataGrid";
            this.arrayDataGrid.RowHeadersWidth = 51;
            this.arrayDataGrid.RowTemplate.Height = 24;
            this.arrayDataGrid.Size = new System.Drawing.Size(240, 150);
            this.arrayDataGrid.TabIndex = 0;
            // 
            // kdataCol
            // 
            this.kdataCol.HeaderText = "Data";
            this.kdataCol.MinimumWidth = 6;
            this.kdataCol.Name = "kdataCol";
            this.kdataCol.Width = 125;
            // 
            // ArrayVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrayDataGrid);
            this.Name = "ArrayVisualizerForm";
            this.Text = "ArrayVisualizerForm";
            ((System.ComponentModel.ISupportInitialize)(this.arrayDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView arrayDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdataCol;
    }
}