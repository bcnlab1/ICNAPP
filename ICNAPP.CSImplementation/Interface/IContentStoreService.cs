using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.CSImplementation.Interface
{
    public interface IContentStoreService
    {
        List<ICNAPP.Models.DatabaseModel.ContentStore> GetAllContentStore();

        List<ICNAPP.Models.DatabaseModel.ContentStore> GetAllContentStore(bool isDeleted);

        ICNAPP.Models.DatabaseModel.ContentStore GetContentStoreBy(int id);

        ICNAPP.Models.DatabaseModel.ContentStore GetContentStoreBy(string name);

        List<ICNAPP.Models.DatabaseModel.ContentStore> GetContentStoreAfter(int id);

        void AddContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore);

        bool EditContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore);

        bool DeleteContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore);

        bool SoftDeleteContentStore(ICNAPP.Models.DatabaseModel.ContentStore contentStore);
    }
}
