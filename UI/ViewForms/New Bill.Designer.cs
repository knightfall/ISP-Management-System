namespace UI.ViewForms
{
    partial class New_Bill
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
            this.billdatapanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.billIDtextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billdate = new System.Windows.Forms.DateTimePicker();
            this._previousduetextbox = new System.Windows.Forms.TextBox();
            this.complaintdata = new System.Windows.Forms.Label();
            this.currentbill = new System.Windows.Forms.TextBox();
            this.cdtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._paid = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.billdatapanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billdatapanel
            // 
            this.billdatapanel.ColumnCount = 2;
            this.billdatapanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.42975F));
            this.billdatapanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.57025F));
            this.billdatapanel.Controls.Add(this.label3, 0, 2);
            this.billdatapanel.Controls.Add(this.label1, 0, 1);
            this.billdatapanel.Controls.Add(this.label9, 0, 3);
            this.billdatapanel.Controls.Add(this.billIDtextbox, 1, 1);
            this.billdatapanel.Controls.Add(this.label10, 0, 4);
            this.billdatapanel.Controls.Add(this.label2, 0, 5);
            this.billdatapanel.Controls.Add(this.billdate, 1, 5);
            this.billdatapanel.Controls.Add(this._previousduetextbox, 1, 4);
            this.billdatapanel.Controls.Add(this.complaintdata, 1, 0);
            this.billdatapanel.Controls.Add(this.currentbill, 1, 3);
            this.billdatapanel.Controls.Add(this.cdtextbox, 1, 2);
            this.billdatapanel.Controls.Add(this.label4, 0, 6);
            this.billdatapanel.Controls.Add(this._paid, 1, 6);
            this.billdatapanel.Location = new System.Drawing.Point(0, 8);
            this.billdatapanel.Name = "billdatapanel";
            this.billdatapanel.RowCount = 7;
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.3038F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.6962F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.billdatapanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.billdatapanel.Size = new System.Drawing.Size(480, 328);
            this.billdatapanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Client ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(3, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Current Bill";
            // 
            // billIDtextbox
            // 
            this.billIDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billIDtextbox.Location = new System.Drawing.Point(139, 41);
            this.billIDtextbox.Name = "billIDtextbox";
            this.billIDtextbox.ReadOnly = true;
            this.billIDtextbox.Size = new System.Drawing.Size(338, 26);
            this.billIDtextbox.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(3, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Previous Due";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Invoice Period";
            // 
            // billdate
            // 
            this.billdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.billdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.billdate.Location = new System.Drawing.Point(139, 243);
            this.billdate.Name = "billdate";
            this.billdate.Size = new System.Drawing.Size(338, 26);
            this.billdate.TabIndex = 3;
            this.billdate.ValueChanged += new System.EventHandler(this.billdate_ValueChanged);
            // 
            // _previousduetextbox
            // 
            this._previousduetextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._previousduetextbox.Location = new System.Drawing.Point(139, 193);
            this._previousduetextbox.Name = "_previousduetextbox";
            this._previousduetextbox.Size = new System.Drawing.Size(338, 26);
            this._previousduetextbox.TabIndex = 1;
            // 
            // complaintdata
            // 
            this.complaintdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.complaintdata.AutoSize = true;
            this.complaintdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.complaintdata.Location = new System.Drawing.Point(139, 0);
            this.complaintdata.Name = "complaintdata";
            this.complaintdata.Size = new System.Drawing.Size(338, 20);
            this.complaintdata.TabIndex = 2;
            this.complaintdata.Text = "               Bill Data";
            // 
            // currentbill
            // 
            this.currentbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.currentbill.Location = new System.Drawing.Point(139, 135);
            this.currentbill.Name = "currentbill";
            this.currentbill.Size = new System.Drawing.Size(338, 26);
            this.currentbill.TabIndex = 1;
            // 
            // cdtextbox
            // 
            this.cdtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cdtextbox.Location = new System.Drawing.Point(139, 89);
            this.cdtextbox.Name = "cdtextbox";
            this.cdtextbox.Size = new System.Drawing.Size(338, 26);
            this.cdtextbox.TabIndex = 4;
            this.cdtextbox.TextChanged += new System.EventHandler(this.cdtextbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(3, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Paid";
            // 
            // _paid
            // 
            this._paid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._paid.FormattingEnabled = true;
            this._paid.Items.AddRange(new object[] {
            "Unpaid",
            "Paid"});
            this._paid.Location = new System.Drawing.Point(139, 289);
            this._paid.Name = "_paid";
            this._paid.Size = new System.Drawing.Size(338, 28);
            this._paid.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 34);
            this.panel1.TabIndex = 3;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(264, 0);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(96, 32);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Clear";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(152, 0);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(96, 32);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // New_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 402);
            this.Controls.Add(this.billdatapanel);
            this.Controls.Add(this.panel1);
            this.Name = "New_Bill";
            this.Text = "New Bill";
            this.billdatapanel.ResumeLayout(false);
            this.billdatapanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel billdatapanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox billIDtextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker billdate;
        private System.Windows.Forms.TextBox _previousduetextbox;
        protected System.Windows.Forms.Label complaintdata;
        private System.Windows.Forms.TextBox currentbill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox cdtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _paid;
    }
}