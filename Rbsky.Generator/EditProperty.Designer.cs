namespace Rbsky.Generator
{
    partial class EditProperty
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxLength = new System.Windows.Forms.NumericUpDown();
            this.minLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ckIsRequired = new System.Windows.Forms.CheckBox();
            this.ckIsEdit = new System.Windows.Forms.CheckBox();
            this.ckIsListView = new System.Windows.Forms.CheckBox();
            this.ckIsFilter = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(371, 429);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(139, 35);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(226, 429);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 35);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.maxLength);
            this.groupBox1.Controls.Add(this.minLength);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ckIsRequired);
            this.groupBox1.Controls.Add(this.ckIsEdit);
            this.groupBox1.Controls.Add(this.ckIsListView);
            this.groupBox1.Controls.Add(this.ckIsFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comType);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 411);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "字段描述：";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(160, 121);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 28);
            this.txtDescription.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "-";
            // 
            // maxLength
            // 
            this.maxLength.Location = new System.Drawing.Point(313, 249);
            this.maxLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxLength.Name = "maxLength";
            this.maxLength.Size = new System.Drawing.Size(96, 28);
            this.maxLength.TabIndex = 7;
            this.maxLength.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // minLength
            // 
            this.minLength.Location = new System.Drawing.Point(164, 249);
            this.minLength.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minLength.Name = "minLength";
            this.minLength.Size = new System.Drawing.Size(96, 28);
            this.minLength.TabIndex = 6;
            this.minLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "最小-最大长度";
            // 
            // ckIsRequired
            // 
            this.ckIsRequired.AutoSize = true;
            this.ckIsRequired.Location = new System.Drawing.Point(202, 205);
            this.ckIsRequired.Name = "ckIsRequired";
            this.ckIsRequired.Size = new System.Drawing.Size(106, 22);
            this.ckIsRequired.TabIndex = 5;
            this.ckIsRequired.Text = "必填字段";
            this.ckIsRequired.UseVisualStyleBackColor = true;
            // 
            // ckIsEdit
            // 
            this.ckIsEdit.AutoSize = true;
            this.ckIsEdit.Location = new System.Drawing.Point(48, 205);
            this.ckIsEdit.Name = "ckIsEdit";
            this.ckIsEdit.Size = new System.Drawing.Size(106, 22);
            this.ckIsEdit.TabIndex = 4;
            this.ckIsEdit.Text = "编辑字段";
            this.ckIsEdit.UseVisualStyleBackColor = true;
            // 
            // ckIsListView
            // 
            this.ckIsListView.AutoSize = true;
            this.ckIsListView.Location = new System.Drawing.Point(202, 163);
            this.ckIsListView.Name = "ckIsListView";
            this.ckIsListView.Size = new System.Drawing.Size(106, 22);
            this.ckIsListView.TabIndex = 3;
            this.ckIsListView.Text = "列表字段";
            this.ckIsListView.UseVisualStyleBackColor = true;
            // 
            // ckIsFilter
            // 
            this.ckIsFilter.AutoSize = true;
            this.ckIsFilter.Location = new System.Drawing.Point(48, 163);
            this.ckIsFilter.Name = "ckIsFilter";
            this.ckIsFilter.Size = new System.Drawing.Size(106, 22);
            this.ckIsFilter.TabIndex = 2;
            this.ckIsFilter.Text = "筛选字段";
            this.ckIsFilter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "字段名称：";
            // 
            // comType
            // 
            this.comType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comType.FormattingEnabled = true;
            this.comType.Items.AddRange(new object[] {
            "string",
            "int",
            "long",
            "double",
            "DateTime",
            "short",
            "Guid",
            "byte",
            "bool"});
            this.comType.Location = new System.Drawing.Point(160, 25);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(184, 26);
            this.comType.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(184, 28);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "字段类型：";
            // 
            // EditProperty
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 476);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "属性";
            this.Load += new System.EventHandler(this.EditProperty_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckIsRequired;
        private System.Windows.Forms.CheckBox ckIsEdit;
        private System.Windows.Forms.CheckBox ckIsListView;
        private System.Windows.Forms.CheckBox ckIsFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maxLength;
        private System.Windows.Forms.NumericUpDown minLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
    }
}