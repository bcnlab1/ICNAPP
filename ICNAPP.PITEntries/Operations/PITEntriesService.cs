using ICNAPP.PITEntries.Interface;

using ICNAPP.DataAccess.PITAccess.Interface;
using ICNAPP.DataAccess.PITAccess.Repository;
using ICNAPP.Models.CustomModels;
using ICNAPPHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.PITEntries.Operations
{
    public class PITEntriesService : IPITEntriesService
    {
        IPITRepository _pITRepository;
        public PITEntriesService()
        {
            _pITRepository = new PITRepository();
        }

        #region PITEntries

        #region Get
        

        public List<PITEntry> GetAllPITEntries()
        {
            try
            {
                return _pITRepository.GetAll();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        

        public PITEntry GetPITEntryBy(int id)
        {
            try
            {
                return _pITRepository.GetBy(id);
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        public PITEntry GetPITEntryBy(string name)
        {
            try
            {
                return _pITRepository.GetBy(name);
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        #endregion

        #region Add

        public void AddPITEntry(PITEntry pITEntry)
        {
            try
            {
                pITEntry.EntryCreationTime = DateTime.UtcNow;
                _pITRepository.Add(pITEntry);
                
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
            }
        }


        #endregion

        #region Edit

        public bool EditPITEntry(PITEntry pITEntry)
        {
            try
            {
                pITEntry.EntryUpdatedTime = DateTime.UtcNow;
                _pITRepository.Edit(pITEntry);
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

        public bool DeletePITEntry(PITEntry pITEntry)
        {
            try
            {
                _pITRepository.Delete(pITEntry);
                

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
