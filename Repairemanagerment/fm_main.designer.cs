namespace Repairemanagerment
{
    partial class fm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_main));
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.tsmi_Maintance = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Use = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_repaire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_repaireinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_parts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_spare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Belong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Query = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Stooling = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Srepair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_State = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Quse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Qrepair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Qrepairinfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Qparts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Qspare = new System.Windows.Forms.ToolStripMenuItem();
            this.tsim_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.tssl_userInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Baker = new System.Windows.Forms.Button();
            this.btn_APS = new System.Windows.Forms.Button();
            this.btn_Domestic = new System.Windows.Forms.Button();
            this.Cmn_DiliverTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmn_User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmn_Manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmn_SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmn_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cmn_Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Location = new System.Windows.Forms.DataGridView();
            this.menu_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Location)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Maintance,
            this.tsmi_Query,
            this.tsmi_State,
            this.tsim_Print});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.MdiWindowListItem = this.tsmi_Maintance;
            this.menu_main.Name = "menu_main";
            this.menu_main.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menu_main.Size = new System.Drawing.Size(1188, 28);
            this.menu_main.TabIndex = 0;
            this.menu_main.Text = "进度显示";
            // 
            // tsmi_Maintance
            // 
            this.tsmi_Maintance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Use,
            this.tsmi_repaire,
            this.tsmi_repaireinfo,
            this.tsmi_parts,
            this.tsmi_spare,
            this.tsmi_Belong});
            this.tsmi_Maintance.Name = "tsmi_Maintance";
            this.tsmi_Maintance.Size = new System.Drawing.Size(81, 24);
            this.tsmi_Maintance.Text = "维护操作";
            // 
            // tsmi_Use
            // 
            this.tsmi_Use.Name = "tsmi_Use";
            this.tsmi_Use.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Use.Text = "仪器运行维护";
            this.tsmi_Use.Click += new System.EventHandler(this.tsmi_use_Click);
            // 
            // tsmi_repaire
            // 
            this.tsmi_repaire.Name = "tsmi_repaire";
            this.tsmi_repaire.Size = new System.Drawing.Size(181, 26);
            this.tsmi_repaire.Text = "仪器维修维护";
            this.tsmi_repaire.Click += new System.EventHandler(this.tsmi_Repaire_Click);
            // 
            // tsmi_repaireinfo
            // 
            this.tsmi_repaireinfo.Name = "tsmi_repaireinfo";
            this.tsmi_repaireinfo.Size = new System.Drawing.Size(181, 26);
            this.tsmi_repaireinfo.Text = "维修信息维护";
            this.tsmi_repaireinfo.Click += new System.EventHandler(this.tsim_Repaireinfo_Click);
            // 
            // tsmi_parts
            // 
            this.tsmi_parts.Name = "tsmi_parts";
            this.tsmi_parts.Size = new System.Drawing.Size(181, 26);
            this.tsmi_parts.Text = "仪器部件维护";
            this.tsmi_parts.Click += new System.EventHandler(this.tsim_Parts_Click);
            // 
            // tsmi_spare
            // 
            this.tsmi_spare.Name = "tsmi_spare";
            this.tsmi_spare.Size = new System.Drawing.Size(181, 26);
            this.tsmi_spare.Text = "备件信息维护";
            this.tsmi_spare.Click += new System.EventHandler(this.tsim_Spare_Click);
            // 
            // tsmi_Belong
            // 
            this.tsmi_Belong.Name = "tsmi_Belong";
            this.tsmi_Belong.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Belong.Text = "仪器归属维护";
            this.tsmi_Belong.Click += new System.EventHandler(this.tsim_Belong_Click);
            // 
            // tsmi_Query
            // 
            this.tsmi_Query.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Stooling,
            this.tsmi_Srepair});
            this.tsmi_Query.Name = "tsmi_Query";
            this.tsmi_Query.Size = new System.Drawing.Size(81, 24);
            this.tsmi_Query.Text = "状态操作";
            // 
            // tsmi_Stooling
            // 
            this.tsmi_Stooling.Name = "tsmi_Stooling";
            this.tsmi_Stooling.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Stooling.Text = "仪器状态";
            this.tsmi_Stooling.Click += new System.EventHandler(this.tsim_Stooling_Click);
            // 
            // tsmi_Srepair
            // 
            this.tsmi_Srepair.Name = "tsmi_Srepair";
            this.tsmi_Srepair.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Srepair.Text = "维修状态";
            this.tsmi_Srepair.Click += new System.EventHandler(this.tsim_Srepaire_Click);
            // 
            // tsmi_State
            // 
            this.tsmi_State.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Quse,
            this.tsmi_Qrepair,
            this.tsmi_Qrepairinfo,
            this.tsmi_Qparts,
            this.tsmi_Qspare});
            this.tsmi_State.Name = "tsmi_State";
            this.tsmi_State.Size = new System.Drawing.Size(81, 24);
            this.tsmi_State.Text = "查询操作";
            // 
            // tsmi_Quse
            // 
            this.tsmi_Quse.Name = "tsmi_Quse";
            this.tsmi_Quse.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Quse.Text = "仪器运行查询";
            this.tsmi_Quse.Click += new System.EventHandler(this.tsim_Quse_Click);
            // 
            // tsmi_Qrepair
            // 
            this.tsmi_Qrepair.Name = "tsmi_Qrepair";
            this.tsmi_Qrepair.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Qrepair.Text = "仪器维修查询";
            this.tsmi_Qrepair.Click += new System.EventHandler(this.tsim_Qrepair_Click);
            // 
            // tsmi_Qrepairinfo
            // 
            this.tsmi_Qrepairinfo.Name = "tsmi_Qrepairinfo";
            this.tsmi_Qrepairinfo.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Qrepairinfo.Text = "维修信息查询";
            this.tsmi_Qrepairinfo.Click += new System.EventHandler(this.tsim_Qrepairinfo_Click);
            // 
            // tsmi_Qparts
            // 
            this.tsmi_Qparts.Name = "tsmi_Qparts";
            this.tsmi_Qparts.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Qparts.Text = "仪器部件查询";
            this.tsmi_Qparts.Click += new System.EventHandler(this.tsim_Qparts_Click);
            // 
            // tsmi_Qspare
            // 
            this.tsmi_Qspare.Name = "tsmi_Qspare";
            this.tsmi_Qspare.Size = new System.Drawing.Size(181, 26);
            this.tsmi_Qspare.Text = "备件信息查询";
            this.tsmi_Qspare.Click += new System.EventHandler(this.tsim_Qspare_Click);
            // 
            // tsim_Print
            // 
            this.tsim_Print.Name = "tsim_Print";
            this.tsim_Print.Size = new System.Drawing.Size(81, 24);
            this.tsim_Print.Text = "进度显示";
            this.tsim_Print.Click += new System.EventHandler(this.tsim_Print_Click);
            // 
            // tssl_userInfo
            // 
            this.tssl_userInfo.Name = "tssl_userInfo";
            this.tssl_userInfo.Size = new System.Drawing.Size(23, 23);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(23, 23);
            // 
            // tssl_time
            // 
            this.tssl_time.Name = "tssl_time";
            this.tssl_time.Size = new System.Drawing.Size(23, 23);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btn_Baker);
            this.panel1.Controls.Add(this.btn_APS);
            this.panel1.Controls.Add(this.btn_Domestic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 693);
            this.panel1.TabIndex = 1;
            // 
            // btn_Baker
            // 
            this.btn_Baker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Baker.Image = ((System.Drawing.Image)(resources.GetObject("btn_Baker.Image")));
            this.btn_Baker.Location = new System.Drawing.Point(33, 505);
            this.btn_Baker.Name = "btn_Baker";
            this.btn_Baker.Size = new System.Drawing.Size(134, 134);
            this.btn_Baker.TabIndex = 2;
            this.btn_Baker.UseVisualStyleBackColor = true;
            // 
            // btn_APS
            // 
            this.btn_APS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_APS.Image = ((System.Drawing.Image)(resources.GetObject("btn_APS.Image")));
            this.btn_APS.Location = new System.Drawing.Point(33, 255);
            this.btn_APS.Name = "btn_APS";
            this.btn_APS.Size = new System.Drawing.Size(134, 134);
            this.btn_APS.TabIndex = 1;
            this.btn_APS.UseVisualStyleBackColor = true;
            // 
            // btn_Domestic
            // 
            this.btn_Domestic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Domestic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Domestic.Image = ((System.Drawing.Image)(resources.GetObject("btn_Domestic.Image")));
            this.btn_Domestic.Location = new System.Drawing.Point(33, 32);
            this.btn_Domestic.Name = "btn_Domestic";
            this.btn_Domestic.Size = new System.Drawing.Size(134, 134);
            this.btn_Domestic.TabIndex = 0;
            this.btn_Domestic.UseVisualStyleBackColor = true;
            this.btn_Domestic.Click += new System.EventHandler(this.btn_Domestic_Click);
            // 
            // Cmn_DiliverTime
            // 
            this.Cmn_DiliverTime.HeaderText = "交付时间";
            this.Cmn_DiliverTime.Name = "Cmn_DiliverTime";
            this.Cmn_DiliverTime.ReadOnly = true;
            // 
            // Cmn_User
            // 
            this.Cmn_User.HeaderText = "归属";
            this.Cmn_User.Name = "Cmn_User";
            this.Cmn_User.ReadOnly = true;
            // 
            // Cmn_Manufacture
            // 
            this.Cmn_Manufacture.HeaderText = "制造方";
            this.Cmn_Manufacture.Name = "Cmn_Manufacture";
            this.Cmn_Manufacture.ReadOnly = true;
            // 
            // Cmn_SN
            // 
            this.Cmn_SN.HeaderText = "仪器号";
            this.Cmn_SN.Name = "Cmn_SN";
            this.Cmn_SN.ReadOnly = true;
            // 
            // Cmn_Type
            // 
            this.Cmn_Type.HeaderText = "类别";
            this.Cmn_Type.Name = "Cmn_Type";
            this.Cmn_Type.ReadOnly = true;
            // 
            // Cmn_Order
            // 
            this.Cmn_Order.HeaderText = "序号";
            this.Cmn_Order.Name = "Cmn_Order";
            // 
            // dgv_Location
            // 
            this.dgv_Location.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Location.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Location.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cmn_Order,
            this.Cmn_Type,
            this.Cmn_SN,
            this.Cmn_Manufacture,
            this.Cmn_User,
            this.Cmn_DiliverTime});
            this.dgv_Location.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Location.Location = new System.Drawing.Point(200, 28);
            this.dgv_Location.Name = "dgv_Location";
            this.dgv_Location.RowTemplate.Height = 27;
            this.dgv_Location.Size = new System.Drawing.Size(988, 693);
            this.dgv_Location.TabIndex = 2;
            // 
            // fm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 721);
            this.Controls.Add(this.dgv_Location);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu_main);
            this.MainMenuStrip = this.menu_main;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随钻仪器维修数据库系统（beta）";
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Location)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Maintance;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Use;
        private System.Windows.Forms.ToolStripMenuItem tsmi_repaire;
        private System.Windows.Forms.ToolStripMenuItem tsmi_repaireinfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Query;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Stooling;
        private System.Windows.Forms.ToolStripMenuItem tsmi_State;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Quse;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Qrepair;
        private System.Windows.Forms.ToolStripMenuItem tsmi_parts;
        private System.Windows.Forms.ToolStripMenuItem tsmi_spare;
        private System.Windows.Forms.ToolStripStatusLabel tssl_userInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_time;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Srepair;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Qrepairinfo;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Qparts;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Qspare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Baker;
        private System.Windows.Forms.Button btn_APS;
        private System.Windows.Forms.Button btn_Domestic;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Belong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_DiliverTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_Manufacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cmn_Order;
        private System.Windows.Forms.DataGridView dgv_Location;
        private System.Windows.Forms.ToolStripMenuItem tsim_Print;
    }
}