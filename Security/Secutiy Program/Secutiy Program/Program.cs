using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Principal;
using System.Threading;

namespace Secutiy_Program
{
    class Program
    {
        public static void DemonstrateWindowsBuiltInRoleEnum()
        {
            AppDomain myDomain = Thread.GetDomain();

            myDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal myPrincipal = (WindowsPrincipal)Thread.CurrentPrincipal;
            Console.WriteLine( myPrincipal.Identity.Name.ToString());

            // Check if the user is in the Administrator role
            bool isAdmin = myPrincipal.IsInRole(WindowsBuiltInRole.User);
            Console.WriteLine(isAdmin);



        }
        static void Main(string[] args)
        {
            DemonstrateWindowsBuiltInRoleEnum();
        }
    }
}
