using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.PITEntries.Interface
{
    public interface IPITEntriesService
    {
        List<PITEntry> GetAllPITEntries();

        PITEntry GetPITEntryBy(int id);

        PITEntry GetPITEntryBy(string name);


        void AddPITEntry(PITEntry pITEntry);

        bool EditPITEntry(PITEntry pITEntry);

        bool DeletePITEntry(PITEntry pITEntry);

    }
}
