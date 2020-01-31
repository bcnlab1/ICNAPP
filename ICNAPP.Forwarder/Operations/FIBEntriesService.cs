using ICNAPP.Forwarder.Interface;
using ICNAPP.DataAccess.FIBAccess.Repository;
using ICNAPP.DataAccess.FIBAcess.Interface;
using ICNAPP.Models.CustomModels;
using ICNAPP.Models.DatabaseModel;
using ICNAPPHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.Forwarder.Operations
{
    public class FIBEntriesService : IFIBEntriesService
    {
        IFIBRepository _fIBRepository;
        public FIBEntriesService()
        {
            _fIBRepository = new FIBRepository();
        }

        #region FIBEntries

        #region Get
        

        public List<FIBEntry> GetAllFIBEntries()
        {
            try
            {
                return _fIBRepository.GetAll();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        

        public FIBEntry GetFIBEntryBy(int id)
        {
            try
            {
                return _fIBRepository.GetBy(id);
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        public FIBEntry GetFIBEntryBy(string name)
        {
            try
            {
                return _fIBRepository.GetBy(name);
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        #endregion

        #region Add

        public void AddFIBEntry(FIBEntry pITEntry)
        {
            try
            {
                _fIBRepository.Add(pITEntry);
                
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
            }
        }


        #endregion

        #region Edit

        public bool EditFIBEntry(FIBEntry pITEntry)
        {
            try
            {
                _fIBRepository.Edit(pITEntry);
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return false;
            }
        }

        #endregion

        #region Delete

        public bool DeleteFIBEntry(FIBEntry pITEntry)
        {
            try
            {
                _fIBRepository.Delete(pITEntry);
                

                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return false;
            }
        }

        

        



        #endregion

        #endregion
    }


}
