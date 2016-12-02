using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chml.Oauth.Controllers.Base
{
    public class BaseController: Controller
    {
        #region Request方法
        /// <summary>
        /// Request一个数字
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int RequestInt(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return 0;
            }
            else
            {
                return v.ToInt32();
            }
        }
        /// <summary>
        /// Request一个Byte
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public byte RequestByte(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return 0;
            }
            else
            {
                return v.ToByte();
            }
        }

        /// <summary>
        /// Request一个Decimal
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public decimal RequestDecimal(string name)
        {
            string v = RequestString(name);
            decimal result = 0;
            if (decimal.TryParse(v, out result))
            {
                return result;
            }
            return 0;
        }
        /// <summary>
        /// Request一个布尔值
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool RequestBool(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                return false;
            }
            else
            {
                try
                {
                    return bool.Parse(v);
                }
                catch
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 请求一个字符串，返回null时返回空字符串
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string RequestString(string name)
        {
            string v = Request[name];
            if (v == null)
            {
                v = string.Empty;
            }
            return v.Trim();
        }






        /// <summary>
        /// 请求字符串类型
        /// </summary>
        /// <param name="requestStr">请求的Request值</param>
        /// <returns>返回字符串，null则返回""</returns>
        public string ConvertString(string requestStr)
        {
            return requestStr.ToString2();
        }

        /// <summary>
        ///   数字类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public int ConvertInt(string requestStr)
        {
            return requestStr.ToInt32();
        }

        /// <summary>
        /// 获得邮费
        /// </summary>
        /// <param name="Postage">邮费</param>
        /// <returns>（包邮或具体邮费）</returns>
        public string GetPostage(string Postage)
        {
            return Postage == "0" ? "包邮" : Postage;
        }

        /// <summary>
        ///   浮点类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public float ConvertFloat(string requestStr)
        {
            return requestStr.ToFloat();
        }

        /// <summary>
        ///   双精度类型值
        /// </summary>
        /// <param name="requestStr">获取request值</param>
        /// <returns>返回数字类型,空则返回0</returns>
        public decimal ConvertDecimal(string requestStr)
        {
            return requestStr.ToDecimal();
        }

        public Int32 ConvertObjectToInt(object requestStr)
        {
            try
            {
                return Convert.ToInt32(requestStr);
            }
            catch
            {
                return 0;
            }
        }

        public string ConvertObjectToStr(object requestStr)
        {
            try
            {
                return Convert.ToString(requestStr);
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// 转换成布尔型
        /// </summary>
        /// <param name="requestStr"></param>
        /// <returns></returns>
        public bool ConvertBoolean(string requestStr)
        {
            try
            {
                if (string.IsNullOrEmpty(requestStr))
                {
                    return false;
                }

                requestStr = requestStr.ToLower();
                if (requestStr == "1" || requestStr == "true")
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}