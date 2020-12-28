using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoREPOSITORY
{
  public  interface IDataAccess

    {
        List<XpayModel> Read();
        void Create(XpayModel xpayModel);
        void Update(XpayModel xpayModel);
        void Delete(XpayModel xpayModel);

    }
}
