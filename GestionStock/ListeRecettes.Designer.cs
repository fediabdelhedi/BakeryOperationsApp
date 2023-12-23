namespace GestionDeStock
{
    partial class ListeRecettes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeRecettes));
            this.btnFermer = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lstProduits = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSuppPro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjoutProduit = new System.Windows.Forms.Button();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.txtQuantiteProduit = new System.Windows.Forms.TextBox();
            this.txtQuantiteProduite = new System.Windows.Forms.TextBox();
            this.txtRecette = new System.Windows.Forms.TextBox();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecette = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(311, 24);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(105, 25);
            this.btnFermer.TabIndex = 5;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Location = new System.Drawing.Point(187, 358);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 72);
            this.panel3.TabIndex = 13;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(165, 24);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(105, 25);
            this.btnSupprimer.TabIndex = 4;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
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
            // lstProduits
            // 
            this.lstProduits.FormattingEnabled = true;
            this.lstProduits.Location = new System.Drawing.Point(6, 205);
            this.lstProduits.Name = "lstProduits";
            this.lstProduits.Size = new System.Drawing.Size(332, 121);
            this.lstProduits.TabIndex = 28;
            this.lstProduits.SelectedIndexChanged += new System.EventHandler(this.lstProduits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Les ingredients de recette";
            // 
            // btnSuppPro
            // 
            this.btnSuppPro.Enabled = false;
            this.btnSuppPro.Location = new System.Drawing.Point(259, 171);
            this.btnSuppPro.Name = "btnSuppPro";
            this.btnSuppPro.Size = new System.Drawing.Size(76, 25);
            this.btnSuppPro.TabIndex = 7;
            this.btnSuppPro.Text = "Supprimer";
            this.btnSuppPro.UseVisualStyleBackColor = true;
            this.btnSuppPro.Click += new System.EventHandler(this.btnSuppPro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantite du produit";
            // 
            // btnAjoutProduit
            // 
            this.btnAjoutProduit.Location = new System.Drawing.Point(176, 171);
            this.btnAjoutProduit.Name = "btnAjoutProduit";
            this.btnAjoutProduit.Size = new System.Drawing.Size(76, 25);
            this.btnAjoutProduit.TabIndex = 6;
            this.btnAjoutProduit.Text = "Ajouter";
            this.btnAjoutProduit.UseVisualStyleBackColor = true;
            this.btnAjoutProduit.Click += new System.EventHandler(this.btnAjoutProduit_Click);
            // 
            // cbProduit
            // 
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(157, 98);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(129, 21);
            this.cbProduit.TabIndex = 25;
            // 
            // txtQuantiteProduit
            // 
            this.txtQuantiteProduit.Location = new System.Drawing.Point(157, 130);
            this.txtQuantiteProduit.Name = "txtQuantiteProduit";
            this.txtQuantiteProduit.Size = new System.Drawing.Size(128, 20);
            this.txtQuantiteProduit.TabIndex = 24;
            // 
            // txtQuantiteProduite
            // 
            this.txtQuantiteProduite.Location = new System.Drawing.Point(156, 65);
            this.txtQuantiteProduite.Name = "txtQuantiteProduite";
            this.txtQuantiteProduite.Size = new System.Drawing.Size(129, 20);
            this.txtQuantiteProduite.TabIndex = 21;
            // 
            // txtRecette
            // 
            this.txtRecette.Location = new System.Drawing.Point(157, 33);
            this.txtRecette.Name = "txtRecette";
            this.txtRecette.Size = new System.Drawing.Size(128, 20);
            this.txtRecette.TabIndex = 20;
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Location = new System.Drawing.Point(15, 69);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(105, 13);
            this.lblKilometrage.TabIndex = 18;
            this.lblKilometrage.Text = "Quantite produite";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(15, 37);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(52, 13);
            this.lblMatricule.TabIndex = 14;
            this.lblMatricule.Text = "Recette";
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxProduit.Controls.Add(this.lstProduits);
            this.groupBoxProduit.Controls.Add(this.label3);
            this.groupBoxProduit.Controls.Add(this.btnSuppPro);
            this.groupBoxProduit.Controls.Add(this.label2);
            this.groupBoxProduit.Controls.Add(this.btnAjoutProduit);
            this.groupBoxProduit.Controls.Add(this.cbProduit);
            this.groupBoxProduit.Controls.Add(this.txtQuantiteProduit);
            this.groupBoxProduit.Controls.Add(this.label1);
            this.groupBoxProduit.Controls.Add(this.txtQuantiteProduite);
            this.groupBoxProduit.Controls.Add(this.txtRecette);
            this.groupBoxProduit.Controls.Add(this.lblKilometrage);
            this.groupBoxProduit.Controls.Add(this.lblMatricule);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduit.Location = new System.Drawing.Point(59, 20);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(344, 332);
            this.groupBoxProduit.TabIndex = 14;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Caractéristiques d\'une recette";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Produit";
            // 
            // lstRecette
            // 
            this.lstRecette.FormattingEnabled = true;
            this.lstRecette.Location = new System.Drawing.Point(423, 20);
            this.lstRecette.Name = "lstRecette";
            this.lstRecette.Size = new System.Drawing.Size(319, 329);
            this.lstRecette.TabIndex = 15;
            this.lstRecette.SelectedIndexChanged += new System.EventHandler(this.lstRecette_SelectedIndexChanged);
            // 
            // ListeRecettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.lstRecette);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeRecettes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeRecettes";
            this.Load += new System.EventHandler(this.ListeRecettes_Load);
            this.panel3.ResumeLayout(false);
            this.groupBoxProduit.ResumeLayout(false);
            this.groupBoxProduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.ListBox lstProduits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSuppPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjoutProduit;
        private System.Windows.Forms.ComboBox cbProduit;
        private System.Windows.Forms.TextBox txtQuantiteProduit;
        private System.Windows.Forms.TextBox txtQuantiteProduite;
        private System.Windows.Forms.TextBox txtRecette;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRecette;
    }
}