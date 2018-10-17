namespace IDN_1
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
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.Columns = new System.Windows.Forms.TextBox();
            this.Rows = new System.Windows.Forms.TextBox();
            this.Depth = new System.Windows.Forms.TextBox();
            this.Channels = new System.Windows.Forms.TextBox();
            this.Frames = new System.Windows.Forms.TextBox();
            this.FaceDetectionTime = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.HistBox = new Emgu.CV.UI.HistogramBox();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(847, 94);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(1001, 670);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(2308, 22);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(785, 571);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // Columns
            // 
            this.Columns.BackColor = System.Drawing.Color.DimGray;
            this.Columns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Columns.ForeColor = System.Drawing.Color.White;
            this.Columns.Location = new System.Drawing.Point(22, 94);
            this.Columns.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Columns.Name = "Columns";
            this.Columns.Size = new System.Drawing.Size(392, 22);
            this.Columns.TabIndex = 4;
            // 
            // Rows
            // 
            this.Rows.BackColor = System.Drawing.Color.DimGray;
            this.Rows.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rows.ForeColor = System.Drawing.Color.White;
            this.Rows.Location = new System.Drawing.Point(22, 129);
            this.Rows.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(392, 22);
            this.Rows.TabIndex = 5;
            // 
            // Depth
            // 
            this.Depth.BackColor = System.Drawing.Color.DimGray;
            this.Depth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Depth.ForeColor = System.Drawing.Color.White;
            this.Depth.Location = new System.Drawing.Point(22, 164);
            this.Depth.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(392, 22);
            this.Depth.TabIndex = 6;
            // 
            // Channels
            // 
            this.Channels.BackColor = System.Drawing.Color.DimGray;
            this.Channels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Channels.ForeColor = System.Drawing.Color.White;
            this.Channels.Location = new System.Drawing.Point(22, 199);
            this.Channels.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(392, 22);
            this.Channels.TabIndex = 7;
            // 
            // Frames
            // 
            this.Frames.BackColor = System.Drawing.Color.DimGray;
            this.Frames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Frames.ForeColor = System.Drawing.Color.White;
            this.Frames.Location = new System.Drawing.Point(22, 234);
            this.Frames.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Frames.Name = "Frames";
            this.Frames.Size = new System.Drawing.Size(392, 22);
            this.Frames.TabIndex = 8;
            // 
            // FaceDetectionTime
            // 
            this.FaceDetectionTime.BackColor = System.Drawing.Color.DimGray;
            this.FaceDetectionTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FaceDetectionTime.ForeColor = System.Drawing.Color.White;
            this.FaceDetectionTime.Location = new System.Drawing.Point(22, 270);
            this.FaceDetectionTime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FaceDetectionTime.Name = "FaceDetectionTime";
            this.FaceDetectionTime.Size = new System.Drawing.Size(392, 22);
            this.FaceDetectionTime.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(3254, 6);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 42);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HistBox
            // 
            this.HistBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistBox.Location = new System.Drawing.Point(22, 347);
            this.HistBox.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.HistBox.Name = "HistBox";
            this.HistBox.Size = new System.Drawing.Size(745, 694);
            this.HistBox.TabIndex = 12;
            // 
            // imageBox3
            // 
            this.imageBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox3.Location = new System.Drawing.Point(2308, 606);
            this.imageBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(785, 571);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 13;
            this.imageBox3.TabStop = false;
            // 
            // imageBox4
            // 
            this.imageBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox4.Location = new System.Drawing.Point(2308, 1189);
            this.imageBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(785, 571);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 14;
            this.imageBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(3414, 2143);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.HistBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.FaceDetectionTime);
            this.Controls.Add(this.Frames);
            this.Controls.Add(this.Channels);
            this.Controls.Add(this.Depth);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.Columns);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "ND1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Emgu.CV.UI.ImageBox imageBox1;
        public Emgu.CV.UI.ImageBox imageBox2;
        public System.Windows.Forms.TextBox Columns;
        public System.Windows.Forms.TextBox Rows;
        public System.Windows.Forms.TextBox Depth;
        public System.Windows.Forms.TextBox Channels;
        public System.Windows.Forms.TextBox Frames;
        public System.Windows.Forms.TextBox FaceDetectionTime;
        private System.Windows.Forms.Button btnExit;
        public Emgu.CV.UI.HistogramBox HistBox;
        public Emgu.CV.UI.ImageBox imageBox3;
        public Emgu.CV.UI.ImageBox imageBox4;
    }
}

