using ICNAPP.DataAccess.CSAccess.Interface;
using ICNAPP.DataAccess.CSAccess.Repository;
using ICNAPP.Models.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICNAPP.DataAccess.CSAccess.Repository
{
    public class LoggingRepository : GenericRepository<CSEntities, Logging>, ILoggingRepository
    {
        
    }
}
