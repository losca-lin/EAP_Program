using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Getech.EAP.Entity.EAPEntities.DataTransferObject.DTO.TCP.ZHString_Message
{
    public class ZHStringSendToEqp
    {
        public ZHStringSendToEqp() {
            MessageBodyList = new LinkedList<string>();
        }

        public string MsgName { get;set;}

        public string MachineID { get;set;}

        public LinkedList<string> MessageBodyList { get;set;}

        public string TransactionID { get;set;}

        public new string ToString() 
        {
            string bodyData = "";
            int index = 0;
            foreach (string data in MessageBodyList) {
                if (index == 0)
                {
                    bodyData = data;
                }
                else
                {
                    bodyData = bodyData + "," + data;
                }
                index++;
            }
            string result = string.Format("{{ \n{0} \n{1} \n{2} \n{3} \n}}\r\n", MsgName, MachineID, bodyData, TransactionID);
            return result;
        }

    }
}
