namespace GestionStock
{
    partial class listeBonEntree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(listeBonEntree));
            this.lblPrixAchat = new System.Windows.Forms.Label();
            this.lblMatricule = new System.Windows.Forms.Label();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblKilometrage = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCoutUni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrixAchat = new System.Windows.Forms.TextBox();
            this.groupBoxProduit = new System.Windows.Forms.GroupBox();
            this.cbProduit = new System.Windows.Forms.ComboBox();
            this.txtQuantite = new System.Windows.Forms.TextBox();
            this.lstBonEntree = new System.Windows.Forms.ListBox();
            this.panel3.SuspendLayout();
            this.groupBoxProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrixAchat
            // 
            this.lblPrixAchat.AutoSize = true;
            this.lblPrixAchat.Location = new System.Drawing.Point(15, 236);
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
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(155, 24);
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
            // lblKilometrage
            // 
            this.lblKilometrage.AutoSize = true;
            this.lblKilometrage.Location = new System.Drawing.Point(15, 120);
            this.lblKilometrage.Name = "lblKilometrage";
            this.lblKilometrage.Size = new System.Drawing.Size(55, 13);
            this.lblKilometrage.TabIndex = 18;
            this.lblKilometrage.Text = "Quantite";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnFermer);
            this.panel3.Controls.Add(this.btnEnregistrer);
            this.panel3.Location = new System.Drawing.Point(304, 342);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 72);
            this.panel3.TabIndex = 15;
            // 
            // txtCoutUni
            // 
            this.txtCoutUni.Location = new System.Drawing.Point(156, 174);
            this.txtCoutUni.Name = "txtCoutUni";
            this.txtCoutUni.Size = new System.Drawing.Size(129, 20);
            this.txtCoutUni.TabIndex = 24;
            this.txtCoutUni.Leave += new System.EventHandler(this.txtCoutUni_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "cout unitaire Moyen";
            // 
            // txtPrixAchat
            // 
            this.txtPrixAchat.Location = new System.Drawing.Point(156, 232);
            this.txtPrixAchat.Name = "txtPrixAchat";
            this.txtPrixAchat.ReadOnly = true;
            this.txtPrixAchat.Size = new System.Drawing.Size(129, 20);
            this.txtPrixAchat.TabIndex = 22;
            // 
            // groupBoxProduit
            // 
            this.groupBoxProduit.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxProduit.Controls.Add(this.cbProduit);
            this.groupBoxProduit.Controls.Add(this.txtCoutUni);
            this.groupBoxProduit.Controls.Add(this.label1);
            this.groupBoxProduit.Controls.Add(this.txtPrixAchat);
            this.groupBoxProduit.Controls.Add(this.txtQuantite);
            this.groupBoxProduit.Controls.Add(this.lblPrixAchat);
            this.groupBoxProduit.Controls.Add(this.lblKilometrage);
            this.groupBoxProduit.Controls.Add(this.lblMatricule);
            this.groupBoxProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProduit.Location = new System.Drawing.Point(57, 37);
            this.groupBoxProduit.Name = "groupBoxProduit";
            this.groupBoxProduit.Size = new System.Drawing.Size(344, 288);
            this.groupBoxProduit.TabIndex = 16;
            this.groupBoxProduit.TabStop = false;
            this.groupBoxProduit.Text = "Caractéristiques d\'un bon d\'entrée";
            // 
            // cbProduit
            // 
            this.cbProduit.FormattingEnabled = true;
            this.cbProduit.Location = new System.Drawing.Point(156, 58);
            this.cbProduit.Name = "cbProduit";
            this.cbProduit.Size = new System.Drawing.Size(128, 21);
            this.cbProduit.TabIndex = 27;
            // 
            // txtQuantite
            // 
            this.txtQuantite.Location = new System.Drawing.Point(156, 116);
            this.txtQuantite.Name = "txtQuantite";
            this.txtQuantite.Size = new System.Drawing.Size(129, 20);
            this.txtQuantite.TabIndex = 21;
            // 
            // lstBonEntree
            // 
            this.lstBonEntree.FormattingEnabled = true;
            this.lstBonEntree.Location = new System.Drawing.Point(422, 37);
            this.lstBonEntree.Name = "lstBonEntree";
            this.lstBonEntree.Size = new System.Drawing.Size(442, 290);
            this.lstBonEntree.TabIndex = 17;
            // 
            // listeBonEntree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBoxProduit);
            this.Controls.Add(this.lstBonEntree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "listeBonEntree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "listeBonEntree";
            this.Load += new System.EventHandler(this.listeBonEntree_Load);
            this.panel3.ResumeLayout(false);
            this.groupBoxProduit.ResumeLayout(false);
            this.groupBoxProduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblPrixAchat;
        private System.Windows.Forms.Label lblMatricule;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblKilometrage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCoutUni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrixAchat;
        private System.Windows.Forms.GroupBox groupBoxProduit;
        private System.Windows.Forms.TextBox txtQuantite;
        private System.Windows.Forms.ListBox lstBonEntree;
        private System.Windows.Forms.ComboBox cbProduit;
    }
}