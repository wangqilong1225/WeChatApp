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

        //public 
        /*
            import hashlib
            import web

            class Handle(object):
                def GET(self):
                    try:
                        data = web.input()
                        if len(data) == 0:
                            return "hello, this is handle view"
                        signature = data.signature
                        timestamp = data.timestamp
                        nonce = data.nonce
                        echostr = data.echostr
                        token = "xxxx" #请按照公众平台官网\基本配置中信息填写

                        list = [token, timestamp, nonce]
                        list.sort()
                        sha1 = hashlib.sha1()
                        map(sha1.update, list)
                        hashcode = sha1.hexdigest()
                        print "handle/GET func: hashcode, signature: ", hashcode, signature
                        if hashcode == signature:
                            return echostr
                        else:
                            return ""
                    except Exception, Argument:
                        return Argument






            private function checkSignature()
            {
                _GET["signature"];
                _GET["timestamp"];
                _GET["nonce"];

            tmpArr = array(timestamp, $nonce);
            sort($tmpArr, SORT_STRING);
            $tmpStr = implode( $tmpArr );
            $tmpStr = sha1( $tmpStr );  //sha1加密

            if( signature ){
                return true;
                }
           else{
                return false;
            }
            }
         
         */

        /*
            通用域名(api.weixin.qq.com)，使用该域名将访问官方指定就近的接入点；

            通用异地容灾域名(api2.weixin.qq.com)，当上述域名不可访问时可改访问此域名；

            上海域名(sh.api.weixin.qq.com)，使用该域名将访问上海的接入点；

            深圳域名(sz.api.weixin.qq.com)，使用该域名将访问深圳的接入点；
            香港域名(hk.api.weixin.qq.com)，使用该域名将访问香港的接入点。
         */
    }
}