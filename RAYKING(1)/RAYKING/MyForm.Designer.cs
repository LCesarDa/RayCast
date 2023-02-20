namespace RAYKING
{
    partial class MyForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PNL_MAIN = new System.Windows.Forms.Panel();
            this.PCT_VIEW = new System.Windows.Forms.PictureBox();
            this.PCT_SCENE = new System.Windows.Forms.PictureBox();
            this.LBL_STATUS = new System.Windows.Forms.Label();
            this.PNL_TOP = new System.Windows.Forms.Panel();
            this.TIMER = new System.Windows.Forms.Timer(this.components);
            this.LBL_FPS = new System.Windows.Forms.Label();
            this.PNL_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_VIEW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SCENE)).BeginInit();
            this.PNL_TOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MAIN
            // 
            this.PNL_MAIN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PNL_MAIN.Controls.Add(this.PCT_VIEW);
            this.PNL_MAIN.Controls.Add(this.PCT_SCENE);
            this.PNL_MAIN.Location = new System.Drawing.Point(64, 99);
            this.PNL_MAIN.Name = "PNL_MAIN";
            this.PNL_MAIN.Size = new System.Drawing.Size(1078, 462);
            this.PNL_MAIN.TabIndex = 0;
            // 
            // PCT_VIEW
            // 
            this.PCT_VIEW.BackColor = System.Drawing.Color.Black;
            this.PCT_VIEW.Location = new System.Drawing.Point(465, 77);
            this.PCT_VIEW.Name = "PCT_VIEW";
            this.PCT_VIEW.Size = new System.Drawing.Size(600, 300);
            this.PCT_VIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCT_VIEW.TabIndex = 3;
            this.PCT_VIEW.TabStop = false;
            // 
            // PCT_SCENE
            // 
            this.PCT_SCENE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.PCT_SCENE.Location = new System.Drawing.Point(9, 6);
            this.PCT_SCENE.Name = "PCT_SCENE";
            this.PCT_SCENE.Size = new System.Drawing.Size(450, 450);
            this.PCT_SCENE.TabIndex = 2;
            this.PCT_SCENE.TabStop = false;
            this.PCT_SCENE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_SCENE_MouseMove);
            // 
            // LBL_STATUS
            // 
            this.LBL_STATUS.AutoSize = true;
            this.LBL_STATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_STATUS.Location = new System.Drawing.Point(12, 9);
            this.LBL_STATUS.Name = "LBL_STATUS";
            this.LBL_STATUS.Size = new System.Drawing.Size(121, 25);
            this.LBL_STATUS.TabIndex = 1;
            this.LBL_STATUS.Text = "WELCOME";
            // 
            // PNL_TOP
            // 
            this.PNL_TOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PNL_TOP.Controls.Add(this.LBL_STATUS);
            this.PNL_TOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_TOP.Location = new System.Drawing.Point(0, 0);
            this.PNL_TOP.Name = "PNL_TOP";
            this.PNL_TOP.Size = new System.Drawing.Size(1204, 44);
            this.PNL_TOP.TabIndex = 2;
            // 
            // TIMER
            // 
            this.TIMER.Enabled = true;
            this.TIMER.Interval = 40;
            this.TIMER.Tick += new System.EventHandler(this.TIMER_Tick);
            // 
            // LBL_FPS
            // 
            this.LBL_FPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LBL_FPS.AutoSize = true;
            this.LBL_FPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_FPS.Location = new System.Drawing.Point(765, 577);
            this.LBL_FPS.Name = "LBL_FPS";
            this.LBL_FPS.Size = new System.Drawing.Size(53, 25);
            this.LBL_FPS.TabIndex = 2;
            this.LBL_FPS.Text = "FPS";
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1204, 659);
            this.Controls.Add(this.LBL_FPS);
            this.Controls.Add(this.PNL_TOP);
            this.Controls.Add(this.PNL_MAIN);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.Name = "MyForm";
            this.Text = "Form1";
            this.PNL_MAIN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_VIEW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_SCENE)).EndInit();
            this.PNL_TOP.ResumeLayout(false);
            this.PNL_TOP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MAIN;
        private System.Windows.Forms.PictureBox PCT_VIEW;
        private System.Windows.Forms.PictureBox PCT_SCENE;
        private System.Windows.Forms.Label LBL_STATUS;
        private System.Windows.Forms.Panel PNL_TOP;
        private System.Windows.Forms.Timer TIMER;
        private System.Windows.Forms.Label LBL_FPS;
    }
}

