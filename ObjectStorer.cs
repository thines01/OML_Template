using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OML_Template
{
   using IMasterArchiver;
   public partial class C$safeprojectname$Archiver : IMasterArchiver<C$safeprojectname$Master>
   {
      public bool Store(C$safeprojectname$Master master, ref string strError)
      {
         bool blnRetVal = true;

         try
         {
            // Do Store Here
            strError = "Method Not Implemented";   // Remove This
            blnRetVal = false;   // Remove This
         }
         catch (Exception exc)
         {
            blnRetVal = false;
            strError = exc.Message;
         }

         return blnRetVal;
      }
   }
}
