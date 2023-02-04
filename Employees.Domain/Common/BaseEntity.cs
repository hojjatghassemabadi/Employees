using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Domain.Common
{
    public class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public bool IsRemoved { get; set; } = false;
        public int? RemovedBy { get; set; }
        public DateTime? RemovedDate { get; set; }
        public int? EditBy { get; set; }
        public DateTime? EditDate { get; set; }
    }
    public abstract class BaseEntity:BaseEntity<long>
    {

    }
}
