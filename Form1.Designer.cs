namespace TeamManagament_Test
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.txtIdTeam = new System.Windows.Forms.TextBox();
            this.txtNameTeam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBP = new System.Windows.Forms.ComboBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_fixitem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managament_TeamDataSet2 = new TeamManagament_Test.Managament_TeamDataSet2();
            this.managamentTeamDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new TeamManagament_Test.Managament_TeamDataSet2TableAdapters.DepartmentTableAdapter();
            this.departmentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managament_TeamDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managamentTeamDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Team ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 247);
            this.panel1.TabIndex = 1;
            // 
            // dtgv
            // 
            this.dtgv.AutoGenerateColumns = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.White;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.department_id,
            this.department_name,
            this.descriptions});
            this.dtgv.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgv.DataSource = this.departmentBindingSource;
            this.dtgv.GridColor = System.Drawing.Color.White;
            this.dtgv.Location = new System.Drawing.Point(0, 3);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv.Size = new System.Drawing.Size(433, 241);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // txtIdTeam
            // 
            this.txtIdTeam.Enabled = false;
            this.txtIdTeam.Location = new System.Drawing.Point(101, 11);
            this.txtIdTeam.Name = "txtIdTeam";
            this.txtIdTeam.ReadOnly = true;
            this.txtIdTeam.Size = new System.Drawing.Size(151, 20);
            this.txtIdTeam.TabIndex = 2;
            this.txtIdTeam.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNameTeam
            // 
            this.txtNameTeam.Enabled = false;
            this.txtNameTeam.Location = new System.Drawing.Point(101, 46);
            this.txtNameTeam.Name = "txtNameTeam";
            this.txtNameTeam.ReadOnly = true;
            this.txtNameTeam.Size = new System.Drawing.Size(151, 20);
            this.txtNameTeam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Team ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bộ Phận";
            // 
            // cbBP
            // 
            this.cbBP.BackColor = System.Drawing.Color.Silver;
            this.cbBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBP.Enabled = false;
            this.cbBP.FormattingEnabled = true;
            this.cbBP.Items.AddRange(new object[] {
            "Adminstration",
            "Director",
            "Development"});
            this.cbBP.Location = new System.Drawing.Point(101, 86);
            this.cbBP.Name = "cbBP";
            this.cbBP.Size = new System.Drawing.Size(151, 21);
            this.cbBP.TabIndex = 6;
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Insert.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_Insert.FlatAppearance.BorderSize = 0;
            this.btn_Insert.ForeColor = System.Drawing.Color.White;
            this.btn_Insert.Location = new System.Drawing.Point(9, 129);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 35);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "Thêm";
            this.btn_Insert.UseCompatibleTextRendering = true;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_fixitem
            // 
            this.btn_fixitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_fixitem.ForeColor = System.Drawing.Color.White;
            this.btn_fixitem.Location = new System.Drawing.Point(101, 129);
            this.btn_fixitem.Name = "btn_fixitem";
            this.btn_fixitem.Size = new System.Drawing.Size(79, 35);
            this.btn_fixitem.TabIndex = 8;
            this.btn_fixitem.Text = "Sửa";
            this.btn_fixitem.UseVisualStyleBackColor = false;
            this.btn_fixitem.Click += new System.EventHandler(this.btn_fixitem_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(198, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(76, 35);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_fixitem);
            this.panel2.Controls.Add(this.txtNameTeam);
            this.panel2.Controls.Add(this.txtIdTeam);
            this.panel2.Controls.Add(this.cbBP);
            this.panel2.Controls.Add(this.btn_Insert);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(451, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 247);
            this.panel2.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(15, 218);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(64, 26);
            this.btn_search.TabIndex = 11;
            this.btn_search.Text = "Tìm Kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(217, 218);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 26);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // managament_TeamDataSet2
            // 
            this.managament_TeamDataSet2.DataSetName = "Managament_TeamDataSet2";
            this.managament_TeamDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // managamentTeamDataSet2BindingSource
            // 
            this.managamentTeamDataSet2BindingSource.DataSource = this.managament_TeamDataSet2;
            this.managamentTeamDataSet2BindingSource.Position = 0;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.managament_TeamDataSet2;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // departmentBindingSource1
            // 
            this.departmentBindingSource1.DataMember = "Department";
            this.departmentBindingSource1.DataSource = this.managament_TeamDataSet2;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(TeamManagament_Test.Form1);
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.HeaderText = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            // 
            // department_name
            // 
            this.department_name.DataPropertyName = "department_name";
            this.department_name.HeaderText = "department_name";
            this.department_name.Name = "department_name";
            this.department_name.ReadOnly = true;
            // 
            // descriptions
            // 
            this.descriptions.DataPropertyName = "descriptions";
            this.descriptions.DataSource = this.departmentBindingSource1;
            this.descriptions.DisplayMember = "descriptions";
            this.descriptions.HeaderText = "descriptions";
            this.descriptions.Name = "descriptions";
            this.descriptions.ReadOnly = true;
            this.descriptions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.descriptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.descriptions.ValueMember = "descriptions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 269);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Team";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managament_TeamDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managamentTeamDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdTeam;
        private System.Windows.Forms.TextBox txtNameTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBP;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_fixitem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.BindingSource managamentTeamDataSet2BindingSource;
        private Managament_TeamDataSet2 managament_TeamDataSet2;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private Managament_TeamDataSet2TableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource departmentBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_name;
        private System.Windows.Forms.DataGridViewComboBoxColumn descriptions;
    }
}

