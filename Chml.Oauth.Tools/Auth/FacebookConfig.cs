using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Auth
{
    public class FacebookConfig
    {
        /// <summary>
        /// 客户端Id
        /// </summary>
        public const string ClientId = "***";

        /// <summary>
        ///  秘钥
        /// </summary>
        public const string ClientSecret = "***";

        /// <summary>
        /// 验证CodeURL
        /// </summary>
        public const string AuthCodeUrl = " https://www.facebook.com/dialog/oauth";
        /// <summary>
        /// 获取token URL
        /// </summary>
        public const string TokenUrl = "https://graph.facebook.com/oauth/access_token";

        /// <summary>
        /// 资源URL
        /// </summary>
        public const string ProfileResourceUrl = " https://graph.facebook.com/me";

        /// <summary>
        /// 返回URL
        /// </summary>
        public const string ReturnUrl = "http://www.authdemo.com/auth/return_url_facebook.aspx";

        /// <summary>
        /// 移动端返回URL
        /// </summary>
        public const string MobileReturnUrl = "http://m.authdemo.com/auth/returnfacebook/";

    }
}
