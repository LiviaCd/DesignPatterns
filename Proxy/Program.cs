using Proxy.Core;
using Proxy.RemoteProxy;
using Proxy.VirtualProxy;
using Proxy.ProtectedProxy;
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Alegeti tipul Proxy");
        Console.WriteLine("1 - Remote Proxy");
        Console.WriteLine("2 - Virtual Proxy");
        Console.WriteLine("3 - Protected Proxy");

        string option;
  

        while (true)
        {
            option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    //remote proxy
                    HttpClient client = new HttpClient();
                    IUserRepositoryRemote localRepository = new LocalRepository(new RemoteProxyRepository(client));
                    var Ruser1 = await localRepository.GetUserDataById(1);
                    var Ruser2 = await localRepository.GetUserDataById(1);
                    var Ruser3 = await localRepository.GetUserDataById(1);

                    var rNewUser = new UserData
                    {
                        Id = 9,
                        Name = "Test",
                        Email = "test.test@gmail.com"
                    };
                    await localRepository.InsertUserData(rNewUser);
                    var rUser4 = await localRepository.GetUserDataById(9);
                    Console.WriteLine("-----------------------------------");
                    break;

                case "2":
                    //virtual proxy
                    IUserRepository virtualRepository = new VirtualProxyRepository(new UserRepository());
                    var vUser1 = virtualRepository.GetUserDataById(1);
                    var vUser2 = virtualRepository.GetUserDataById(1);
                    var vUser3 = virtualRepository.GetUserDataById(1);
                    var vNewUser = new UserData
                    {
                        Id = 10,
                        Name = "Test",
                        Email = "test.test@gmail.com"
                    };

                    virtualRepository.InsertUserData(vNewUser);

                    var vUser4 = virtualRepository.GetUserDataById(10);
                    Console.WriteLine("-----------------------------------");
                    break;

                case "3":
                    //Protected Proxy
                    string password = "Secret123";
                    IUserRepository protectedRepository = new ProtectedRepository(new UserRepository(), password);

                    var pUser1 = protectedRepository.GetUserDataById(1);
                    var pUser2 = protectedRepository.GetUserDataById(1);
                    var pUser3 = protectedRepository.GetUserDataById(1);
                    var pNewUser = new UserData
                    {
                        Id = 11,
                        Name = "Test",
                        Email = "test.test@gmail.com"
                    };
                    protectedRepository.InsertUserData(pNewUser);

                    var pUser4 = protectedRepository.GetUserDataById(11);
                    Console.WriteLine("-----------------------------------");
                    break;
            }







        }
    }
}
