namespace UI.ViewForms
{
    partial class Menubox
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.parent_table_layout = new System.Windows.Forms.TableLayoutPanel();
            this.table_tabcontrol = new System.Windows.Forms.TabControl();
            this.client_tab = new System.Windows.Forms.TabPage();
            this.cd_tablayout = new System.Windows.Forms.TableLayoutPanel();
            this.clientdatagridview = new System.Windows.Forms.DataGridView();
            this.cd_menustrip = new System.Windows.Forms.MenuStrip();
            this.cd_change = new System.Windows.Forms.ToolStripMenuItem();
            this.searchmodifyremove = new System.Windows.Forms.ToolStripMenuItem();
            this.Complaints_tab = new System.Windows.Forms.TabPage();
            this.complaint_tablelayoutpanel = new System.Windows.Forms.TableLayoutPanel();
            this.complaintsdatagridview = new System.Windows.Forms.DataGridView();
            this.complainIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complainDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.isp_mgmt_dbDataSet1 = new UI.isp_mgmt_dbDataSet1();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addcomplaintstrip = new System.Windows.Forms.ToolStripMenuItem();
            this.complaints_srm = new System.Windows.Forms.ToolStripMenuItem();
            this.bill_tab = new System.Windows.Forms.TabPage();
            this.billings_LayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.billdatagridview = new System.Windows.Forms.DataGridView();
            this.billIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentBillDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousDueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoicePeriodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingBindingSource = new System.Windows.Forms.BindingSource(this.components);
           // this.isp_mgmt_dbDataSet2 = new UI.isp_mgmt_dbDataSet2();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this._addbill = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
           // this.complainDetailsTableAdapter = new UI.isp_mgmt_dbDataSet1TableAdapters.ComplainDetailsTableAdapter();
            //this.billingTableAdapter = new UI.isp_mgmt_dbDataSet2TableAdapters.BillingTableAdapter();
            this.flowLayoutPanel1.SuspendLayout();
            this.parent_table_layout.SuspendLayout();
            this.table_tabcontrol.SuspendLayout();
            this.client_tab.SuspendLayout();
            this.cd_tablayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagridview)).BeginInit();
            this.cd_menustrip.SuspendLayout();
            this.Complaints_tab.SuspendLayout();
            this.complaint_tablelayoutpanel.SuspendLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.complaintsdatagridview)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.complainDetailsBindingSource)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.isp_mgmt_dbDataSet1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.bill_tab.SuspendLayout();
            this.billings_LayoutPanel.SuspendLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.billdatagridview)).BeginInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.isp_mgmt_dbDataSet2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.parent_table_layout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1139, 522);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // parent_table_layout
            // 
            this.parent_table_layout.ColumnCount = 1;
            this.parent_table_layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parent_table_layout.Controls.Add(this.table_tabcontrol, 0, 0);
            this.parent_table_layout.Location = new System.Drawing.Point(3, 3);
            this.parent_table_layout.Name = "parent_table_layout";
            this.parent_table_layout.RowCount = 1;
            this.parent_table_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.parent_table_layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.parent_table_layout.Size = new System.Drawing.Size(1381, 517);
            this.parent_table_layout.TabIndex = 0;
            // 
            // table_tabcontrol
            // 
            this.table_tabcontrol.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.table_tabcontrol.Controls.Add(this.client_tab);
            this.table_tabcontrol.Controls.Add(this.Complaints_tab);
            this.table_tabcontrol.Controls.Add(this.bill_tab);
            this.table_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_tabcontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.table_tabcontrol.HotTrack = true;
            this.table_tabcontrol.Location = new System.Drawing.Point(3, 3);
            this.table_tabcontrol.Name = "table_tabcontrol";
            this.table_tabcontrol.SelectedIndex = 0;
            this.table_tabcontrol.Size = new System.Drawing.Size(1375, 511);
            this.table_tabcontrol.TabIndex = 1;
            // 
            // client_tab
            // 
            this.client_tab.Controls.Add(this.cd_tablayout);
            this.client_tab.Location = new System.Drawing.Point(4, 27);
            this.client_tab.Name = "client_tab";
            this.client_tab.Padding = new System.Windows.Forms.Padding(3);
            this.client_tab.Size = new System.Drawing.Size(1367, 480);
            this.client_tab.TabIndex = 0;
            this.client_tab.Text = "Client Data";
            this.client_tab.UseVisualStyleBackColor = true;
            this.client_tab.Enter += new System.EventHandler(this.client_tab_Enter);
            // 
            // cd_tablayout
            // 
            this.cd_tablayout.ColumnCount = 1;
            this.cd_tablayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cd_tablayout.Controls.Add(this.clientdatagridview, 0, 1);
            this.cd_tablayout.Controls.Add(this.cd_menustrip, 0, 0);
            this.cd_tablayout.Location = new System.Drawing.Point(-1, -2);
            this.cd_tablayout.Name = "cd_tablayout";
            this.cd_tablayout.RowCount = 2;
            this.cd_tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cd_tablayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.cd_tablayout.Size = new System.Drawing.Size(1368, 464);
            this.cd_tablayout.TabIndex = 1;
            // 
            // clientdatagridview
            // 
            this.clientdatagridview.AllowUserToAddRows = false;
            this.clientdatagridview.AllowUserToDeleteRows = false;
            this.clientdatagridview.AllowUserToOrderColumns = true;
            this.clientdatagridview.BackgroundColor = System.Drawing.Color.Snow;
            this.clientdatagridview.CausesValidation = false;
            this.clientdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.clientdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientdatagridview.Location = new System.Drawing.Point(3, 33);
            this.clientdatagridview.Name = "clientdatagridview";
            this.clientdatagridview.ReadOnly = true;
            this.clientdatagridview.Size = new System.Drawing.Size(1362, 428);
            this.clientdatagridview.TabIndex = 1;
            // 
            // cd_menustrip
            // 
            this.cd_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cd_change,
            this.searchmodifyremove});
            this.cd_menustrip.Location = new System.Drawing.Point(0, 0);
            this.cd_menustrip.Name = "cd_menustrip";
            this.cd_menustrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.cd_menustrip.Size = new System.Drawing.Size(1368, 29);
            this.cd_menustrip.TabIndex = 0;
            this.cd_menustrip.Text = "menuStrip2";
            // 
            // cd_change
            // 
            this.cd_change.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cd_change.Image = global::UI.Properties.Resources._1407728974_user_unstarred;
            this.cd_change.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cd_change.Name = "cd_change";
            this.cd_change.Size = new System.Drawing.Size(110, 25);
            this.cd_change.Text = "Add Client";
            this.cd_change.Click += new System.EventHandler(this.cd_addUser_menu_Click);
            // 
            // searchmodifyremove
            // 
            this.searchmodifyremove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.searchmodifyremove.Image = global::UI.Properties.Resources._1407729158_48764;
            this.searchmodifyremove.Name = "searchmodifyremove";
            this.searchmodifyremove.Size = new System.Drawing.Size(215, 25);
            this.searchmodifyremove.Text = "Search | Modify | Remove";
            this.searchmodifyremove.Click += new System.EventHandler(this.searchmodifyremove_Click);
            // 
            // Complaints_tab
            // 
            this.Complaints_tab.Controls.Add(this.complaint_tablelayoutpanel);
            this.Complaints_tab.Location = new System.Drawing.Point(4, 27);
            this.Complaints_tab.Name = "Complaints_tab";
            this.Complaints_tab.Padding = new System.Windows.Forms.Padding(3);
            this.Complaints_tab.Size = new System.Drawing.Size(1367, 480);
            this.Complaints_tab.TabIndex = 1;
            this.Complaints_tab.Text = "Complaints";
            this.Complaints_tab.UseVisualStyleBackColor = true;
            // 
            // complaint_tablelayoutpanel
            // 
            this.complaint_tablelayoutpanel.ColumnCount = 1;
            this.complaint_tablelayoutpanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.complaint_tablelayoutpanel.Controls.Add(this.complaintsdatagridview, 0, 1);
            this.complaint_tablelayoutpanel.Controls.Add(this.menuStrip1, 0, 0);
            this.complaint_tablelayoutpanel.Location = new System.Drawing.Point(-1, -2);
            this.complaint_tablelayoutpanel.Name = "complaint_tablelayoutpanel";
            this.complaint_tablelayoutpanel.RowCount = 2;
            this.complaint_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.complaint_tablelayoutpanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 433F));
            this.complaint_tablelayoutpanel.Size = new System.Drawing.Size(1368, 464);
            this.complaint_tablelayoutpanel.TabIndex = 1;
            // 
            // complaintsdatagridview
            // 
            this.complaintsdatagridview.AllowUserToAddRows = false;
            this.complaintsdatagridview.AllowUserToDeleteRows = false;
            this.complaintsdatagridview.AllowUserToOrderColumns = true;
            this.complaintsdatagridview.AutoGenerateColumns = false;
            this.complaintsdatagridview.BackgroundColor = System.Drawing.Color.Snow;
            this.complaintsdatagridview.CausesValidation = false;
            this.complaintsdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.complaintsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.complaintsdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.complainIdDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn,
            this.problemDetailsDataGridViewTextBoxColumn,
            this.problemStatusDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.complaintsdatagridview.DataSource = this.complainDetailsBindingSource;
            this.complaintsdatagridview.Dock = System.Windows.Forms.DockStyle.Top;
            this.complaintsdatagridview.Location = new System.Drawing.Point(3, 34);
            this.complaintsdatagridview.Name = "complaintsdatagridview";
            this.complaintsdatagridview.ReadOnly = true;
            this.complaintsdatagridview.Size = new System.Drawing.Size(1362, 427);
            this.complaintsdatagridview.TabIndex = 1;
            // 
            // complainIdDataGridViewTextBoxColumn
            // 
            this.complainIdDataGridViewTextBoxColumn.DataPropertyName = "Complain_Id";
            this.complainIdDataGridViewTextBoxColumn.HeaderText = "Complain_Id";
            this.complainIdDataGridViewTextBoxColumn.Name = "complainIdDataGridViewTextBoxColumn";
            this.complainIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            this.clientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // problemDetailsDataGridViewTextBoxColumn
            // 
            this.problemDetailsDataGridViewTextBoxColumn.DataPropertyName = "ProblemDetails";
            this.problemDetailsDataGridViewTextBoxColumn.HeaderText = "ProblemDetails";
            this.problemDetailsDataGridViewTextBoxColumn.Name = "problemDetailsDataGridViewTextBoxColumn";
            this.problemDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // problemStatusDataGridViewTextBoxColumn
            // 
            this.problemStatusDataGridViewTextBoxColumn.DataPropertyName = "ProblemStatus";
            this.problemStatusDataGridViewTextBoxColumn.HeaderText = "ProblemStatus";
            this.problemStatusDataGridViewTextBoxColumn.Name = "problemStatusDataGridViewTextBoxColumn";
            this.problemStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // complainDetailsBindingSource
            // 
            this.complainDetailsBindingSource.DataMember = "ComplainDetails";
           // this.complainDetailsBindingSource.DataSource = this.isp_mgmt_dbDataSet1;
            // 
            // isp_mgmt_dbDataSet1
            // 
           // this.isp_mgmt_dbDataSet1.DataSetName = "isp_mgmt_dbDataSet1";
           // this.isp_mgmt_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addcomplaintstrip,
            this.complaints_srm});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1368, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // addcomplaintstrip
            // 
            this.addcomplaintstrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.addcomplaintstrip.Image = global::UI.Properties.Resources._1407728923_user_info;
            this.addcomplaintstrip.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addcomplaintstrip.Name = "addcomplaintstrip";
            this.addcomplaintstrip.Size = new System.Drawing.Size(142, 25);
            this.addcomplaintstrip.Text = "Add Complaint";
            this.addcomplaintstrip.Click += new System.EventHandler(this.addcomplaintstrip_Click_1);
            // 
            // complaints_srm
            // 
            this.complaints_srm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.complaints_srm.Image = global::UI.Properties.Resources._1407729158_48764;
            this.complaints_srm.Name = "complaints_srm";
            this.complaints_srm.Size = new System.Drawing.Size(221, 25);
            this.complaints_srm.Text = "Search, Remove or Modify";
            this.complaints_srm.Click += new System.EventHandler(this.complaints_srm_Click);
            // 
            // bill_tab
            // 
            this.bill_tab.Controls.Add(this.billings_LayoutPanel);
            this.bill_tab.Location = new System.Drawing.Point(4, 27);
            this.bill_tab.Name = "bill_tab";
            this.bill_tab.Size = new System.Drawing.Size(1367, 480);
            this.bill_tab.TabIndex = 2;
            this.bill_tab.Text = "Billings";
            this.bill_tab.UseVisualStyleBackColor = true;
            // 
            // billings_LayoutPanel
            // 
            this.billings_LayoutPanel.ColumnCount = 1;
            this.billings_LayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billings_LayoutPanel.Controls.Add(this.billdatagridview, 0, 1);
            this.billings_LayoutPanel.Controls.Add(this.menuStrip2, 0, 0);
            this.billings_LayoutPanel.Location = new System.Drawing.Point(-1, -2);
            this.billings_LayoutPanel.Name = "billings_LayoutPanel";
            this.billings_LayoutPanel.RowCount = 2;
            this.billings_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.billings_LayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.billings_LayoutPanel.Size = new System.Drawing.Size(1368, 464);
            this.billings_LayoutPanel.TabIndex = 1;
            // 
            // billdatagridview
            // 
            this.billdatagridview.AllowUserToAddRows = false;
            this.billdatagridview.AllowUserToDeleteRows = false;
            this.billdatagridview.AllowUserToOrderColumns = true;
            this.billdatagridview.AutoGenerateColumns = false;
            this.billdatagridview.BackgroundColor = System.Drawing.Color.Snow;
            this.billdatagridview.CausesValidation = false;
            this.billdatagridview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.billdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billdatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIDDataGridViewTextBoxColumn,
            this.clientIdDataGridViewTextBoxColumn1,
            this.currentBillDataGridViewTextBoxColumn,
            this.previousDueDataGridViewTextBoxColumn,
            this.invoicePeriodDataGridViewTextBoxColumn});
            this.billdatagridview.DataSource = this.billingBindingSource;
            this.billdatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billdatagridview.Location = new System.Drawing.Point(3, 33);
            this.billdatagridview.Name = "billdatagridview";
            this.billdatagridview.ReadOnly = true;
            this.billdatagridview.Size = new System.Drawing.Size(1362, 428);
            this.billdatagridview.TabIndex = 1;
            // 
            // billIDDataGridViewTextBoxColumn
            // 
            this.billIDDataGridViewTextBoxColumn.DataPropertyName = "Bill_ID";
            this.billIDDataGridViewTextBoxColumn.HeaderText = "Bill_ID";
            this.billIDDataGridViewTextBoxColumn.Name = "billIDDataGridViewTextBoxColumn";
            this.billIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIdDataGridViewTextBoxColumn1
            // 
            this.clientIdDataGridViewTextBoxColumn1.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn1.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn1.Name = "clientIdDataGridViewTextBoxColumn1";
            this.clientIdDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // currentBillDataGridViewTextBoxColumn
            // 
            this.currentBillDataGridViewTextBoxColumn.DataPropertyName = "Current_Bill";
            this.currentBillDataGridViewTextBoxColumn.HeaderText = "Current_Bill";
            this.currentBillDataGridViewTextBoxColumn.Name = "currentBillDataGridViewTextBoxColumn";
            this.currentBillDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // previousDueDataGridViewTextBoxColumn
            // 
            this.previousDueDataGridViewTextBoxColumn.DataPropertyName = "Previous_Due";
            this.previousDueDataGridViewTextBoxColumn.HeaderText = "Previous_Due";
            this.previousDueDataGridViewTextBoxColumn.Name = "previousDueDataGridViewTextBoxColumn";
            this.previousDueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoicePeriodDataGridViewTextBoxColumn
            // 
            this.invoicePeriodDataGridViewTextBoxColumn.DataPropertyName = "InvoicePeriod";
            this.invoicePeriodDataGridViewTextBoxColumn.HeaderText = "InvoicePeriod";
            this.invoicePeriodDataGridViewTextBoxColumn.Name = "invoicePeriodDataGridViewTextBoxColumn";
            this.invoicePeriodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billingBindingSource
            // 
          ////  this.billingBindingSource.DataMember = "Billing";
         ////   this.billingBindingSource.DataSource = this.isp_mgmt_dbDataSet2;
            // 
            // isp_mgmt_dbDataSet2
            // 
           // this.isp_mgmt_dbDataSet2.DataSetName = "isp_mgmt_dbDataSet2";
          //  this.isp_mgmt_dbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
           // // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._addbill,
            this.toolStripMenuItem10});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip2.Size = new System.Drawing.Size(1368, 29);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // _addbill
            // 
            this._addbill.Font = new System.Drawing.Font("Segoe UI", 12F);
            this._addbill.Image = global::UI.Properties.Resources._1407728974_user_unstarred;
            this._addbill.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this._addbill.Name = "_addbill";
            this._addbill.Size = new System.Drawing.Size(91, 25);
            this._addbill.Text = "Add Bill";
            this._addbill.Click += new System.EventHandler(this._addbill_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripMenuItem10.Image = global::UI.Properties.Resources._1407729158_48764;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(85, 25);
            this.toolStripMenuItem10.Text = "Search";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click);
            // 
            // complainDetailsTableAdapter
            // 
           // this.complainDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // billingTableAdapter
            // 
          //  this.billingTableAdapter.ClearBeforeFill = true;
            // 
            // Menubox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 522);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Menubox";
            this.Text = "Main Menu";
            //this.Load += new System.EventHandler(this.Menubox_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.parent_table_layout.ResumeLayout(false);
            this.table_tabcontrol.ResumeLayout(false);
            this.client_tab.ResumeLayout(false);
            this.cd_tablayout.ResumeLayout(false);
            this.cd_tablayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagridview)).EndInit();
            this.cd_menustrip.ResumeLayout(false);
            this.cd_menustrip.PerformLayout();
            this.Complaints_tab.ResumeLayout(false);
            this.complaint_tablelayoutpanel.ResumeLayout(false);
            this.complaint_tablelayoutpanel.PerformLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.complaintsdatagridview)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.complainDetailsBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.isp_mgmt_dbDataSet1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.bill_tab.ResumeLayout(false);
            this.billings_LayoutPanel.ResumeLayout(false);
            this.billings_LayoutPanel.PerformLayout();
           // ((System.ComponentModel.ISupportInitialize)(this.billdatagridview)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.billingBindingSource)).EndInit();
           // ((System.ComponentModel.ISupportInitialize)(this.isp_mgmt_dbDataSet2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel parent_table_layout;
        private System.Windows.Forms.TabControl table_tabcontrol;
        private System.Windows.Forms.TabPage client_tab;
        private System.Windows.Forms.TableLayoutPanel cd_tablayout;
        private System.Windows.Forms.DataGridView clientdatagridview;
        private System.Windows.Forms.MenuStrip cd_menustrip;
        private System.Windows.Forms.ToolStripMenuItem cd_change;
        private System.Windows.Forms.ToolStripMenuItem searchmodifyremove;
        private System.Windows.Forms.TabPage Complaints_tab;
        private System.Windows.Forms.TableLayoutPanel complaint_tablelayoutpanel;
        private System.Windows.Forms.DataGridView complaintsdatagridview;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addcomplaintstrip;
        private System.Windows.Forms.ToolStripMenuItem complaints_srm;
        private System.Windows.Forms.TabPage bill_tab;
        private System.Windows.Forms.TableLayoutPanel billings_LayoutPanel;
        private System.Windows.Forms.DataGridView billdatagridview;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem _addbill;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
       // private isp_mgmt_dbDataSet1 isp_mgmt_dbDataSet1;
        private System.Windows.Forms.BindingSource complainDetailsBindingSource;
        //private isp_mgmt_dbDataSet1TableAdapters.ComplainDetailsTableAdapter complainDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn complainIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn problemStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
      //  private isp_mgmt_dbDataSet2 isp_mgmt_dbDataSet2;
        private System.Windows.Forms.BindingSource billingBindingSource;
      //  private isp_mgmt_dbDataSet2TableAdapters.BillingTableAdapter billingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentBillDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousDueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoicePeriodDataGridViewTextBoxColumn;
    }
}