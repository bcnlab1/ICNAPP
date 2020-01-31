using ICNAPP.CSImplementation.Interface;
using ICNAPP.DataAccess.CSAccess.Interface;
using ICNAPP.DataAccess.CSAccess.Repository;
using ICNAPP.Models.DatabaseModel;
using ICNAPPHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.CSImplementation.Operations
{
    public class ContentStoreService : IContentStoreService
    {
        IContentStoreRepository _contentStoreRepository;
        public ContentStoreService()
        {
            _contentStoreRepository = new ContentStoreRepository();
        }

        #region ContentStore

        #region Get
        

        public List<ICNAPP.Models.DatabaseModel.ContentStore> GetAllContentStore()
        {
            try
            {
                return _contentStoreRepository.GetAll();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        public List<ICNAPP.Models.DatabaseModel.ContentStore> GetAllContentStore(bool isDeleted)
        {
            try
            {
                return _contentStoreRepository.GetBy(x => x.IsDeleted == isDeleted);
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        public ICNAPP.Models.DatabaseModel.ContentStore GetContentStoreBy(int id)
        {
            try
            {
                return _contentStoreRepository.GetBy(x => x.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        public List<ICNAPP.Models.DatabaseModel.ContentStore> GetContentStoreAfter(int id)
        {
            try
            {
                return _contentStoreRepository.GetBy(x => x.Id > id).ToList();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return null;
            }
        }

        #endregion

        #region Add

        public void AddContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore)
        {
            try
            {
                contentStore.CreatedDate = DateTime.UtcNow;
                _contentStoreRepository.Add(contentStore);
                _contentStoreRepository.Save();
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
            }
        }


        #endregion

        #region Edit

        public bool EditContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore)
        {
            try
            {
                contentStore.UpdatedDate = DateTime.UtcNow;
                _contentStoreRepository.Edit(contentStore);
                _contentStoreRepository.Save();

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

        public bool DeleteContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore)
        {
            try
            {
                _contentStoreRepository.Delete(contentStore);
                _contentStoreRepository.Save();

                return true;
            }
            catch (Exception ex)
            {
                LogHelper.WriteExceptionLog(ex);
                return false;
            }
        }

        

        public Models.DatabaseModel.ContentStore GetContentStoreBy(string name)
        {
            throw new NotImplementedException();
        }

        public bool SoftDeleteContentStore(Models.DatabaseModel.ContentStore contentStore)
        {
            throw new NotImplementedException();
        }



        #endregion

        #endregion
    }


}
