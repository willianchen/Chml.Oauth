using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Tools.Auth
{
    public class LinkinHelper : AuthHelper
    {
        public static Tools.Entity.LoginExt GetXmlData(string xml)
        {
            return null;
        }

        /// <summary>
        /// API获取令牌
        /// by:willian date:2016-11-18
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static AuthToken GetToken(string code, string returnUrl = LinkinConfig.ReturnUrl)
        {
            return GetToken(code, LinkinConfig.TokenUrl, LinkinConfig.ClientId, LinkinConfig.ClientSecret, returnUrl);
        }

        /// <summary>
        /// 获取个人资料
        /// by:willian date:2016-11-18
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static Entity.LoginExt GetProFile(string accessToken)
        {
            var profile = GetProFileAuth(accessToken, LinkinConfig.ProfileResourceUrl);
            Entity.LoginExt entity = GetXmlData(profile);
            return entity;
        }
    }
}
