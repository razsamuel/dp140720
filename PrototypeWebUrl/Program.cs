using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeWebUrl
{
    class Program
    {
        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        public static string WriteWebRequestSizeAsync(string url)
        {
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    webRequest.GetResponseAsync().Result;
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        reader.ReadToEndAsync().Result;
                 //   Console.WriteLine(
                   //     FormatBytes(text.Length));
                    return FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }

            return "Failed...";
        }

        static void Main(string[] args)
        {
            WebInfoFactory webInfoFactory = new WebInfoFactory();
            List<string> urls = new List<string>(new string[] { "http://www.IntelliTect.com", "http://www.google.com", "http://www.ynet.com", "http://www.IntelliTect.com", "http://www.ynet.com" });

           foreach(string url in urls)
            {
                DateTime startTime = DateTime.Now;
                WebInfo webInfo = webInfoFactory.createWebInfo(url);
                string size = webInfo.size;
                DateTime endTime = DateTime.Now;
                double seconds = endTime.Subtract(startTime).TotalSeconds;
                Console.WriteLine("for the url of {0}: The file size is : {1} and it take {2} seconds to bring it", url, size , seconds);
                

            }
        }
    }
}