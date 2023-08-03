using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcf_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IServerCallback))]
    public interface IServiceAniChat
    {
        [OperationContract]
        int Connect(string name, string chatname);

        [OperationContract]
        void Disconnect(int id, string chatname);

        [OperationContract(IsOneWay = true)]
        void SendMsg(string msg, int id , string chatname);
    }

    public interface IServerCallback
    {
        [OperationContract(IsOneWay = true)]
        void MsgCallback(string msg);
    }
}
