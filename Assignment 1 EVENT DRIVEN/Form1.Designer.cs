using System.Diagnostics.Tracing;

namespace Assignment_1_EVENT_DRIVEN
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.lstTelephone = new System.Windows.Forms.ListBox();
            this.lstName = new System.Windows.Forms.ListBox();
            this.lstSurname = new System.Windows.Forms.ListBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.txtAddTelephone = new System.Windows.Forms.TextBox();
            this.txtAddSurname = new System.Windows.Forms.TextBox();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoTelephone = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoSurname = new System.Windows.Forms.RadioButton();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblProbes = new System.Windows.Forms.Label();
            this.txtSearchDisplay = new System.Windows.Forms.TextBox();
            this.lblSearchResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(1256, 873);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 160);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lstTelephone
            // 
            this.lstTelephone.AllowDrop = true;
            this.lstTelephone.FormattingEnabled = true;
            this.lstTelephone.ItemHeight = 32;
            this.lstTelephone.Location = new System.Drawing.Point(50, 324);
            this.lstTelephone.Name = "lstTelephone";
            this.lstTelephone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstTelephone.Size = new System.Drawing.Size(285, 548);
            this.lstTelephone.TabIndex = 1;
            this.lstTelephone.SelectedIndexChanged += new System.EventHandler(this.lstSurname_SelectedIndexChanged);
            this.lstTelephone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBox_MouseDown);
            // 
            // lstName
            // 
            this.lstName.FormattingEnabled = true;
            this.lstName.ItemHeight = 32;
            this.lstName.Location = new System.Drawing.Point(373, 324);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(285, 548);
            this.lstName.TabIndex = 2;
            this.lstName.SelectedIndexChanged += new System.EventHandler(this.lstSurname_SelectedIndexChanged);
            this.lstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBox_MouseDown);
            // 
            // lstSurname
            // 
            this.lstSurname.FormattingEnabled = true;
            this.lstSurname.ItemHeight = 32;
            this.lstSurname.Location = new System.Drawing.Point(695, 324);
            this.lstSurname.Name = "lstSurname";
            this.lstSurname.Size = new System.Drawing.Size(285, 548);
            this.lstSurname.TabIndex = 3;
            this.lstSurname.SelectedIndexChanged += new System.EventHandler(this.lstSurname_SelectedIndexChanged);
            this.lstSurname.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBox_MouseDown);
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelephone.Location = new System.Drawing.Point(39, 258);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(306, 45);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(373, 258);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 45);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurname.Location = new System.Drawing.Point(695, 258);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(152, 45);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // picDelete
            // 
            this.picDelete.AllowDrop = true;
            this.picDelete.Image = ((System.Drawing.Image)(resources.GetObject("picDelete.Image")));
            this.picDelete.Location = new System.Drawing.Point(1013, 324);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(129, 121);
            this.picDelete.TabIndex = 7;
            this.picDelete.TabStop = false;
            this.picDelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.picDelete_DragDrop);
            this.picDelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.picDelete_DragEnter);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1256, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(160, 160);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1256, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(160, 160);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Enabled = false;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1013, 469);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 46);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(394, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(373, 996);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(285, 39);
            this.txtAddName.TabIndex = 13;
            // 
            // txtAddTelephone
            // 
            this.txtAddTelephone.Location = new System.Drawing.Point(50, 996);
            this.txtAddTelephone.MaxLength = 11;
            this.txtAddTelephone.Name = "txtAddTelephone";
            this.txtAddTelephone.Size = new System.Drawing.Size(285, 39);
            this.txtAddTelephone.TabIndex = 12;
            // 
            // txtAddSurname
            // 
            this.txtAddSurname.Location = new System.Drawing.Point(695, 996);
            this.txtAddSurname.Name = "txtAddSurname";
            this.txtAddSurname.Size = new System.Drawing.Size(285, 39);
            this.txtAddSurname.TabIndex = 14;
            // 
            // btnAddContact
            // 
            this.btnAddContact.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddContact.Location = new System.Drawing.Point(1001, 989);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(171, 46);
            this.btnAddContact.TabIndex = 15;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = false;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(39, 63);
            this.txtSearch.MaxLength = 30;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 39);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // rdoTelephone
            // 
            this.rdoTelephone.AutoSize = true;
            this.rdoTelephone.Checked = true;
            this.rdoTelephone.Location = new System.Drawing.Point(11, 38);
            this.rdoTelephone.Name = "rdoTelephone";
            this.rdoTelephone.Size = new System.Drawing.Size(157, 36);
            this.rdoTelephone.TabIndex = 17;
            this.rdoTelephone.TabStop = true;
            this.rdoTelephone.Text = "Telephone";
            this.rdoTelephone.UseVisualStyleBackColor = true;
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(187, 38);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(109, 36);
            this.rdoName.TabIndex = 18;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoSurname
            // 
            this.rdoSurname.AutoSize = true;
            this.rdoSurname.Location = new System.Drawing.Point(302, 38);
            this.rdoSurname.Name = "rdoSurname";
            this.rdoSurname.Size = new System.Drawing.Size(140, 36);
            this.rdoSurname.TabIndex = 19;
            this.rdoSurname.Text = "Surname";
            this.rdoSurname.UseVisualStyleBackColor = true;
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.rdoSurname);
            this.grbSearch.Controls.Add(this.rdoName);
            this.grbSearch.Controls.Add(this.rdoTelephone);
            this.grbSearch.Location = new System.Drawing.Point(39, 130);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(505, 106);
            this.grbSearch.TabIndex = 20;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Search by:";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(1013, 826);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(150, 46);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(50, 893);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(154, 32);
            this.lblCount.TabIndex = 22;
            this.lblCount.Text = "List is empty!";
            // 
            // lblProbes
            // 
            this.lblProbes.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblProbes.AutoSize = true;
            this.lblProbes.Location = new System.Drawing.Point(550, 63);
            this.lblProbes.Name = "lblProbes";
            this.lblProbes.Size = new System.Drawing.Size(98, 32);
            this.lblProbes.TabIndex = 23;
            this.lblProbes.Text = "Probes: ";
            this.lblProbes.Visible = false;
            // 
            // txtSearchDisplay
            // 
            this.txtSearchDisplay.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSearchDisplay.Enabled = false;
            this.txtSearchDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchDisplay.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtSearchDisplay.Location = new System.Drawing.Point(695, 63);
            this.txtSearchDisplay.Multiline = true;
            this.txtSearchDisplay.Name = "txtSearchDisplay";
            this.txtSearchDisplay.Size = new System.Drawing.Size(285, 173);
            this.txtSearchDisplay.TabIndex = 24;
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Location = new System.Drawing.Point(695, 11);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(168, 32);
            this.lblSearchResult.TabIndex = 25;
            this.lblSearchResult.Text = "Search Result: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 1079);
            this.ControlBox = false;
            this.Controls.Add(this.lblSearchResult);
            this.Controls.Add(this.txtSearchDisplay);
            this.Controls.Add(this.lblProbes);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddContact);
            this.Controls.Add(this.txtAddSurname);
            this.Controls.Add(this.txtAddTelephone);
            this.Controls.Add(this.txtAddName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.picDelete);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lstSurname);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.lstTelephone);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  -- CONTACTS --   30012104";
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstTelephone;
        private System.Windows.Forms.ListBox lstName;
        private System.Windows.Forms.ListBox lstSurname;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.TextBox txtAddTelephone;
        private System.Windows.Forms.TextBox txtAddSurname;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdoTelephone;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoSurname;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblProbes;
        private System.Windows.Forms.TextBox txtSearchDisplay;
        private System.Windows.Forms.Label lblSearchResult;
    }
}

