using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplayceLogDal
{
   public  interface IDAL
    {
       Log getLogByIDLog(Guid idLog);
       Log getLogbyUserID(Guid userID);
       Log getLogBySessionID(Guid sessionID);
       Log getLogByDate(Guid date);
       Log getLogByGlobalTypeStat(Guid globalTypeStat);
       Log getLogByTypeStat(Guid typeStat);
    }
}
