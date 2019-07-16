using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPro
{
    public abstract class TemplateQueryRunner
    {
        protected abstract void CreateDbConnection();
        protected abstract void OpenDbConnection();
        protected abstract void ExecuteQuery();
        protected abstract void CloseDbConnection();
            
        public void Run()
        {
            CreateDbConnection();
            OpenDbConnection();
            ExecuteQuery();
            CloseDbConnection();
        }
    }
}
