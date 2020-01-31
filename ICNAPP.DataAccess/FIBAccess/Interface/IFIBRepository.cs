using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.DataAccess.FIBAcess.Interface
{
    public interface IFIBRepository
    {
        void Delete(FIBEntry fIBEntry);
        void Edit(FIBEntry fIBEntry);
        void Add(FIBEntry fIBEntry);
        FIBEntry GetBy(int id);
        FIBEntry GetBy(string name);
        List<FIBEntry> GetAll();
    }
}
