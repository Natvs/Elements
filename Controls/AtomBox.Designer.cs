namespace Elements.Controls
{
    partial class AtomBox
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.molarMassLabel = new System.Windows.Forms.Label();
            this.massesNumberLabel = new System.Windows.Forms.Label();
            this.electronegativityLabel = new System.Windows.Forms.Label();
            this.symbolLabel = new System.Windows.Forms.Label();
            this.atomicNumberLabel = new System.Windows.Forms.Label();
            this.mainLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.Controls.Add(this.molarMassLabel, 2, 2);
            this.mainLayoutPanel.Controls.Add(this.massesNumberLabel, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.electronegativityLabel, 2, 0);
            this.mainLayoutPanel.Controls.Add(this.symbolLabel, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.atomicNumberLabel, 0, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(175, 175);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // molarMassLabel
            // 
            this.molarMassLabel.AutoSize = true;
            this.molarMassLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.molarMassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.molarMassLabel.ForeColor = System.Drawing.Color.Purple;
            this.molarMassLabel.Location = new System.Drawing.Point(130, 130);
            this.molarMassLabel.Margin = new System.Windows.Forms.Padding(0);
            this.molarMassLabel.Name = "molarMassLabel";
            this.molarMassLabel.Size = new System.Drawing.Size(45, 45);
            this.molarMassLabel.TabIndex = 8;
            this.molarMassLabel.Text = "M";
            this.molarMassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // massesNumberLabel
            // 
            this.massesNumberLabel.AutoSize = true;
            this.massesNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.massesNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.massesNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.massesNumberLabel.Location = new System.Drawing.Point(0, 130);
            this.massesNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.massesNumberLabel.Name = "massesNumberLabel";
            this.massesNumberLabel.Size = new System.Drawing.Size(43, 45);
            this.massesNumberLabel.TabIndex = 6;
            this.massesNumberLabel.Text = "Z";
            this.massesNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // electronegativityLabel
            // 
            this.electronegativityLabel.AutoSize = true;
            this.electronegativityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.electronegativityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electronegativityLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.electronegativityLabel.Location = new System.Drawing.Point(130, 0);
            this.electronegativityLabel.Margin = new System.Windows.Forms.Padding(0);
            this.electronegativityLabel.Name = "electronegativityLabel";
            this.electronegativityLabel.Size = new System.Drawing.Size(45, 43);
            this.electronegativityLabel.TabIndex = 3;
            this.electronegativityLabel.Text = "EN";
            this.electronegativityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // symbolLabel
            // 
            this.symbolLabel.AutoSize = true;
            this.symbolLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.symbolLabel.Font = new System.Drawing.Font("Agency FB", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.symbolLabel.Location = new System.Drawing.Point(43, 43);
            this.symbolLabel.Margin = new System.Windows.Forms.Padding(0);
            this.symbolLabel.Name = "symbolLabel";
            this.symbolLabel.Size = new System.Drawing.Size(87, 87);
            this.symbolLabel.TabIndex = 0;
            this.symbolLabel.Text = "Xxx";
            this.symbolLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atomicNumberLabel
            // 
            this.atomicNumberLabel.AutoSize = true;
            this.atomicNumberLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.atomicNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atomicNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.atomicNumberLabel.Location = new System.Drawing.Point(0, 0);
            this.atomicNumberLabel.Margin = new System.Windows.Forms.Padding(0);
            this.atomicNumberLabel.Name = "atomicNumberLabel";
            this.atomicNumberLabel.Size = new System.Drawing.Size(43, 43);
            this.atomicNumberLabel.TabIndex = 1;
            this.atomicNumberLabel.Text = "A";
            this.atomicNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Atom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "Atom";
            this.Size = new System.Drawing.Size(175, 175);
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.Label symbolLabel;
        private System.Windows.Forms.Label atomicNumberLabel;
        private System.Windows.Forms.Label molarMassLabel;
        private System.Windows.Forms.Label massesNumberLabel;
        private System.Windows.Forms.Label electronegativityLabel;
    }
}
