using System;
using System.Collections.Generic;
using System.IO;
namespace BB
{
    class Program
    {
        static void Main(string[] args)
        {
            Vkontakte.VkAccount.Login = "VkLogin";
            Vkontakte.VkAccount.Password = "Password";
            Vkontakte.ChatLink = "vk.com/chat";
            if(File.Exists(Vkontakte.VkAccount.ProfilePath))
            {
                Vkontakte.Logon(Vkontakte.VkAccount.ProfilePath);
            }
            else
            {
                Vkontakte.Logon();
            }
            Vkontakte.Logon();
            Vkontakte.GoToChat();
            List<string> youtubeLinks = Vkontakte.GetLinks();
            if(youtubeLinks.Count==0)
            {
                System.Console.WriteLine("Нет ссылок для лайкинга");
                return;
            }
            System.Console.WriteLine(String.Format("Собрали {0} ссылок",youtubeLinks.Count));

            var Youtube = new Youtube();
            Youtube.YoutubeAccount.Login = "Youtube Login";
            Youtube.YoutubeAccount.Password = "Youtube Password";
            Youtube.Logon();
            foreach(var VkLink in Vkontakte.GetLinks())
            {
                Youtube.NavigateVideo(VkLink);
                Youtube.Like(VkLink);
            }

        }
    }
}
