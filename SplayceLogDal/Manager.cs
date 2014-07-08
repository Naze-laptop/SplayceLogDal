using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplayceLogDal
{
   public  class Manager
    {

       public Log getLogbyID(Guid idLog)
       {
           return Idal.getLogByIDLog(idLog);
       }
       public Log getLogbyDate(Guid date)
       {
           return Idal.getLogByDate(date);
       }

       private IDAL _Idal;
       public IDAL Idal
       {
           get
           {
               if  (_Idal == null)
               {
                   _Idal = (IDAL)new DALPGSQL();
               }
               return _Idal;

           }
       }

    }
}
