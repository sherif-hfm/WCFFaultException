using ServiceTest.Srv1Ref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Srv1Ref.Service1Client srv = new Srv1Ref.Service1Client();
                var result = srv.GetData(6);
            }
            catch (FaultException ex)
            {
                
            }
        }
    }
}
