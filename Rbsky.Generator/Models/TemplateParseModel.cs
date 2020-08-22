using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbsky.Generator.Models
{
    /// <summary>
    /// 模板解析类
    /// </summary>
    public class TemplateParseModel
    {
        /// <summary>
        /// 命名空间
        /// </summary>
        public string NameSpace { get; set; }

        /// <summary>
        /// 实体名称
        /// </summary>
        public string EntityName { get; set; }
        /// <summary>
        /// 首字母小写的实体名称
        /// </summary>
        public string EntityNameLower { get; set; }
        /// <summary>
        /// angular组件的命名
        /// </summary>
        public string AngularEntityName { get; set; }
        /// <summary>
        /// 实体描述
        /// </summary>
        public string EntityDescription { get; set; }
        /// <summary>
        /// 实体主键类型
        /// </summary>
        public string EntityKeyType { get; set; }
        /// <summary>
        /// 实体基类
        /// </summary>
        public string EntityBaseClass { get; set; }
        /// <summary>
        /// 弹窗编辑
        /// </summary>
        public int IsModalForm { get; set; }
        public List<PropertyModels> ClounmInfos { get; set; }
    }
}
