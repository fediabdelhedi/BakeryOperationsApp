namespace GestionStock
{
    partial class Historique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historique));
            this.dgvBonEntree = new System.Windows.Forms.DataGridView();
            this.dataBonSortie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonEntree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBonSortie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBonEntree
            // 
            this.dgvBonEntree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBonEntree.Location = new System.Drawing.Point(12, 9);
            this.dgvBonEntree.Name = "dgvBonEntree";
            this.dgvBonEntree.ReadOnly = true;
            this.dgvBonEntree.Size = new System.Drawing.Size(543, 206);
            this.dgvBonEntree.TabIndex = 0;
            this.dgvBonEntree.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBonEntree_CellFormatting);
            // 
            // dataBonSortie
            // 
            this.dataBonSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBonSortie.Location = new System.Drawing.Point(12, 233);
            this.dataBonSortie.Name = "dataBonSortie";
            this.dataBonSortie.ReadOnly = true;
            this.dataBonSortie.Size = new System.Drawing.Size(543, 206);
            this.dataBonSortie.TabIndex = 1;
            this.dataBonSortie.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataBonSortie_CellFormatting);
            // 
            // Historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.dataBonSortie);
            this.Controls.Add(this.dgvBonEntree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Historique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historique";
            this.Load += new System.EventHandler(this.Historique_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBonEntree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBonSortie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBonEntree;
        private System.Windows.Forms.DataGridView dataBonSortie;
    }
}