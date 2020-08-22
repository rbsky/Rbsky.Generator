using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbsky.Generator.Models
{
    public class PropertyModels
    {
        public int Id { get; set; }
        /// <summary>
        /// 字段名称
        /// </summary>
        public string PropertyName { get; set; }
        /// <summary>
        /// 首字母小写名称
        /// </summary>
        public string PropertyLowerName { get; set; }
        /// <summary>
        /// 字段注释
        /// </summary>
        public string PropertyDescription { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string PropertyType { get; set; }
        /// <summary>
        /// 查询过滤字段
        /// </summary>
        public bool IsFilter { get; set; }
        /// <summary>
        /// 是查询列表字段
        /// </summary>
        public bool IsShowInList { get; set; }
        /// <summary>
        /// 是编辑页面字段
        /// </summary>
        public bool IsCreateOrEdit { get; set; }
        /// <summary>
        /// 必填字段
        /// </summary>
        public bool IsRequired { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }
    }
}
