using ICNAPP.DataAccess.CSAccess.Interface;
using ICNAPP.DataAccess.FIBAcess.Interface;
using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.DataAccess.FIBAccess.Repository
{
    public class FIBRepository : IFIBRepository
    {
        void IFIBRepository.Add(FIBEntry fIBEntry)
        {
            throw new NotImplementedException();
        }

        void IFIBRepository.Delete(FIBEntry fIBEntry)
        {
            throw new NotImplementedException();
        }

        void IFIBRepository.Edit(FIBEntry fIBEntry)
        {
            throw new NotImplementedException();
        }

        List<FIBEntry> IFIBRepository.GetAll()
        {
            throw new NotImplementedException();
        }

        FIBEntry IFIBRepository.GetBy(int id)
        {
            throw new NotImplementedException();
        }

        FIBEntry IFIBRepository.GetBy(string name)
        {
            throw new NotImplementedException();
        }
    }
}
