namespace Mokhatabin
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mokhatabinTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Mokhatabin.DataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.addtool = new System.Windows.Forms.ToolStripButton();
            this.removetool = new System.Windows.Forms.ToolStripButton();
            this.edittool = new System.Windows.Forms.ToolStripButton();
            this.showtool = new System.Windows.Forms.ToolStripButton();
            this.refreshtool = new System.Windows.Forms.ToolStripButton();
            this.abouttool = new System.Windows.Forms.ToolStripButton();
            this.mokhatabinTable1TableAdapter = new Mokhatabin.DataSet1TableAdapters.MokhatabinTable1TableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokhatabinTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.tellDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.mokhatabinTable1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 469);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "نام";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "نام خانوادگی";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "موبایل";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tellDataGridViewTextBoxColumn
            // 
            this.tellDataGridViewTextBoxColumn.DataPropertyName = "tell";
            this.tellDataGridViewTextBoxColumn.HeaderText = "تلفن";
            this.tellDataGridViewTextBoxColumn.Name = "tellDataGridViewTextBoxColumn";
            this.tellDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "ایمیل";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "ادرس";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "یادداشت";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.ReadOnly = true;
            this.noteDataGridViewTextBoxColumn.Width = 242;
            // 
            // mokhatabinTable1BindingSource
            // 
            this.mokhatabinTable1BindingSource.DataMember = "MokhatabinTable1";
            this.mokhatabinTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(-4, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 489);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مخاطبین";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addtool,
            this.removetool,
            this.edittool,
            this.showtool,
            this.refreshtool,
            this.abouttool});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(780, 74);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // addtool
            // 
            this.addtool.Image = ((System.Drawing.Image)(resources.GetObject("addtool.Image")));
            this.addtool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addtool.Name = "addtool";
            this.addtool.Size = new System.Drawing.Size(95, 71);
            this.addtool.Text = "افزودن مخاطب";
            this.addtool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addtool.Click += new System.EventHandler(this.addtool_Click);
            // 
            // removetool
            // 
            this.removetool.Image = ((System.Drawing.Image)(resources.GetObject("removetool.Image")));
            this.removetool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removetool.Name = "removetool";
            this.removetool.Size = new System.Drawing.Size(86, 71);
            this.removetool.Text = "حذف مخاطب";
            this.removetool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removetool.Click += new System.EventHandler(this.removetool_Click);
            // 
            // edittool
            // 
            this.edittool.Image = ((System.Drawing.Image)(resources.GetObject("edittool.Image")));
            this.edittool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.edittool.Name = "edittool";
            this.edittool.Size = new System.Drawing.Size(96, 71);
            this.edittool.Text = "ویرایش مخاطب";
            this.edittool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.edittool.Click += new System.EventHandler(this.edittool_Click);
            // 
            // showtool
            // 
            this.showtool.Image = ((System.Drawing.Image)(resources.GetObject("showtool.Image")));
            this.showtool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showtool.Name = "showtool";
            this.showtool.Size = new System.Drawing.Size(88, 71);
            this.showtool.Text = "نماش مخاطب";
            this.showtool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.showtool.Click += new System.EventHandler(this.showtool_Click);
            // 
            // refreshtool
            // 
            this.refreshtool.Image = ((System.Drawing.Image)(resources.GetObject("refreshtool.Image")));
            this.refreshtool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshtool.Name = "refreshtool";
            this.refreshtool.Size = new System.Drawing.Size(62, 71);
            this.refreshtool.Text = "تازه سازی";
            this.refreshtool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshtool.Click += new System.EventHandler(this.refreshtool_Click);
            // 
            // abouttool
            // 
            this.abouttool.Image = ((System.Drawing.Image)(resources.GetObject("abouttool.Image")));
            this.abouttool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abouttool.Name = "abouttool";
            this.abouttool.Size = new System.Drawing.Size(74, 71);
            this.abouttool.Text = "تماس با من";
            this.abouttool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.abouttool.Click += new System.EventHandler(this.abouttool_Click);
            // 
            // mokhatabinTable1TableAdapter
            // 
            this.mokhatabinTable1TableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "جستجو:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Mokhatabin";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokhatabinTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource mokhatabinTable1BindingSource;
        private DataSet1TableAdapters.MokhatabinTable1TableAdapter mokhatabinTable1TableAdapter;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton addtool;
        private System.Windows.Forms.ToolStripButton removetool;
        private System.Windows.Forms.ToolStripButton refreshtool;
        private System.Windows.Forms.ToolStripButton edittool;
        private System.Windows.Forms.ToolStripButton showtool;
        private System.Windows.Forms.ToolStripButton abouttool;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tellDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

