using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AniHost
{
    class Host
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(wcf_service.ServiceAniChat)))
            {
                host.Open();
                Console.WriteLine("Host alredy starting !!!");
                Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
