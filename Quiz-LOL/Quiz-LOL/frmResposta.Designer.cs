namespace Quiz_LOL
{
    partial class frmResposta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResposta));
            this.lblPdl = new System.Windows.Forms.Label();
            this.lblPdlTotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblEloTotal = new System.Windows.Forms.Label();
            this.lblElo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPdl
            // 
            this.lblPdl.AutoSize = true;
            this.lblPdl.BackColor = System.Drawing.Color.Transparent;
            this.lblPdl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdl.ForeColor = System.Drawing.Color.White;
            this.lblPdl.Location = new System.Drawing.Point(272, 117);
            this.lblPdl.Name = "lblPdl";
            this.lblPdl.Size = new System.Drawing.Size(76, 39);
            this.lblPdl.TabIndex = 0;
            this.lblPdl.Text = "Pdl:";
            this.lblPdl.Visible = false;
            // 
            // lblPdlTotal
            // 
            this.lblPdlTotal.AutoSize = true;
            this.lblPdlTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblPdlTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdlTotal.ForeColor = System.Drawing.Color.White;
            this.lblPdlTotal.Location = new System.Drawing.Point(438, 117);
            this.lblPdlTotal.Name = "lblPdlTotal";
            this.lblPdlTotal.Size = new System.Drawing.Size(0, 39);
            this.lblPdlTotal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(480, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblEloTotal
            // 
            this.lblEloTotal.AutoSize = true;
            this.lblEloTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblEloTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEloTotal.ForeColor = System.Drawing.Color.White;
            this.lblEloTotal.Location = new System.Drawing.Point(438, 191);
            this.lblEloTotal.Name = "lblEloTotal";
            this.lblEloTotal.Size = new System.Drawing.Size(0, 39);
            this.lblEloTotal.TabIndex = 7;
            // 
            // lblElo
            // 
            this.lblElo.AutoSize = true;
            this.lblElo.BackColor = System.Drawing.Color.Transparent;
            this.lblElo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElo.ForeColor = System.Drawing.Color.White;
            this.lblElo.Location = new System.Drawing.Point(272, 191);
            this.lblElo.Name = "lblElo";
            this.lblElo.Size = new System.Drawing.Size(76, 39);
            this.lblElo.TabIndex = 6;
            this.lblElo.Text = "Elo:";
            this.lblElo.Visible = false;
            // 
            // frmResposta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_LOL.Properties.Resources.summoners_rift;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEloTotal);
            this.Controls.Add(this.lblElo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPdlTotal);
            this.Controls.Add(this.lblPdl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResposta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resposta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPdl;
        private System.Windows.Forms.Label lblPdlTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblEloTotal;
        private System.Windows.Forms.Label lblElo;
    }
}