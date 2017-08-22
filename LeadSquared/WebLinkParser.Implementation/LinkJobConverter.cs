using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinkParser.Abstract;
using WebLinkParser.Entities;

namespace WebLinkParser.Implementation
{
    public class LinkJobConverter : JobScanner<FileRequest, List<JobRequest>>
    {
        public override List<JobRequest> GetJob(FileRequest job)
        {
            throw new NotImplementedException();
        }
    }
}
