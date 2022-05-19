namespace Quiz_LOL
{
    partial class frmQuest2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuest2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResposta3 = new System.Windows.Forms.Button();
            this.btnResposta2 = new System.Windows.Forms.Button();
            this.btnResposta1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quiz_LOL.Properties.Resources.Yone;
            this.pictureBox1.Location = new System.Drawing.Point(121, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(559, 339);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnResposta3
            // 
            this.btnResposta3.Location = new System.Drawing.Point(580, 390);
            this.btnResposta3.Name = "btnResposta3";
            this.btnResposta3.Size = new System.Drawing.Size(100, 50);
            this.btnResposta3.TabIndex = 8;
            this.btnResposta3.Text = "Yasuo";
            this.btnResposta3.UseVisualStyleBackColor = true;
            this.btnResposta3.Click += new System.EventHandler(this.btnResposta3_Click);
            // 
            // btnResposta2
            // 
            this.btnResposta2.Location = new System.Drawing.Point(357, 390);
            this.btnResposta2.Name = "btnResposta2";
            this.btnResposta2.Size = new System.Drawing.Size(100, 50);
            this.btnResposta2.TabIndex = 7;
            this.btnResposta2.Text = "Yone";
            this.btnResposta2.UseVisualStyleBackColor = true;
            this.btnResposta2.Click += new System.EventHandler(this.btnResposta2_Click);
            // 
            // btnResposta1
            // 
            this.btnResposta1.Location = new System.Drawing.Point(121, 390);
            this.btnResposta1.Name = "btnResposta1";
            this.btnResposta1.Size = new System.Drawing.Size(100, 50);
            this.btnResposta1.TabIndex = 6;
            this.btnResposta1.Text = "Zed";
            this.btnResposta1.UseVisualStyleBackColor = true;
            this.btnResposta1.Click += new System.EventHandler(this.btnResposta1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(220, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Qual o nome deste campeão?";
            // 
            // frmQuest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_LOL.Properties.Resources.summoners_rift;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResposta3);
            this.Controls.Add(this.btnResposta2);
            this.Controls.Add(this.btnResposta1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQuest2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta 2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResposta3;
        private System.Windows.Forms.Button btnResposta2;
        private System.Windows.Forms.Button btnResposta1;
        private System.Windows.Forms.Label label1;
    }
}