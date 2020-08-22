using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Rbsky.Generator
{
    /// <summary>
    /// 字符串扩展方法
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// 字符串转值类型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="valueAsString"></param>
        /// <returns></returns>
        public static T? GetValueOrNull<T>(this string valueAsString)
            where T : struct
        {
            if (string.IsNullOrEmpty(valueAsString))
                return null;
            return (T)Convert.ChangeType(valueAsString, typeof(T));
        }
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrEmpty(str);
        }
        /// <summary>
        /// 转小写并用-拼接
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string ToCustomName(this string str)
        {
            if (!Regex.IsMatch(str, "[A-Z]"))
            {
                return str;
            }
            var list = str.ToCharArray();
            string rest = "";
            bool isFirst = true;
            foreach (char item in list)
            {
                if (Regex.IsMatch(item.ToString(), "[A-Z]") && !isFirst)
                {
                    rest += ("-" + item.ToString().ToLower());
                }
                else
                {
                    rest += item.ToString().ToLower();
                }
                isFirst = false;
            }
            return rest;
        }
    }
}
