namespace Atesat_v._1._1
{
    partial class frmSnake
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lbMonedeObt = new System.Windows.Forms.Label();
            this.lbMonedeTot = new System.Windows.Forms.Label();
            this.pbOk = new System.Windows.Forms.PictureBox();
            this.pbMess = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scor:";
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(85, 20);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(24, 24);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "0";
            // 
            // lbMonedeObt
            // 
            this.lbMonedeObt.AutoSize = true;
            this.lbMonedeObt.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonedeObt.Location = new System.Drawing.Point(139, 180);
            this.lbMonedeObt.Name = "lbMonedeObt";
            this.lbMonedeObt.Size = new System.Drawing.Size(296, 21);
            this.lbMonedeObt.TabIndex = 5;
            this.lbMonedeObt.Text = "Ati pierdut, obtinand:";
            this.lbMonedeObt.Visible = false;
            // 
            // lbMonedeTot
            // 
            this.lbMonedeTot.AutoSize = true;
            this.lbMonedeTot.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonedeTot.Location = new System.Drawing.Point(139, 204);
            this.lbMonedeTot.Name = "lbMonedeTot";
            this.lbMonedeTot.Size = new System.Drawing.Size(296, 21);
            this.lbMonedeTot.TabIndex = 7;
            this.lbMonedeTot.Text = "Noul numar de jetoane:";
            this.lbMonedeTot.Visible = false;
            // 
            // pbOk
            // 
            this.pbOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOk.Image = global::Atesat_v._1._1.Properties.Resources.ok;
            this.pbOk.Location = new System.Drawing.Point(130, 237);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(48, 36);
            this.pbOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbOk.TabIndex = 8;
            this.pbOk.TabStop = false;
            this.pbOk.Visible = false;
            this.pbOk.Click += new System.EventHandler(this.pbOk_Click);
            // 
            // pbMess
            // 
            this.pbMess.Image = global::Atesat_v._1._1.Properties.Resources.spaceesc;
            this.pbMess.Location = new System.Drawing.Point(143, 195);
            this.pbMess.Name = "pbMess";
            this.pbMess.Size = new System.Drawing.Size(285, 58);
            this.pbMess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMess.TabIndex = 9;
            this.pbMess.TabStop = false;
            this.pbMess.Visible = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Location = new System.Drawing.Point(12, 53);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(565, 435);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(589, 500);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMess);
            this.Controls.Add(this.lbMonedeTot);
            this.Controls.Add(this.lbMonedeObt);
            this.Controls.Add(this.pbCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmSnake";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbMonedeObt;
        private System.Windows.Forms.Label lbMonedeTot;
        private System.Windows.Forms.PictureBox pbOk;
        private System.Windows.Forms.PictureBox pbMess;
    }
}