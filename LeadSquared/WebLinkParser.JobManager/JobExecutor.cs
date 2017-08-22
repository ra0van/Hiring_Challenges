using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLinkParser.Abstract
{
    public abstract class JobExecutor<TInput, TOutput>
    {
        public abstract TOutput ExecuteJob(TInput job);
    }
}
