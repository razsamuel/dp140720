using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebUrl
{
    class WebInfoFactory
    {
        Dictionary<string, WebInfo> webInfoDict;

        public WebInfoFactory()
        {
            webInfoDict = new Dictionary<string, WebInfo>();
        }

        public WebInfo createWebInfo(string url)
        {
            WebInfo webInfo;
            if (!webInfoDict.Keys.Contains(url))
            {
                string size = Program.WriteWebRequestSizeAsync(url);
                webInfo = new WebInfo(DateTime.Now, size, url);// WriteWebRequestSizeAsync
                webInfoDict.Add(url, webInfo);
            }
            else
            {
                webInfo = webInfoDict[url];
            }
            return webInfo.clone();
        }
    }
}
