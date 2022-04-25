
namespace Qudditch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Draco = new System.Windows.Forms.PictureBox();
            this.Harry = new System.Windows.Forms.PictureBox();
            this.snitch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Draco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snitch)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Draco
            // 
            this.Draco.BackColor = System.Drawing.Color.Transparent;
            this.Draco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Draco.Image = global::Qudditch.Properties.Resources.draco1;
            this.Draco.Location = new System.Drawing.Point(723, 348);
            this.Draco.Name = "Draco";
            this.Draco.Size = new System.Drawing.Size(65, 90);
            this.Draco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Draco.TabIndex = 2;
            this.Draco.TabStop = false;
            this.Draco.Tag = "player";
            // 
            // Harry
            // 
            this.Harry.BackColor = System.Drawing.Color.Transparent;
            this.Harry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Harry.Image = global::Qudditch.Properties.Resources.harry1;
            this.Harry.Location = new System.Drawing.Point(13, 348);
            this.Harry.Name = "Harry";
            this.Harry.Size = new System.Drawing.Size(65, 90);
            this.Harry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Harry.TabIndex = 1;
            this.Harry.TabStop = false;
            this.Harry.Tag = "player";
            this.Harry.Click += new System.EventHandler(this.Harry_Click);
            // 
            // snitch
            // 
            this.snitch.BackColor = System.Drawing.Color.Transparent;
            this.snitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snitch.Image = global::Qudditch.Properties.Resources.snitch2;
            this.snitch.Location = new System.Drawing.Point(376, 12);
            this.snitch.Name = "snitch";
            this.snitch.Size = new System.Drawing.Size(29, 16);
            this.snitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.snitch.TabIndex = 0;
            this.snitch.TabStop = false;
            this.snitch.Tag = "snitch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Draco);
            this.Controls.Add(this.Harry);
            this.Controls.Add(this.snitch);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Qudditch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Draco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Harry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snitch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox snitch;
        private System.Windows.Forms.PictureBox Harry;
        private System.Windows.Forms.PictureBox Draco;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

