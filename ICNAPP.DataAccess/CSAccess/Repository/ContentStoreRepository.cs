using ICNAPP.DataAccess.CSAccess.Interface;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.DataAccess.CSAccess.Repository
{
    public class ContentStoreRepository : GenericRepository<CSEntities, ContentStore>, IContentStoreRepository
    {

    }
}
