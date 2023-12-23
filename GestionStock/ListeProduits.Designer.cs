namespace GestionDeStock
{
    partial class ListeProduits
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeProduits));
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtQuantiteMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCoutUni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.txtProduit = new System.Windows.Forms.TextBox();
            this.lblPrixAchat = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.lstProduit = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            this.SuspendLayout();
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
            // txtQuantiteMin
            // 
            this.txtQuantiteMin.Location = new System.Drawing.Point(156, 190);
            this.txtQuantiteMin.Name = "txtQuantiteMin";
            this.txtQuantiteMin.Size = new System.Drawing.Size(129, 20);
            this.txtQuantiteMin.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quantite Minimum";
            // 
            // txtCoutUni
            // 
            this.txtCoutUni.Location = new System.Drawing.Point(156, 146);
            this.txtCoutUni.Name = "txtCoutUni";
            this.txtCoutUni.Size = new System.Drawing.Size(129, 20);
            this.txtCoutUni.TabIndex = 24;
            this.txtCoutUni.Leave += new System.EventHandler(this.txtCoutUni_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "cout unitaire Moyen";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(156, 234);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.ReadOnly = true;
            this.txtPrixAchat.Size = new System.Drawing.Size(129, 20);
            this.txtPrixAchat.TabIndex = 22;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(156, 102);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(129, 20);
            this.txtQuantite.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSupprimer);
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Location = new System.Drawing.Point(201, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(442, 72);
            this.panel3.TabIndex = 11;
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
            // txtProduit
            // 
            this.txtProduit.Location = new System.Drawing.Point(157, 58);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(128, 20);
            this.txtProduit.TabIndex = 20;
            // 
            // lblPrixAchat
            // 
            this.lblPrixAchat.AutoSize = true;
            this.lblPrixAchat.Location = new System.Drawing.Point(15, 238);
            this.lblPrixAchat.Name = "lblPrixAchat";
            this.lblPrixAchat.Size = new System.Drawing.Size(61, 13);
            this.lblPrixAchat.TabIndex = 19;
            this.lblPrixAchat.Text = "cout total";
            // 
            // lblMatricule
            // 
            this.lblMatricule.AutoSize = true;
            this.lblMatricule.Location = new System.Drawing.Point(15, 62);
            this.lblMatricule.Name = "lblMatricule";
            this.lblMatricule.Size = new System.Drawing.Size(47, 13);
            this.lblMatricule.TabIndex = 14;
            this.lblMatricule.Text = "Produit";
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxProduit.Controls.Add(this.txtQuantiteMin);
            this.groupBoxProduit.Controls.Add(this.label2);
            this.groupBoxProduit.Controls.Add(this.txtCoutUni);
            this.groupBoxProduit.Controls.Add(this.label1);
            this.groupBoxProduit.Controls.Add(this.txtPrixAchat);
            this.groupBoxProduit.Controls.Add(this.txtQuantite);
            this.groupBoxProduit.Controls.Add(this.txtProduit);
            this.groupBoxProduit.Controls.Add(this.lblPrixAchat);
            this.groupBoxProduit.Controls.Add(this.lblKilometrage);
            this.groupBoxProduit.Controls.Add(this.lblMatricule);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduit.Location = new System.Drawing.Point(73, 37);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(344, 288);
            this.groupBoxProduit.TabIndex = 12;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Caractéristiques d\'un produit";
            // 
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Location = new System.Drawing.Point(15, 106);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(55, 13);
            this.lblKilometrage.TabIndex = 18;
            this.lblKilometrage.Text = "Quantite";
            // 
            // lstProduit
            // 
            this.lstProduit.FormattingEnabled = true;
            this.lstProduit.Location = new System.Drawing.Point(437, 37);
            this.lstProduit.Name = "lstProduit";
            this.lstProduit.Size = new System.Drawing.Size(319, 290);
            this.lstProduit.TabIndex = 13;
            this.lstProduit.SelectedIndexChanged += new System.EventHandler(this.lstProduit_SelectedIndexChanged);
            // 
            // ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.lstProduit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeProduits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liste des produits";
            this.Load += new System.EventHandler(this.ListeProduits_Load);
            this.panel3.ResumeLayout(false);
            this.groupBoxProduit.ResumeLayout(false);
            this.groupBoxProduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtQuantiteMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoutUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.TextBox txtProduit;
        private System.Windows.Forms.Label lblPrixAchat;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.ListBox lstProduit;
    }
}

