using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.DataAccess.PITAccess.Interface
{
    public interface IPITRepository
    {
        void Delete(PITEntry pITEntry);
        void Edit(PITEntry pITEntry);
        void Add(PITEntry pITEntry);
        PITEntry GetBy(int id);
        PITEntry GetBy(string name);
        List<PITEntry> GetAll();
    }
}
