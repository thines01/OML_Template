using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace OML_Template
{
   public class C$safeprojectname$
   {

      public C$safeprojectname$()
      {
      }

      public C$safeprojectname$(C$safeprojectname$ copy)
      {
      }

      public C$safeprojectname$(IDataReader rdr)
      {
      }

      public C$safeprojectname$(string strData)
      {
         string[] arr_strData = strData.Split(',');
      }

      public override string ToString()
      {
         char chrDelim = ',';
         return base.ToString();
      }

      public override bool Equals(object obj)
      {
         return this.ToString().Equals(((C$safeprojectname$)obj).ToString());
      }

      public override int GetHashCode()
      {
         return this.ToString().GetHashCode();
      }
   }
}
