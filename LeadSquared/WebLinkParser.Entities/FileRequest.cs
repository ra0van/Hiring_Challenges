using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebLinkParser.Entities
{
    public class FileRequest : IEntity
    {
        private readonly Guid id = Guid.NewGuid();
        public Guid Id { get { return id; } }
        public string InputPath { get; set; }
    }
}
