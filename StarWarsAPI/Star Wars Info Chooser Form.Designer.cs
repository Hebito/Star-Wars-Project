
namespace StarWarsAPI
{
    partial class StarWarsHomeScreenForm
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
            this.btn_SelectPeople = new System.Windows.Forms.Button();
            this.btn_SelectPlanets = new System.Windows.Forms.Button();
            this.btn_SelectSpecies = new System.Windows.Forms.Button();
            this.label_Welcome = new System.Windows.Forms.Label();
            this.label_InformChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_SelectPeople
            // 
            this.btn_SelectPeople.Location = new System.Drawing.Point(658, 206);
            this.btn_SelectPeople.Name = "btn_SelectPeople";
            this.btn_SelectPeople.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectPeople.TabIndex = 0;
            this.btn_SelectPeople.Text = "People";
            this.btn_SelectPeople.UseVisualStyleBackColor = true;
            this.btn_SelectPeople.Click += new System.EventHandler(this.btn_SelectPeople_Click);
            // 
            // btn_SelectPlanets
            // 
            this.btn_SelectPlanets.Location = new System.Drawing.Point(368, 206);
            this.btn_SelectPlanets.Name = "btn_SelectPlanets";
            this.btn_SelectPlanets.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectPlanets.TabIndex = 1;
            this.btn_SelectPlanets.Text = "Planets";
            this.btn_SelectPlanets.UseVisualStyleBackColor = true;
            this.btn_SelectPlanets.Click += new System.EventHandler(this.btn_SelectPlanets_Click);
            // 
            // btn_SelectSpecies
            // 
            this.btn_SelectSpecies.Location = new System.Drawing.Point(98, 206);
            this.btn_SelectSpecies.Name = "btn_SelectSpecies";
            this.btn_SelectSpecies.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectSpecies.TabIndex = 2;
            this.btn_SelectSpecies.Text = "Species";
            this.btn_SelectSpecies.UseVisualStyleBackColor = true;
            this.btn_SelectSpecies.Click += new System.EventHandler(this.btn_SelectSpecies_Click);
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.Location = new System.Drawing.Point(30, 26);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(341, 23);
            this.label_Welcome.TabIndex = 4;
            this.label_Welcome.Text = "Welcome to the Star Wars Informer!";
            // 
            // label_InformChoose
            // 
            this.label_InformChoose.AutoSize = true;
            this.label_InformChoose.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InformChoose.Location = new System.Drawing.Point(196, 131);
            this.label_InformChoose.Name = "label_InformChoose";
            this.label_InformChoose.Size = new System.Drawing.Size(437, 23);
            this.label_InformChoose.TabIndex = 5;
            this.label_InformChoose.Text = "Please choose one of the following to search about:";
            // 
            // StarWarsHomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_InformChoose);
            this.Controls.Add(this.label_Welcome);
            this.Controls.Add(this.btn_SelectSpecies);
            this.Controls.Add(this.btn_SelectPlanets);
            this.Controls.Add(this.btn_SelectPeople);
            this.Name = "StarWarsHomeScreenForm";
            this.Text = "Star Wars Home Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelectPeople;
        private System.Windows.Forms.Button btn_SelectPlanets;
        private System.Windows.Forms.Button btn_SelectSpecies;
        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Label label_InformChoose;
    }
}