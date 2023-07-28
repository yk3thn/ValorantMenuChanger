namespace ValorantMenuChanger
{
    partial class ValorantMenuChanger
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorantMenuChanger));
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            gamepath = new Label();
            vidpath = new Label();
            status = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.title;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.file;
            pictureBox3.Location = new Point(12, 139);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 139);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 3;
            label1.Text = "Game Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 216);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Video Path:";
            // 
            // gamepath
            // 
            gamepath.AutoSize = true;
            gamepath.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gamepath.ForeColor = Color.White;
            gamepath.Location = new Point(198, 139);
            gamepath.Name = "gamepath";
            gamepath.Size = new Size(35, 15);
            gamepath.TabIndex = 5;
            gamepath.Text = "null";
            // 
            // vidpath
            // 
            vidpath.AutoSize = true;
            vidpath.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            vidpath.ForeColor = Color.White;
            vidpath.Location = new Point(198, 216);
            vidpath.Name = "vidpath";
            vidpath.Size = new Size(35, 15);
            vidpath.TabIndex = 6;
            vidpath.Text = "null";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            status.ForeColor = Color.Red;
            status.Location = new Point(198, 154);
            status.Name = "status";
            status.Size = new Size(91, 15);
            status.TabIndex = 7;
            status.Text = "Not Detected";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.swap;
            pictureBox4.Location = new Point(477, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(181, 110);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ValorantMenuChanger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(670, 243);
            Controls.Add(pictureBox4);
            Controls.Add(status);
            Controls.Add(vidpath);
            Controls.Add(gamepath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ValorantMenuChanger";
            Text = "ValorantMenuChanger";
            Load += ValorantMenuChanger_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
        private Label gamepath;
        private Label vidpath;
        private Label status;
        private PictureBox pictureBox4;
    }
}