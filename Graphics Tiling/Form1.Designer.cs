namespace Graphics_Tiling
{
    partial class frmTiling1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTiling1));
            this.btnDrawTiles = new System.Windows.Forms.Button();
            this.Walter = new System.Windows.Forms.PictureBox();
            this.Gras = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Walter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDrawTiles
            // 
            this.btnDrawTiles.Location = new System.Drawing.Point(12, 399);
            this.btnDrawTiles.Name = "btnDrawTiles";
            this.btnDrawTiles.Size = new System.Drawing.Size(117, 39);
            this.btnDrawTiles.TabIndex = 0;
            this.btnDrawTiles.Text = "Draw Tiles";
            this.btnDrawTiles.UseVisualStyleBackColor = true;
            this.btnDrawTiles.Click += new System.EventHandler(this.btnDrawTiles_Click);
            // 
            // Walter
            // 
            this.Walter.Image = ((System.Drawing.Image)(resources.GetObject("Walter.Image")));
            this.Walter.Location = new System.Drawing.Point(50, 361);
            this.Walter.Name = "Walter";
            this.Walter.Size = new System.Drawing.Size(32, 32);
            this.Walter.TabIndex = 1;
            this.Walter.TabStop = false;
            // 
            // Gras
            // 
            this.Gras.Image = ((System.Drawing.Image)(resources.GetObject("Gras.Image")));
            this.Gras.Location = new System.Drawing.Point(12, 361);
            this.Gras.Name = "Gras";
            this.Gras.Size = new System.Drawing.Size(32, 32);
            this.Gras.TabIndex = 2;
            this.Gras.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(135, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 39);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(257, 399);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(116, 39);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmTiling1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 444);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Gras);
            this.Controls.Add(this.Walter);
            this.Controls.Add(this.btnDrawTiles);
            this.Name = "frmTiling1";
            this.Text = "TILES!";
            this.Load += new System.EventHandler(this.frmTiling1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTiling1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.Walter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDrawTiles;
        private System.Windows.Forms.PictureBox Walter;
        private System.Windows.Forms.PictureBox Gras;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

