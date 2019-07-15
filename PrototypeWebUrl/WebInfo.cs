using ProtoType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebUrl
{
    class WebInfo : IProtoType<WebInfo>
    {
        public DateTime timeStamp;
        public string size;
        public string url;

        public WebInfo(DateTime timeStamp , string size , string url)
        {
            this.timeStamp = timeStamp;
            this.size = size;
            this.url = url;
        }

        public WebInfo clone()
        {
            return new WebInfo(this.timeStamp, this.size, this.url);
        }
    }
}
