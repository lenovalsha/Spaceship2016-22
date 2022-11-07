namespace Spaceship2016
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.btnFighter = new System.Windows.Forms.Button();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnReloadPhoton = new System.Windows.Forms.Button();
            this.btnReloadCargo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add a spaceship";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFighter
            // 
            this.btnFighter.Location = new System.Drawing.Point(181, 12);
            this.btnFighter.Name = "btnFighter";
            this.btnFighter.Size = new System.Drawing.Size(171, 23);
            this.btnFighter.TabIndex = 1;
            this.btnFighter.Text = "Add FighterShip";
            this.btnFighter.UseVisualStyleBackColor = true;
            this.btnFighter.Click += new System.EventHandler(this.btnFighter_Click);
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(349, 12);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(171, 23);
            this.btnCargo.TabIndex = 2;
            this.btnCargo.Text = "Add FighterShip";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnHealth
            // 
            this.btnHealth.Location = new System.Drawing.Point(12, 41);
            this.btnHealth.Name = "btnHealth";
            this.btnHealth.Size = new System.Drawing.Size(171, 23);
            this.btnHealth.TabIndex = 3;
            this.btnHealth.Text = "Health = 100";
            this.btnHealth.UseVisualStyleBackColor = true;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnReloadPhoton
            // 
            this.btnReloadPhoton.Location = new System.Drawing.Point(181, 41);
            this.btnReloadPhoton.Name = "btnReloadPhoton";
            this.btnReloadPhoton.Size = new System.Drawing.Size(171, 23);
            this.btnReloadPhoton.TabIndex = 4;
            this.btnReloadPhoton.Text = "Reload Photon";
            this.btnReloadPhoton.UseVisualStyleBackColor = true;
            this.btnReloadPhoton.Click += new System.EventHandler(this.btnReloadPhoton_Click);
            // 
            // btnReloadCargo
            // 
            this.btnReloadCargo.Location = new System.Drawing.Point(349, 41);
            this.btnReloadCargo.Name = "btnReloadCargo";
            this.btnReloadCargo.Size = new System.Drawing.Size(171, 23);
            this.btnReloadCargo.TabIndex = 5;
            this.btnReloadCargo.Text = "Reload Cargo";
            this.btnReloadCargo.UseVisualStyleBackColor = true;
            this.btnReloadCargo.Click += new System.EventHandler(this.btnReloadCargo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 530);
            this.Controls.Add(this.btnReloadCargo);
            this.Controls.Add(this.btnReloadPhoton);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnFighter);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFighter;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnReloadPhoton;
        private System.Windows.Forms.Button btnReloadCargo;
    }
}

