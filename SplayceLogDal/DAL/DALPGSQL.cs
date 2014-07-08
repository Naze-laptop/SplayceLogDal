using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplayceLogDal
{
    class DALPGSQL : IDAL
    {
        public string con { get; set; }



        public Log getLogByIDLog(Guid idLog)
        {
            throw new NotImplementedException();
        }

        public Log getLogbyUserID(Guid userID)
        {
            throw new NotImplementedException();
        }

        public Log getLogBySessionID(Guid sessionID)
        {
            throw new NotImplementedException();
        }


        public Log getLogByDate(Guid date)
        {
            throw new NotImplementedException();
        }

        public Log getLogByGlobalTypeStat(Guid globalTypeStat)
        {
            throw new NotImplementedException();
        }

        public Log getLogByTypeStat(Guid typeStat)
        {
            throw new NotImplementedException();
        }
    }
}

