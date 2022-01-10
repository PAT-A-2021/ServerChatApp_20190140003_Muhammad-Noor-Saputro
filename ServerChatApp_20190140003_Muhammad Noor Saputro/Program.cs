using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfService_2Way_003;

namespace ServerChatApp_20190140003_Muhammad_Noor_Saputro
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObjek = null;
            try
            {
                hostObjek = new ServiceHost(typeof(ServiceCallback));
                hostObjek.Open();

                Console.WriteLine("Server On, Ready to use");
                Console.ReadLine();

                hostObjek.Close();
            }
            catch (Exception ex)
            {
                hostObjek = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}