using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLinkParser.Abstract
{
    public abstract class JobScanner<TInput, TOutput>
    {
        public abstract TOutput GetJob(TInput job);
    }
}
