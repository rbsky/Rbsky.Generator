using RazorEngine;
using RazorEngine.Templating;
using Rbsky.Generator.Models;
using Rbsky.Generator.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Rbsky.Generator
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
        }
        private delegate void BulidDelegate(TemplateParseModel templateParseModel);
        public BindingList<PropertyModels> dataList = new BindingList<PropertyModels>();
        private void Form1_Load(object sender, EventArgs e)
        {
            comBaseClass.SelectedIndex = 0;
            comPrimaryKey.SelectedIndex = 0;
            dataGridView1.DataSource = dataList;
            tabControl2.ShowToolTips = true;
            txtOutPath.Text = UtilHelper.AppSettingValue("OutPath");
            //模拟数据
            //txtEntityName.Text = "Item";
            //txtNameSpace.Text = "Product.BD";
            //ckAngualr.Checked = true;
            //dataList.Add(new PropertyModels
            //{
            //    Id=1,
            //    IsShowInList=true,
            //    PropertyName = "Code",
            //    PropertyType = "string"
            //});
        }

        private void btnCheckFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择项目根路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtOutPath.Text = dialog.SelectedPath;
            }
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //添加行号
            dataGridView1.RowHeadersWidth = 30;
            System.Drawing.Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Y, this.dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), this.dataGridView1.RowHeadersDefaultCellStyle.Font, rectangle, this.dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        private void btnPreView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEntityName.Text))
            {
                statusLabel.Text = "请输入实体名称！";
                return;
            }
            if (string.IsNullOrEmpty(txtNameSpace.Text))
            {
                statusLabel.Text = "请输入命名空间！";
                return;
            }
            if (dataList.Count == 0)
            {
                statusLabel.Text = "请添加属性字段！";
                return;
            }
            var templateParseModel = new TemplateParseModel()
            {
                EntityName = txtEntityName.Text,
                EntityNameLower = txtEntityName.Text.ToLowerFirstword(),
                AngularEntityName = txtEntityName.Text.ToCustomName(),
                EntityDescription = txtDescription.Text,
                NameSpace = txtNameSpace.Text,
                EntityBaseClass = comBaseClass.Text,
                EntityKeyType = comPrimaryKey.Text,
                IsModalForm = radioButton1.Checked ? 1 : 2,
                ClounmInfos = dataList.ToList()
            };
            templateParseModel.ClounmInfos.ForEach((p) =>
            {
                p.PropertyLowerName = p.PropertyName.ToLowerFirstword();
            });
            Task.Run(() =>
            {
                tabControl2.Invoke(new BulidDelegate(build), templateParseModel);
            });


        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            var f = new EditProperty();
            var rst = f.ShowDialog();
            if (rst == DialogResult.OK)
            {
                f.Model.Id = dataList.Count + 1;
                dataList.Add(f.Model);
            }

        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var model = dataGridView1.SelectedRows[0].DataBoundItem as PropertyModels;
                dataList.Remove(model);
            }
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var model = dataGridView1.SelectedRows[0].DataBoundItem as PropertyModels;
                var f = new EditProperty();
                f.Model = model;
                var rst = f.ShowDialog();
                if (rst == DialogResult.OK)
                {
                    dataList[model.Id - 1] = f.Model;
                    //model = f.Model;
                }
            }
        }

        private void tabControl2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl2.TabPages.RemoveAt(tabControl2.SelectedIndex);
        }

        private void build(TemplateParseModel templateParseModel)
        {
            if (ckDonet.Checked)
            {
                CreateTabComent($"{txtEntityName.Text}.cs", GeneratorHelper.BuildEntity(templateParseModel, txtOutPath.Text));
                CreateTabComent($"{txtEntityName.Text}ListDto.cs", GeneratorHelper.BuildListDto(templateParseModel, txtOutPath.Text));
                CreateTabComent($"{txtEntityName.Text}EditDto.cs", GeneratorHelper.BuildEditDto(templateParseModel, txtOutPath.Text));
                CreateTabComent($"Get{txtEntityName.Text}ForEditDto.cs", GeneratorHelper.BuildGetForEditDto(templateParseModel, txtOutPath.Text));
                CreateTabComent($"{txtEntityName.Text}PagedInput.cs", GeneratorHelper.BuildPagedInputDto(templateParseModel, txtOutPath.Text));
                CreateTabComent($"I{txtEntityName.Text}AppService.cs", GeneratorHelper.BuildAppServiceInterface(templateParseModel, txtOutPath.Text));
                CreateTabComent($"{txtEntityName.Text}AppService.cs", GeneratorHelper.BuildAppService(templateParseModel, txtOutPath.Text));
                CreateTabComent($"CustomDtoMapper.cs", GeneratorHelper.BuildMapper(templateParseModel, txtOutPath.Text));

            }
            if (ckAngualr.Checked)
            {
                CreateTabComent($"{templateParseModel.AngularEntityName}.component.ts", GeneratorHelper.BuildNgListComponent(templateParseModel, txtOutPath.Text));
                CreateTabComent($"{templateParseModel.AngularEntityName}.component.html", GeneratorHelper.BuildNgListComponentHtml(templateParseModel, txtOutPath.Text));
                if (radioButton1.Checked)
                {
                    CreateTabComent($"create-or-edit-{templateParseModel.AngularEntityName}.component.ts", GeneratorHelper.BuildNgEditComponent(templateParseModel, txtOutPath.Text));
                    CreateTabComent($"create-or-edit-{templateParseModel.AngularEntityName}.component.html", GeneratorHelper.BuildNgEditComponentHtml(templateParseModel, txtOutPath.Text));
                }
                if (radioButton2.Checked)
                {
                    CreateTabComent($"create-or-edit-{templateParseModel.AngularEntityName}.component.ts", GeneratorHelper.BuildNgTabEditComponent(templateParseModel, txtOutPath.Text));
                    CreateTabComent($"create-or-edit-{templateParseModel.AngularEntityName}.component.html", GeneratorHelper.BuildNgTabEditComponentHtml(templateParseModel, txtOutPath.Text));
                }
            }
        }
        private void CreateTabComent(string tabName, string text)
        {
            var tab = new TabPage() { Name = tabName, Text = tabName, ToolTipText = "双击关闭" };
            var txt1 = new RichTextBox();
            txt1.Dock = DockStyle.Fill;
            txt1.Text = text;
            tab.Controls.Add(txt1);
            if (tabControl2.TabPages[tabName] != null)
            {
                foreach (Control item in tabControl2.TabPages[tabName].Controls)
                {
                    if (item is RichTextBox)
                    {
                        item.Text = text;
                        return;
                    }
                }
            }
            else
            {
                tabControl2.TabPages.Add(tab);
            }

        }
    }
}
