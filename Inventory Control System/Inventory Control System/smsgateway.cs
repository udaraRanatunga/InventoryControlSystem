using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using IntelliSoftware;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Inventory_Control_System
{
    class smsgateway
    {
       
        // us kithmini pw i43Android
            public bool sendmsg(string username, string password, string cno, string msg)
            {
                try
                {
                    IntelliSMS objIntelliSMS = new IntelliSMS();

                    objIntelliSMS.Username = username;
                    objIntelliSMS.Password = password;

                    string messsage = msg;

                   // String MessageId = objIntelliSMS.SendMsg(cno, messsage, "our number with +94764181619");

               

                StringCollection ToList = new StringCollection();
                ToList.Add("+94764181619");

                SendStatusCollection SendStatusList;

                SendStatusList = objIntelliSMS.SendMsgToMultipleRecipients
                    (ToList, messsage, "+94764181619");


                string Report = "";
                foreach (SendStatus sendStatus in SendStatusList)
                {
                    Report += "To:" + sendStatus.To + ", " +"ResultCode:" + sendStatus.ResultCode + "\n";
                }

                MessageBox.Show(Report,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                return true;
                }
                catch (IntelliSMSException )
                {
                    return false;
                    //ResultCodes resualt = new ResultCodes();
                    //throw new IntelliSMSException(resualt, ex.ToString());
                }
                catch (Exception )
                {
                    return false;
                    //throw new Exception();
                }
            }
        }
    }
