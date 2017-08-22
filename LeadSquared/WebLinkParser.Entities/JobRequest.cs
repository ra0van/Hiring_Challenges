using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLinkParser.Entities
{
    public class JobRequest : IEntity
    {
        private readonly Guid id = Guid.NewGuid();
        public Guid Id { get { return id; } }
        public string Url { get; set; }
    }
}
