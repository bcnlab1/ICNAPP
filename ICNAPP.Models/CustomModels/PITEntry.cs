using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.Models.CustomModels
{
    public partial class PITEntry
    {
        public int Id { get; set; }
        public string InterestName { get; set; }
        public List<string> IncommingFace { get; set; }
        public string OutGoingFace { get; set; }
        // Expiry service will only check the creation time, 
        //if the creation time is more than InterestLifeTime (configuration), the entry will be removed 
        public DateTime EntryCreationTime { get; set; }
        public DateTime EntryUpdatedTime { get; set; }
    }
}
