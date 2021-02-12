
namespace formMovie
{
    partial class Form1
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
            this.choice1 = new formMovie.choice();
            this.listMovies1 = new formMovie.ListMovies();
            this.SuspendLayout();
            // 
            // choice1
            // 
            this.choice1.Location = new System.Drawing.Point(275, 108);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(229, 217);
            this.choice1.TabIndex = 0;
            this.choice1.Load += new System.EventHandler(this.choice1_Load);
            // 
            // listMovies1
            // 
            this.listMovies1.Location = new System.Drawing.Point(-1, 0);
            this.listMovies1.Name = "listMovies1";
            this.listMovies1.Size = new System.Drawing.Size(882, 574);
            this.listMovies1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 574);
            this.Controls.Add(this.listMovies1);
            this.Controls.Add(this.choice1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private choice choice1;
        private ListMovies listMovies1;
    }
}

