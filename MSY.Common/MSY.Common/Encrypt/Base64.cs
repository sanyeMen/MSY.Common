using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSY.Common.Encrypt
{
    /// <summary>
    /// 提供Base64加密和解密方法
    /// </summary>
    public sealed class Base64
    {
        /// <summary>
        /// Base64加密，不带编码，使用系统默认编码
        /// </summary>
        /// <param name="input">需要加密的字符串</param>
        /// <returns></returns>
        public static string Base64Encrypt(string input)
        {
            return Base64Encrypt(input, Encoding.Default);
        }

        /// <summary>
        /// Base64加密，带编码
        /// </summary>
        /// <param name="input">需要加密的字符串</param>
        /// <param name="encode">字符集编码</param>
        /// <returns>如果需要加密的字符串是null，返回null</returns>
        public static string Base64Encrypt(string input, Encoding encode)
        {
            if (input == null)
                return null;

            if (encode == null)
                encode = Encoding.Default;

            return Convert.ToBase64String(encode.GetBytes(input));
        }

        /// <summary>
        /// Base64解密，不带编码，使用系统默认编码
        /// </summary>
        /// <param name="input">需要解密的字符串</param>
        /// <returns></returns>
        public static string Base64Decrypt(string input)
        {
            return Base64Decrypt(input, Encoding.Default);
        }

        /// <summary>
        /// Base64解密，带编码
        /// </summary>
        /// <param name="input">需要解密的字符串</param>
        /// <param name="encode">字符集编码</param>
        /// <returns>如果需要解密的字符串是null，返回null</returns>
        public static string Base64Decrypt(string input, Encoding encode)
        {
            if (input == null)
                return null;

            if(encode == null)
                encode = Encoding.Default;

            return encode.GetString(Convert.FromBase64String(input));
        }
    }
}
