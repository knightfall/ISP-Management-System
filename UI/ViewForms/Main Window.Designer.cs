namespace UI.ViewForms
{
    partial class Main_Window
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
            this.root_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.tabpage_tablepanel = new System.Windows.Forms.TableLayoutPanel();
            this.Buton_panel = new System.Windows.Forms.Panel();
            this.searchbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.load_data = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.root_table_panel.SuspendLayout();
            this.tabpage_tablepanel.SuspendLayout();
            this.Buton_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // root_table_panel
            // 
            this.root_table_panel.BackColor = System.Drawing.SystemColors.Control;
            this.root_table_panel.ColumnCount = 1;
            this.root_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root_table_panel.Controls.Add(this.tabpage_tablepanel, 0, 0);
            this.root_table_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root_table_panel.Location = new System.Drawing.Point(0, 0);
            this.root_table_panel.Name = "root_table_panel";
            this.root_table_panel.RowCount = 1;
            this.root_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 553F));
            this.root_table_panel.Size = new System.Drawing.Size(1371, 553);
            this.root_table_panel.TabIndex = 0;
            // 
            // tabpage_tablepanel
            // 
            this.tabpage_tablepanel.ColumnCount = 2;
            this.tabpage_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpage_tablepanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tabpage_tablepanel.Controls.Add(this.Buton_panel, 1, 0);
            this.tabpage_tablepanel.Controls.Add(this.dataGridView1, 0, 0);
            this.tabpage_tablepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabpage_tablepanel.Location = new System.Drawing.Point(3, 3);
            this.tabpage_tablepanel.Name = "tabpage_tablepanel";
            this.tabpage_tablepanel.RowCount = 1;
            this.tabpage_tablepanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabpage_tablepanel.Size = new System.Drawing.Size(1365, 547);
            this.tabpage_tablepanel.TabIndex = 0;
            // 
            // Buton_panel
            // 
            this.Buton_panel.Controls.Add(this.searchbutton);
            this.Buton_panel.Controls.Add(this.Addbutton);
            this.Buton_panel.Controls.Add(this.load_data);
            this.Buton_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Buton_panel.Location = new System.Drawing.Point(1284, 1);
            this.Buton_panel.Margin = new System.Windows.Forms.Padding(1);
            this.Buton_panel.Name = "Buton_panel";
            this.Buton_panel.Size = new System.Drawing.Size(80, 545);
            this.Buton_panel.TabIndex = 2;
            // 
            // searchbutton
            // 
            this.searchbutton.AutoEllipsis = true;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchbutton.Image = global::UI.Properties.Resources._1408063780_175177;
            this.searchbutton.Location = new System.Drawing.Point(0, 208);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 72);
            this.searchbutton.TabIndex = 0;
            this.searchbutton.Text = "Search";
            this.searchbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.AutoEllipsis = true;
            this.Addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Addbutton.Image = global::UI.Properties.Resources._1408063035_174654;
            this.Addbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Addbutton.Location = new System.Drawing.Point(0, 120);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 72);
            this.Addbutton.TabIndex = 0;
            this.Addbutton.Text = "Add";
            this.Addbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // load_data
            // 
            this.load_data.AutoEllipsis = true;
            this.load_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.load_data.Image = global::UI.Properties.Resources._1408062297_175527;
            this.load_data.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.load_data.Location = new System.Drawing.Point(0, 32);
            this.load_data.Name = "load_data";
            this.load_data.Size = new System.Drawing.Size(75, 72);
            this.load_data.TabIndex = 0;
            this.load_data.Text = "Load";
            this.load_data.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.load_data.UseVisualStyleBackColor = true;
            this.load_data.Click += new System.EventHandler(this.load_data_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1277, 541);
            this.dataGridView1.TabIndex = 3;
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 553);
            this.Controls.Add(this.root_table_panel);
            this.Name = "Main_Window";
            this.Text = "Main_Window";
            this.root_table_panel.ResumeLayout(false);
            this.tabpage_tablepanel.ResumeLayout(false);
            this.Buton_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root_table_panel;
        private System.Windows.Forms.TableLayoutPanel tabpage_tablepanel;
        private System.Windows.Forms.Panel Buton_panel;
        private System.Windows.Forms.Button load_data;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}