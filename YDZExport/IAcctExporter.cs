using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YDZExportClient
{
    public interface IAcctExporter
    {
        bool DisplayVerifyPic(ref PictureBox pbVerify );
        String Login(string username, string password, ref ListView lvAcct, string enterpriseno = "", string verifycode = "");
        bool ExportOneAcct(string userId, string bookId, string AcctName, string extInfo = "");
    }
}
