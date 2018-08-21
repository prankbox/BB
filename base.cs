using System;
using System.Collections.Generic;

namespace BB
{

    public class Account
    {
        public string Login;
        public string Password;
        public string ProfilePath;
        public string ZPfile;

    }

    public static class Vkontakte
    {
        public static string ChatLink;
        public static string VkProfile;
        public static Account VkAccount = new Account();
        
        public static void Logon()
        {
            string message = String.Format("Успешно залогинились в ВК с логином {0}",VkAccount.Login);
            System.Console.WriteLine(message);
            

        }

        public static void Logon(string vkProfile)
        {
            string message = String.Format("Успешно залогинились в ВК с профилем {0}",vkProfile);
            System.Console.WriteLine(message);


        }

        public static void GoToChat()
        {
            string message = String.Format("Успешно перешли  в ВК чат {0}",ChatLink);
            System.Console.WriteLine(message);
        }

        public static List<string> GetLinks()
        {
            string linkOne = "One";
            string linkTwo = "Two";
            string linkThree = "Three";

            var linkList = new List<string>();
            linkList.Add(linkOne);
            linkList.Add(linkTwo);
            linkList.Add(linkThree);

            return linkList;

        }




    }

    public class Youtube
    {
        public string Channel;
        public string YouProfile;
        public Account YoutubeAccount = new Account();
        public void Logon()
        {
            string message = String.Format("Успешно залогинились в Youtube с логином {0}",YoutubeAccount.Login);
            System.Console.WriteLine(message);
        }

        public void Logon(string youProfile)
        {
            string message = String.Format("Успешно залогинились в Youtube с профилем {0}",youProfile);
            System.Console.WriteLine(message);
        }

        public void NavigateVideo(string Video)
        {
            System.Console.WriteLine("Перешли на видео "+ Video);
        }

        public void Like(string Video)
        {
            System.Console.WriteLine("Лайкнули видео "+ Video);
        }

    }

    public class Golos
    {


    }



}