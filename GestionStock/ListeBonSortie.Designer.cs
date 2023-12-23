namespace GestionStock
{
    partial class ListeBonSortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeBonSortie));
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.lstProduits = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRecette = new System.Windows.Forms.ComboBox();
            this.txtQuantiteProduite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstBonSortie = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.groupBoxProduit.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxProduit.Controls.Add(this.lstProduits);
            this.groupBoxProduit.Controls.Add(this.label3);
            this.groupBoxProduit.Controls.Add(this.label2);
            this.groupBoxProduit.Controls.Add(this.cbRecette);
            this.groupBoxProduit.Controls.Add(this.txtQuantiteProduite);
            this.groupBoxProduit.Controls.Add(this.label1);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduit.Location = new System.Drawing.Point(73, 20);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(344, 332);
            this.groupBoxProduit.TabIndex = 18;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Caractéristiques d\'un bon de sortie";
            // 
            // lstProduits
            // 
            this.lstProduits.FormattingEnabled = true;
            this.lstProduits.Location = new System.Drawing.Point(6, 166);
            this.lstProduits.Name = "lstProduits";
            this.lstProduits.Size = new System.Drawing.Size(332, 160);
            this.lstProduits.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Les ingredients de recette:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantite produite";
            // 
            // cbRecette
            // 
            this.cbRecette.FormattingEnabled = true;
            this.cbRecette.Location = new System.Drawing.Point(157, 44);
            this.cbRecette.Name = "cbRecette";
            this.cbRecette.Size = new System.Drawing.Size(129, 21);
            this.cbRecette.TabIndex = 25;
            this.cbRecette.SelectedIndexChanged += new System.EventHandler(this.cbRecette_SelectedIndexChanged);
            // 
            // txtQuantiteProduite
            // 
            this.txtQuantiteProduite.Location = new System.Drawing.Point(157, 84);
            this.txtQuantiteProduite.Name = "txtQuantiteProduite";
            this.txtQuantiteProduite.Size = new System.Drawing.Size(128, 20);
            this.txtQuantiteProduite.TabIndex = 24;
            this.txtQuantiteProduite.TextChanged += new System.EventHandler(this.txtQuantiteProduite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Recette";
            // 
            // lstBonSortie
            // 
            this.lstBonSortie.FormattingEnabled = true;
            this.lstBonSortie.Location = new System.Drawing.Point(437, 20);
            this.lstBonSortie.Name = "lstBonSortie";
            this.lstBonSortie.Size = new System.Drawing.Size(422, 329);
            this.lstBonSortie.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Location = new System.Drawing.Point(298, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 72);
            this.panel3.TabIndex = 17;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(144, 24);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(105, 25);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(22, 24);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(105, 25);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // ListeBonSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.lstBonSortie);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeBonSortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeBonSortie";
            this.Load += new System.EventHandler(this.ListeBonSortie_Load);
            this.groupBoxProduit.ResumeLayout(false);
            this.groupBoxProduit.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRecette;
        private System.Windows.Forms.TextBox txtQuantiteProduite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBonSortie;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}