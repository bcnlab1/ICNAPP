using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.Forwarder.Interface
{
    public interface IFIBEntriesService
    {
        List<FIBEntry> GetAllFIBEntries();

        FIBEntry GetFIBEntryBy(int id);

        FIBEntry GetFIBEntryBy(string name);


        void AddFIBEntry(FIBEntry fIBEntry);

        bool EditFIBEntry(FIBEntry fIBEntry);

        bool DeleteFIBEntry(FIBEntry fIBEntry);

    }
}
