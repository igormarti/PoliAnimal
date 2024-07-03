namespace PoliAnimal
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxSkills = new System.Windows.Forms.ListBox();
            this.panelHome = new System.Windows.Forms.Panel();
            this.btnDog = new System.Windows.Forms.Button();
            this.btnWhale = new System.Windows.Forms.Button();
            this.btnBird = new System.Windows.Forms.Button();
            this.panelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSkills
            // 
            this.listBoxSkills.FormattingEnabled = true;
            this.listBoxSkills.Location = new System.Drawing.Point(316, 179);
            this.listBoxSkills.Name = "listBoxSkills";
            this.listBoxSkills.Size = new System.Drawing.Size(234, 134);
            this.listBoxSkills.TabIndex = 1;
            this.listBoxSkills.SelectedIndexChanged += new System.EventHandler(this.listBoxSkills_SelectedIndexChanged);
            // 
            // panelHome
            // 
            this.panelHome.AutoSize = true;
            this.panelHome.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelHome.Controls.Add(this.btnDog);
            this.panelHome.Controls.Add(this.btnWhale);
            this.panelHome.Controls.Add(this.btnBird);
            this.panelHome.Controls.Add(this.listBoxSkills);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(800, 450);
            this.panelHome.TabIndex = 2;
            // 
            // btnDog
            // 
            this.btnDog.AccessibleName = "Dog Button";
            this.btnDog.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnDog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDog.BackgroundImage")));
            this.btnDog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDog.ForeColor = System.Drawing.Color.Red;
            this.btnDog.Location = new System.Drawing.Point(316, 16);
            this.btnDog.Name = "btnDog";
            this.btnDog.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDog.Size = new System.Drawing.Size(157, 139);
            this.btnDog.TabIndex = 4;
            this.btnDog.Text = "Dog";
            this.btnDog.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDog.UseVisualStyleBackColor = true;
            this.btnDog.Click += new System.EventHandler(this.btnDog_Click);
            // 
            // btnWhale
            // 
            this.btnWhale.AccessibleName = "Dog Button";
            this.btnWhale.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnWhale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWhale.BackgroundImage")));
            this.btnWhale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWhale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhale.ForeColor = System.Drawing.Color.Red;
            this.btnWhale.Location = new System.Drawing.Point(560, 16);
            this.btnWhale.Name = "btnWhale";
            this.btnWhale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnWhale.Size = new System.Drawing.Size(157, 139);
            this.btnWhale.TabIndex = 3;
            this.btnWhale.Text = "Whale";
            this.btnWhale.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnWhale.UseVisualStyleBackColor = true;
            this.btnWhale.Click += new System.EventHandler(this.btnWhale_Click);
            // 
            // btnBird
            // 
            this.btnBird.AccessibleName = "Dog Button";
            this.btnBird.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonMenu;
            this.btnBird.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBird.BackgroundImage")));
            this.btnBird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBird.ForeColor = System.Drawing.Color.Red;
            this.btnBird.Location = new System.Drawing.Point(68, 16);
            this.btnBird.Name = "btnBird";
            this.btnBird.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBird.Size = new System.Drawing.Size(157, 139);
            this.btnBird.TabIndex = 2;
            this.btnBird.Text = "Bird";
            this.btnBird.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBird.UseVisualStyleBackColor = true;
            this.btnBird.Click += new System.EventHandler(this.btnBird_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHome);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelHome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxSkills;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Button btnBird;
        private System.Windows.Forms.Button btnWhale;
        private System.Windows.Forms.Button btnDog;
    }
}

