using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public abstract class MongoTemplateBase : TemplateQueryRunner
    {
        protected override void CreateDbConnection()
        {
            Console.WriteLine("Creating mongo connection ... ");
        }
        protected override void OpenDbConnection()
        {
            Console.WriteLine("Opening mongo connection ... ");
        }
        protected override void CloseDbConnection()
        {
            Console.WriteLine("Closing mongo connection ... ");
        }

    }
}
