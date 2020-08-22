using RazorEngine;
using RazorEngine.Templating;
using Rbsky.Generator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rbsky.Generator
{
    public static class GeneratorHelper
    {
        /// <summary>
        /// 生成实体类
        /// </summary>
        /// <param name="templateParseModel"></param>
        /// <param name="outPath"></param>
        /// <returns></returns>
        public static string BuildEntity(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorEntity.txt");
            var templateEntity = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateEntity, nameof(templateEntity), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.EntityName}.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成listdto
        /// </summary>
        /// <param name="templateParseModel"></param>
        /// <param name="outPath"></param>
        /// <returns></returns>
        public static string BuildListDto(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorListDto.txt");
            var templateListDto = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateListDto, nameof(templateListDto), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s\\dtos");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.EntityName}ListDto.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成EditDto
        /// </summary>
        /// <param name="templateParseModel"></param>
        /// <param name="outPath"></param>
        /// <returns></returns>
        public static string BuildEditDto(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorEditDto.txt");
            var templateEditDto = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateEditDto, nameof(templateEditDto), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s\\dtos");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.EntityName}EditDto.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成GetForEditDto
        /// </summary>
        /// <returns></returns>
        public static string BuildGetForEditDto(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorGetForEditDto.txt");
            var templateGetForEditDto = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateGetForEditDto, nameof(templateGetForEditDto), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s\\dtos");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"Get{templateParseModel.EntityName}ForEditDto.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }

        /// <summary>
        /// 分页查询输入Dto
        /// </summary>
        /// <param name="templateParseModel"></param>
        /// <param name="outPath"></param>
        /// <returns></returns>
        public static string BuildPagedInputDto(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorPagedInput.txt");
            var templatePagedInputDto = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templatePagedInputDto, nameof(templatePagedInputDto), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s\\dtos");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.EntityName}PagedInput.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成服务接口
        /// </summary>
        public static string BuildAppServiceInterface(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "IRazorAppService.txt");
            var templateInterface = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateInterface, nameof(templateInterface), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"I{templateParseModel.EntityName}AppService.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成服务
        /// </summary>
        public static string BuildAppService(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorAppService.txt");
            var templateAppService = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateAppService, nameof(templateAppService), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.EntityName}AppService.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 生成Mapper
        /// </summary>
        public static string BuildMapper(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "RazorMapper.txt");
            var templateMapper = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateMapper, nameof(templateMapper), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"CustomDtoMapper.cs");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 创建angular 查询组件
        /// </summary>
        /// <returns></returns>
        public static string BuildNgListComponent(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgListComponent.txt");
            var templateListComponent = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateListComponent, nameof(templateListComponent), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.AngularEntityName}.component.ts");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }

        /// <summary>
        /// 创建angular 查询组件Html
        /// </summary>
        /// <returns></returns>
        public static string BuildNgListComponentHtml(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgListComponentHtml.txt");
            var templateListComponentHtml = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateListComponentHtml, nameof(templateListComponentHtml), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"{templateParseModel.AngularEntityName}.component.html");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 创建angular 创建、编辑组件
        /// </summary>
        /// <returns></returns>
        public static string BuildNgEditComponent(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgEditComponent.txt");
            var templateEditComponent = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateEditComponent, nameof(templateEditComponent), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"create-or-edit-{templateParseModel.AngularEntityName}.component.ts");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 创建angular 创建、编辑组件Html
        /// </summary>
        /// <returns></returns>
        public static string BuildNgEditComponentHtml(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgEditComponentHtml.txt");
            var templateEditComponentHtml = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateEditComponentHtml, nameof(templateEditComponentHtml), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"create-or-edit-{templateParseModel.AngularEntityName}.component.html");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }

        /// <summary>
        /// 创建angular 创建、编辑组件
        /// </summary>
        /// <returns></returns>
        public static string BuildNgTabEditComponent(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgTabEditComponent.txt");
            var templateTabEditComponent = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateTabEditComponent, nameof(templateTabEditComponent), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"create-or-edit-{templateParseModel.AngularEntityName}.component.ts");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }
        /// <summary>
        /// 创建angular 创建、编辑组件Html
        /// </summary>
        /// <returns></returns>
        public static string BuildNgTabEditComponentHtml(TemplateParseModel templateParseModel, string outPath = "")
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates", "NgTabEditComponentHtml.txt");
            var templateTabEditComponentHtml = File.ReadAllText(filePath);
            var rest = Engine.Razor.RunCompile(templateTabEditComponentHtml, nameof(templateTabEditComponentHtml), typeof(TemplateParseModel), templateParseModel);
            if (!outPath.IsNullOrEmpty())
            {
                string folder = Path.Combine(outPath, $"{templateParseModel.EntityName}s", "angular");
                if (!System.IO.Directory.Exists(folder))
                {
                    System.IO.Directory.CreateDirectory(folder);
                }
                string fullName = Path.Combine(folder, $"create-or-edit-{templateParseModel.AngularEntityName}.component.html");
                File.WriteAllText(fullName, rest);

            }
            return rest;
        }

    }
}
