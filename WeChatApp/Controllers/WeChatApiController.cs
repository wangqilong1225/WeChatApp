using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WeChatApp.Controllers
{
    /// <summary>
    /// 接口验证控制
    /// </summary>
    public class WeChatApiController : Controller
    {
        // GET: WeChatApi
        public ActionResult Index()
        {
            return View();
        }

        
        /// <summary>
        /// 进入地址 http://wangqilong.goho.co/WeChatApi/WeChat
        /// </summary>
        public void WeChat()
        {

        }
    }
}