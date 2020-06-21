using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace headquarterslab.Features.Master
{

    /// <summary>
    /// 
    /// </summary>
    public class PGHQStudioPageMenuItem
    {
        public int      Id          { get; set; }
        public string   Title       { get; set; }
        public Type     TargetType  { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public PGHQStudioPageMenuItem()
        {
            TargetType = typeof(PGHQStudioPageDetail);
        }
    }
}
