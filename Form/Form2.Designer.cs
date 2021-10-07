namespace Book
{
    partial class BookShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookShop));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.PanelSide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.btnShopList = new System.Windows.Forms.Button();
            this.btnCollect = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.labelNum = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelLeft.Controls.Add(this.PanelSide);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.btnSet);
            this.panelLeft.Controls.Add(this.btnNotify);
            this.panelLeft.Controls.Add(this.btnShopList);
            this.panelLeft.Controls.Add(this.btnCollect);
            this.panelLeft.Controls.Add(this.btnSell);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 720);
            this.panelLeft.TabIndex = 0;
            // 
            // PanelSide
            // 
            this.PanelSide.BackColor = System.Drawing.Color.White;
            this.PanelSide.Location = new System.Drawing.Point(3, 223);
            this.PanelSide.Name = "PanelSide";
            this.PanelSide.Size = new System.Drawing.Size(7, 60);
            this.PanelSide.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 205);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(109, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Book Shop";
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(237, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(57, 67);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.Button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSet
            // 
            this.btnSet.FlatAppearance.BorderSize = 0;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.ForeColor = System.Drawing.Color.White;
            this.btnSet.Image = ((System.Drawing.Image)(resources.GetObject("btnSet.Image")));
            this.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSet.Location = new System.Drawing.Point(7, 553);
            this.btnSet.Name = "btnSet";
            this.btnSet.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnSet.Size = new System.Drawing.Size(293, 60);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "          Setting";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.FlatAppearance.BorderSize = 0;
            this.btnNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotify.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotify.ForeColor = System.Drawing.Color.White;
            this.btnNotify.Image = ((System.Drawing.Image)(resources.GetObject("btnNotify.Image")));
            this.btnNotify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotify.Location = new System.Drawing.Point(7, 487);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnNotify.Size = new System.Drawing.Size(293, 60);
            this.btnNotify.TabIndex = 2;
            this.btnNotify.Text = "          Notification";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // btnShopList
            // 
            this.btnShopList.FlatAppearance.BorderSize = 0;
            this.btnShopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShopList.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShopList.ForeColor = System.Drawing.Color.White;
            this.btnShopList.Image = ((System.Drawing.Image)(resources.GetObject("btnShopList.Image")));
            this.btnShopList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShopList.Location = new System.Drawing.Point(7, 421);
            this.btnShopList.Name = "btnShopList";
            this.btnShopList.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnShopList.Size = new System.Drawing.Size(293, 60);
            this.btnShopList.TabIndex = 2;
            this.btnShopList.Text = "       Shopping List";
            this.btnShopList.UseVisualStyleBackColor = true;
            this.btnShopList.Click += new System.EventHandler(this.btnShopList_Click);
            // 
            // btnCollect
            // 
            this.btnCollect.FlatAppearance.BorderSize = 0;
            this.btnCollect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollect.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollect.ForeColor = System.Drawing.Color.White;
            this.btnCollect.Image = ((System.Drawing.Image)(resources.GetObject("btnCollect.Image")));
            this.btnCollect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCollect.Location = new System.Drawing.Point(7, 355);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnCollect.Size = new System.Drawing.Size(293, 60);
            this.btnCollect.TabIndex = 2;
            this.btnCollect.Text = "          Collection";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCollect_Click);
            // 
            // btnSell
            // 
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.White;
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Location = new System.Drawing.Point(7, 289);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(293, 60);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "          Sell Book";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(7, 223);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(293, 60);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "          Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.labelNum);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(300, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 73);
            this.panel3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControls
            // 
            this.panelControls.AutoScroll = true;
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(300, 73);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(900, 647);
            this.panelControls.TabIndex = 2;
            // 
            // labelNum
            // 
            this.labelNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.White;
            this.labelNum.Location = new System.Drawing.Point(595, 40);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(0, 30);
            this.labelNum.TabIndex = 0;
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BookShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelLeft);
            this.Name = "BookShop";
            this.Text = "Book Shop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelLeft.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel PanelSide;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.Button btnShopList;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelNum;
    }
}