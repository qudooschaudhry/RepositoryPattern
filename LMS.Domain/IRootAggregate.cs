using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Domain
{
    public interface IRootAggregate
    {
        public Guid Id { get; set; }
    }
}
