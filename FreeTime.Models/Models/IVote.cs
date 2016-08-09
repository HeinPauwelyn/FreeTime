using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeTime.Common.Models
{
    interface IVote
    {
        int UpVotes { get; set; }
        int DownVotes { get; set; }

        int CalculateTotal();
    }
}
