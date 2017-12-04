namespace UI.ViewForms
{
    partial class Add_Complaint
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.complaintdata = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._compidtextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._probdate = new System.Windows.Forms.DateTimePicker();
            this._problemcombo = new System.Windows.Forms.ComboBox();
            this.problem_details = new System.Windows.Forms.RichTextBox();
            this.cdtextbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.clientidretrieverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientidretrieverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(490, 504);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42975F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57025F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.complaintdata, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._compidtextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this._probdate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this._problemcombo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.problem_details, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cdtextbox, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6962F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complain ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complaintdata
            // 
            this.complaintdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaintdata.AutoSize = true;
            this.complaintdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.complaintdata.Location = new System.Drawing.Point(140, 0);
            this.complaintdata.Name = "complaintdata";
            this.complaintdata.Size = new System.Drawing.Size(342, 20);
            this.complaintdata.TabIndex = 2;
            this.complaintdata.Text = "           Complaints Data";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Problem Details";
            // 
            // _compidtextbox
            // 
            this._compidtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._compidtextbox.Location = new System.Drawing.Point(140, 38);
            this._compidtextbox.Name = "_compidtextbox";
            this._compidtextbox.ReadOnly = true;
            this._compidtextbox.Size = new System.Drawing.Size(342, 26);
            this._compidtextbox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 183);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Problem Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // _probdate
            // 
            this._probdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._probdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._probdate.Location = new System.Drawing.Point(140, 236);
            this._probdate.Name = "_probdate";
            this._probdate.Size = new System.Drawing.Size(342, 26);
            this._probdate.TabIndex = 3;
            this._probdate.ValueChanged += new System.EventHandler(this._probdate_ValueChanged);
            this._probdate.CustomFormat = "dd-MM-yy:h-mm";
            // 
            // _problemcombo
            // 
            this._problemcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._problemcombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._problemcombo.FormattingEnabled = true;
            this._problemcombo.Items.AddRange(new object[] {
            "Initiated",
            "Unresolved",
            "Resolved"});
            this._problemcombo.Location = new System.Drawing.Point(140, 186);
            this._problemcombo.Name = "_problemcombo";
            this._problemcombo.Size = new System.Drawing.Size(342, 28);
            this._problemcombo.TabIndex = 6;
            // 
            // problem_details
            // 
            this.problem_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.problem_details.Location = new System.Drawing.Point(140, 128);
            this.problem_details.Name = "problem_details";
            this.problem_details.Size = new System.Drawing.Size(342, 32);
            this.problem_details.TabIndex = 7;
            this.problem_details.Text = "";
            // 
            // cdtextbox
            // 
            this.cdtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cdtextbox.Location = new System.Drawing.Point(140, 82);
            this.cdtextbox.Name = "cdtextbox";
            this.cdtextbox.Size = new System.Drawing.Size(342, 26);
            this.cdtextbox.TabIndex = 1;
            this.cdtextbox.TextChanged += new System.EventHandler(this.cdtextbox_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Location = new System.Drawing.Point(3, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 34);
            this.panel1.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(250, 1);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 32);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Clear";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(138, 1);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(96, 32);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Add_Complaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 504);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Add_Complaint";
            this.Text = "Add_Complaint";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientidretrieverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _compidtextbox;
        private System.Windows.Forms.DateTimePicker _probdate;
        protected System.Windows.Forms.Label complaintdata;
        private System.Windows.Forms.Panel panel1;
       // private clientidretriever clientidretriever;
        private System.Windows.Forms.BindingSource clientidretrieverBindingSource;
        //private clientidretrieverTableAdapters.clientidretrieverTableAdapter clientidretrieverTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox _problemcombo;
        private System.Windows.Forms.RichTextBox problem_details;
        private System.Windows.Forms.TextBox cdtextbox;
    }
}