using System.Collections.Generic;

namespace OML_Template
{
   using IDbMaster;
   public class C$safeprojectname$Master : List<C$safeprojectname$>, IDbMaster
   {
      public C$safeprojectname$Master()
      {
      }

      public bool Load(ref string strError)
      {
         return (new C$safeprojectname$Archiver()).Load(this, ref strError);
      }

      public bool Store(ref string strError)
      {
         return (new C$safeprojectname$Archiver()).Store(this, ref strError);
      }
   }
}
