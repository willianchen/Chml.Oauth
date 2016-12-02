using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chml.Oauth.Controllers
{
    public class AuthController : Base.BaseController
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReturnLinkedin()
        {
            string description = string.Empty;

            string code = RequestString("code");
            string state = RequestString("state");
            string error = RequestString("error");
            string error_description = RequestString("error_description");
            if (code == "" || error != "")
            {
                if (code == "user_cancelled_authorize" || code == "user_cancelled_login ")
                {
                    description = code;
                }
                else
                    description = error != "" ? error_description : "no authentication !";
            }
            else
            {
                var res = Tools.Auth.LinkinHelper.GetToken(code, Tools.Auth.LinkinConfig.ReturnUrl);
                if (res.access_token != "")
                {
                    var entity = Tools.Auth.LinkinHelper.GetProFileStr(res.access_token, Tools.Auth.LinkinConfig.ProfileResourceUrl);
                    description = entity;
                }
                else
                {
                    description = "access token error";
                }
            }
            ViewBag.Description = description;
            return View();
        }
    }
}