﻿using System.ComponentModel.DataAnnotations;

namespace Masuit.Tools.Validator
{
    /// <summary>
    /// 验证IPv4地址是否合法
    /// </summary>
    public class IsIPAddressAttribute : ValidationAttribute
    {
        /// <summary>
        /// IPv4校验
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object value)
        {
            if (value is null)
            {
                ErrorMessage = "IP地址不能为空！";
                return false;
            }
            string ip = value as string;
            if (ip.MatchInetAddress())
            {
                return true;
            }
            ErrorMessage = "IP地址格式不正确，请输入有效的IPv4地址";
            return false;
        }
    }
}