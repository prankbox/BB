using System;
using System.Collections.Generic;
namespace BB
{
    class Program
    {
        static void Main(string[] args)
        {
            Vkontakte.VkAccount.Login = "VkLogin";
            Vkontakte.VkAccount.Password = "Password";
            Vkontakte.VkAccount.ProfilePath ="file";
            Vkontakte.ChatLink = "vk.com/chat";
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
