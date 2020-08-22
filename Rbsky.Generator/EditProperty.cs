using Rbsky.Generator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rbsky.Generator
{
    public partial class EditProperty : Form
    {
        public EditProperty()
        {
            InitializeComponent();
        }
        public PropertyModels Model { get; set; }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Model == null)
                Model = new PropertyModels();
            Model.PropertyType = comType.Text;
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("输入字段名称");
                return;
            }
            Model.PropertyName = txtName.Text;
            Model.PropertyDescription = txtDescription.Text;
            Model.IsFilter = ckIsFilter.Checked;
            Model.IsShowInList = ckIsListView.Checked;
            Model.IsCreateOrEdit = ckIsEdit.Checked;
            Model.IsRequired = ckIsRequired.Checked;
            Model.MinLength = (int)minLength.Value;
            Model.MaxLength = (int)maxLength.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditProperty_Load(object sender, EventArgs e)
        {
            comType.SelectedIndex = 0;
            if (Model != null)
            {
                comType.Text = Model.PropertyType;
                txtName.Text = Model.PropertyName;
                txtDescription.Text = Model.PropertyDescription;
                ckIsFilter.Checked = Model.IsFilter;
                ckIsListView.Checked = Model.IsShowInList;
                ckIsEdit.Checked = Model.IsCreateOrEdit;
                ckIsRequired.Checked = Model.IsRequired;
                minLength.Value = Model.MinLength;
                maxLength.Value = Model.MaxLength;
            }
            txtName.Focus();
        }
    }
}
