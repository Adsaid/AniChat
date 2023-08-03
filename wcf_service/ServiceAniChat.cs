using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace wcf_service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceAniChat : IServiceAniChat
    {
        List<ServerUser> users = new List<ServerUser>();

        //Dictionary<string, List<string>> history_chats = new Dictionary<string, List<string>>();

        int id = 1;

        public int Connect(string name, string chatname)
        {
            ServerUser user = new ServerUser()
            {
                ID = id,
                Name = name,
                Chat_Name = chatname,
                OperationContext = OperationContext.Current
            };
            id++;

            //SendMsg(". "+user.Name +" : "+ " Connect !",0,chatname);
            users.Add(user);
            return user.ID;
        }

        public void Disconnect(int id, string chatname)
        {
            var user = users.FirstOrDefault(i => i.ID == id);
            if (user != null)
            {
                users.Remove(user);
                //SendMsg(". " + user.Name + " : " + " Disconnect !",0, chatname);
            }
        }

        public void SendMsg(string msg, int id, string chatname)
        {
            var group_user =
            from users in users
            where users.Chat_Name == chatname || users.Chat_Name == "notification"
            select users;

            foreach (var item in group_user)
            {
                string answer = String.Empty;// DateTime.Now.ToShortTimeString();

                var user = users.FirstOrDefault(i => i.ID == id);
                
                if (user != null)
                {
                    answer += "{'chatname':'" + chatname + "' ,'username':'" + user.Name + "',";
                }

                answer += msg + " }";

                item.OperationContext.GetCallbackChannel<IServerCallback>().MsgCallback(answer);
            }
        }

        //public List<string> Get_Chat_history(string chatname)
        //{
        //    List<string> hchat = new List<string>();

        //    if (history_chats.ContainsKey(chatname))
        //    {
        //        foreach (var item in history_chats[chatname])
        //        {
        //            hchat.Add(item);
        //        }
        //    }

        //    return hchat;
        //}
        //public void Set_Chat_history(List<string> hchat , string chatname)
        //{
        //    if (history_chats.ContainsKey(chatname))
        //    {
        //        history_chats[chatname] = hchat;
        //    }
        //    else
        //    {
        //        history_chats.Add(chatname, hchat);
        //    }
        //}
    }
}
