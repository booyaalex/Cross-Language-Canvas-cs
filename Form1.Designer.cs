namespace Database_and_Drawing_Testing
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
            this.pic_Canvas = new System.Windows.Forms.PictureBox();
            this.pnl_Tool_Selection = new System.Windows.Forms.Panel();
            this.lbl_Color_Display = new System.Windows.Forms.Label();
            this.btn_Select_Trigon = new System.Windows.Forms.Button();
            this.btn_Select_Circ = new System.Windows.Forms.Button();
            this.btn_Select_Rect = new System.Windows.Forms.Button();
            this.btn_Select_Line = new System.Windows.Forms.Button();
            this.lbl_Shape_Display = new System.Windows.Forms.Label();
            this.pnl_Color_Options = new System.Windows.Forms.Panel();
            this.btn_Select_Black = new System.Windows.Forms.Button();
            this.btn_Select_Purple = new System.Windows.Forms.Button();
            this.btn_Select_Blue = new System.Windows.Forms.Button();
            this.btn_Select_SkyBlue = new System.Windows.Forms.Button();
            this.btn_Select_Green = new System.Windows.Forms.Button();
            this.btn_Select_Yellow = new System.Windows.Forms.Button();
            this.btn_Select_Orange = new System.Windows.Forms.Button();
            this.btn_Select_Red = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Canvas)).BeginInit();
            this.pnl_Tool_Selection.SuspendLayout();
            this.pnl_Color_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_Canvas
            // 
            this.pic_Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Canvas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_Canvas.Location = new System.Drawing.Point(12, 12);
            this.pic_Canvas.Name = "pic_Canvas";
            this.pic_Canvas.Size = new System.Drawing.Size(559, 426);
            this.pic_Canvas.TabIndex = 0;
            this.pic_Canvas.TabStop = false;
            this.pic_Canvas.Click += new System.EventHandler(this.pic_Canvas_Click);
            // 
            // pnl_Tool_Selection
            // 
            this.pnl_Tool_Selection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Tool_Selection.Controls.Add(this.lbl_Color_Display);
            this.pnl_Tool_Selection.Controls.Add(this.btn_Select_Trigon);
            this.pnl_Tool_Selection.Controls.Add(this.btn_Select_Circ);
            this.pnl_Tool_Selection.Controls.Add(this.btn_Select_Rect);
            this.pnl_Tool_Selection.Controls.Add(this.btn_Select_Line);
            this.pnl_Tool_Selection.Controls.Add(this.lbl_Shape_Display);
            this.pnl_Tool_Selection.Controls.Add(this.pnl_Color_Options);
            this.pnl_Tool_Selection.Location = new System.Drawing.Point(577, 13);
            this.pnl_Tool_Selection.Name = "pnl_Tool_Selection";
            this.pnl_Tool_Selection.Size = new System.Drawing.Size(211, 425);
            this.pnl_Tool_Selection.TabIndex = 1;
            // 
            // lbl_Color_Display
            // 
            this.lbl_Color_Display.AutoSize = true;
            this.lbl_Color_Display.Location = new System.Drawing.Point(3, 125);
            this.lbl_Color_Display.Name = "lbl_Color_Display";
            this.lbl_Color_Display.Size = new System.Drawing.Size(109, 13);
            this.lbl_Color_Display.TabIndex = 11;
            this.lbl_Color_Display.Text = "Selected Color: Black";
            // 
            // btn_Select_Trigon
            // 
            this.btn_Select_Trigon.BackColor = System.Drawing.Color.Transparent;
            this.btn_Select_Trigon.BackgroundImage = global::Database_and_Drawing_Testing.Properties.Resources.triangle;
            this.btn_Select_Trigon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Select_Trigon.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Select_Trigon.Location = new System.Drawing.Point(6, 59);
            this.btn_Select_Trigon.Name = "btn_Select_Trigon";
            this.btn_Select_Trigon.Size = new System.Drawing.Size(50, 50);
            this.btn_Select_Trigon.TabIndex = 16;
            this.btn_Select_Trigon.UseVisualStyleBackColor = false;
            this.btn_Select_Trigon.Click += new System.EventHandler(this.btn_Select_Trigon_Click);
            // 
            // btn_Select_Circ
            // 
            this.btn_Select_Circ.BackColor = System.Drawing.Color.Transparent;
            this.btn_Select_Circ.BackgroundImage = global::Database_and_Drawing_Testing.Properties.Resources.circle;
            this.btn_Select_Circ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Select_Circ.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Select_Circ.Location = new System.Drawing.Point(62, 59);
            this.btn_Select_Circ.Name = "btn_Select_Circ";
            this.btn_Select_Circ.Size = new System.Drawing.Size(50, 50);
            this.btn_Select_Circ.TabIndex = 15;
            this.btn_Select_Circ.UseVisualStyleBackColor = false;
            this.btn_Select_Circ.Click += new System.EventHandler(this.btn_Select_Circ_Click);
            // 
            // btn_Select_Rect
            // 
            this.btn_Select_Rect.BackColor = System.Drawing.Color.Transparent;
            this.btn_Select_Rect.BackgroundImage = global::Database_and_Drawing_Testing.Properties.Resources.rect;
            this.btn_Select_Rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Select_Rect.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Select_Rect.Location = new System.Drawing.Point(62, 3);
            this.btn_Select_Rect.Name = "btn_Select_Rect";
            this.btn_Select_Rect.Size = new System.Drawing.Size(50, 50);
            this.btn_Select_Rect.TabIndex = 14;
            this.btn_Select_Rect.UseVisualStyleBackColor = false;
            this.btn_Select_Rect.Click += new System.EventHandler(this.btn_Select_Rect_Click);
            // 
            // btn_Select_Line
            // 
            this.btn_Select_Line.BackColor = System.Drawing.Color.Transparent;
            this.btn_Select_Line.BackgroundImage = global::Database_and_Drawing_Testing.Properties.Resources.line;
            this.btn_Select_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Select_Line.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Select_Line.Location = new System.Drawing.Point(6, 3);
            this.btn_Select_Line.Name = "btn_Select_Line";
            this.btn_Select_Line.Size = new System.Drawing.Size(50, 50);
            this.btn_Select_Line.TabIndex = 13;
            this.btn_Select_Line.UseVisualStyleBackColor = false;
            this.btn_Select_Line.Click += new System.EventHandler(this.btn_Select_Line_Click);
            // 
            // lbl_Shape_Display
            // 
            this.lbl_Shape_Display.AutoSize = true;
            this.lbl_Shape_Display.Location = new System.Drawing.Point(3, 112);
            this.lbl_Shape_Display.Name = "lbl_Shape_Display";
            this.lbl_Shape_Display.Size = new System.Drawing.Size(109, 13);
            this.lbl_Shape_Display.TabIndex = 12;
            this.lbl_Shape_Display.Text = "Selected Shape: Line";
            // 
            // pnl_Color_Options
            // 
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Black);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Purple);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Blue);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_SkyBlue);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Green);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Yellow);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Orange);
            this.pnl_Color_Options.Controls.Add(this.btn_Select_Red);
            this.pnl_Color_Options.Location = new System.Drawing.Point(115, 3);
            this.pnl_Color_Options.Name = "pnl_Color_Options";
            this.pnl_Color_Options.Size = new System.Drawing.Size(93, 106);
            this.pnl_Color_Options.TabIndex = 0;
            // 
            // btn_Select_Black
            // 
            this.btn_Select_Black.BackColor = System.Drawing.Color.Black;
            this.btn_Select_Black.Location = new System.Drawing.Point(33, 60);
            this.btn_Select_Black.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Black.Name = "btn_Select_Black";
            this.btn_Select_Black.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Black.TabIndex = 10;
            this.btn_Select_Black.UseVisualStyleBackColor = false;
            this.btn_Select_Black.Click += new System.EventHandler(this.btn_Select_Black_Click);
            // 
            // btn_Select_Purple
            // 
            this.btn_Select_Purple.BackColor = System.Drawing.Color.Indigo;
            this.btn_Select_Purple.Location = new System.Drawing.Point(3, 60);
            this.btn_Select_Purple.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Purple.Name = "btn_Select_Purple";
            this.btn_Select_Purple.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Purple.TabIndex = 9;
            this.btn_Select_Purple.UseVisualStyleBackColor = false;
            this.btn_Select_Purple.Click += new System.EventHandler(this.btn_Select_Purple_Click);
            // 
            // btn_Select_Blue
            // 
            this.btn_Select_Blue.BackColor = System.Drawing.Color.Blue;
            this.btn_Select_Blue.Location = new System.Drawing.Point(63, 30);
            this.btn_Select_Blue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Blue.Name = "btn_Select_Blue";
            this.btn_Select_Blue.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Blue.TabIndex = 8;
            this.btn_Select_Blue.UseVisualStyleBackColor = false;
            this.btn_Select_Blue.Click += new System.EventHandler(this.btn_Select_Blue_Click);
            // 
            // btn_Select_SkyBlue
            // 
            this.btn_Select_SkyBlue.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Select_SkyBlue.Location = new System.Drawing.Point(33, 30);
            this.btn_Select_SkyBlue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_SkyBlue.Name = "btn_Select_SkyBlue";
            this.btn_Select_SkyBlue.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_SkyBlue.TabIndex = 7;
            this.btn_Select_SkyBlue.UseVisualStyleBackColor = false;
            this.btn_Select_SkyBlue.Click += new System.EventHandler(this.btn_Select_SkyBlue_Click);
            // 
            // btn_Select_Green
            // 
            this.btn_Select_Green.BackColor = System.Drawing.Color.Green;
            this.btn_Select_Green.Location = new System.Drawing.Point(3, 30);
            this.btn_Select_Green.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Green.Name = "btn_Select_Green";
            this.btn_Select_Green.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Green.TabIndex = 6;
            this.btn_Select_Green.UseVisualStyleBackColor = false;
            this.btn_Select_Green.Click += new System.EventHandler(this.btn_Select_Green_Click);
            // 
            // btn_Select_Yellow
            // 
            this.btn_Select_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_Select_Yellow.Location = new System.Drawing.Point(63, 0);
            this.btn_Select_Yellow.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Yellow.Name = "btn_Select_Yellow";
            this.btn_Select_Yellow.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Yellow.TabIndex = 5;
            this.btn_Select_Yellow.UseVisualStyleBackColor = false;
            this.btn_Select_Yellow.Click += new System.EventHandler(this.btn_Select_Yellow_Click);
            // 
            // btn_Select_Orange
            // 
            this.btn_Select_Orange.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Select_Orange.Location = new System.Drawing.Point(33, 0);
            this.btn_Select_Orange.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Orange.Name = "btn_Select_Orange";
            this.btn_Select_Orange.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Orange.TabIndex = 4;
            this.btn_Select_Orange.UseVisualStyleBackColor = false;
            this.btn_Select_Orange.Click += new System.EventHandler(this.btn_Select_Orange_Click);
            // 
            // btn_Select_Red
            // 
            this.btn_Select_Red.BackColor = System.Drawing.Color.Red;
            this.btn_Select_Red.Location = new System.Drawing.Point(3, 0);
            this.btn_Select_Red.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Select_Red.Name = "btn_Select_Red";
            this.btn_Select_Red.Size = new System.Drawing.Size(30, 30);
            this.btn_Select_Red.TabIndex = 3;
            this.btn_Select_Red.UseVisualStyleBackColor = false;
            this.btn_Select_Red.Click += new System.EventHandler(this.btn_Select_Red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(801, 452);
            this.Controls.Add(this.pnl_Tool_Selection);
            this.Controls.Add(this.pic_Canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Canvas)).EndInit();
            this.pnl_Tool_Selection.ResumeLayout(false);
            this.pnl_Tool_Selection.PerformLayout();
            this.pnl_Color_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Canvas;
        private System.Windows.Forms.Panel pnl_Tool_Selection;
        private System.Windows.Forms.Panel pnl_Color_Options;
        private System.Windows.Forms.Button btn_Select_Red;
        private System.Windows.Forms.Button btn_Select_Green;
        private System.Windows.Forms.Button btn_Select_Yellow;
        private System.Windows.Forms.Button btn_Select_Orange;
        private System.Windows.Forms.Button btn_Select_Purple;
        private System.Windows.Forms.Button btn_Select_Blue;
        private System.Windows.Forms.Button btn_Select_SkyBlue;
        private System.Windows.Forms.Button btn_Select_Black;
        private System.Windows.Forms.Label lbl_Color_Display;
        private System.Windows.Forms.Label lbl_Shape_Display;
        private System.Windows.Forms.Button btn_Select_Line;
        private System.Windows.Forms.Button btn_Select_Trigon;
        private System.Windows.Forms.Button btn_Select_Circ;
        private System.Windows.Forms.Button btn_Select_Rect;
    }
}

