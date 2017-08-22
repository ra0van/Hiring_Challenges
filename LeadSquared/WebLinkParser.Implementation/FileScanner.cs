using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLinkParser.Abstract;
using WebLinkParser.Entities;

namespace WebLinkParser.Implementation
{
    public class FileScanner : JobScanner<FileRequest, List<JobRequest>>
    {
        public override List<JobRequest> GetJob(FileRequest job)
        {
            List<JobRequest> jobs = new List<JobRequest>();
            try
            {

            }
            catch( Exception ex)
            {

            }
            return jobs;
        }
    }
}
