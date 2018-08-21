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
            Vkontakte.VkAccount.ProfilePath = @"\Profiles\";
            Vkontakte.VkAccount.ZPfile = @"VKProfile";
            Vkontakte.ChatLink = "vk.com/chat";
            Vkontakte.VkProfile = Vkontakte.VkAccount.ProfilePath + Vkontakte.VkAccount.ZPfile;
            if(File.Exists(Vkontakte.VkProfile))
            {
                Vkontakte.Logon(Vkontakte.VkProfile);
                
            }
            else
            {
                Vkontakte.Logon();
            }
            
            Vkontakte.GoToChat();

            List<string> youtubeLinks = Vkontakte.GetLinks();
            if(youtubeLinks.Count==0)
            {
                System.Console.WriteLine("Нет ссылок для лайкинга");
                return;
            }
            System.Console.WriteLine(String.Format("Собрали {0} ссылок",youtubeLinks.Count));
//=========================================================================================================================================
            var Youtube = new Youtube();
            Youtube.YoutubeAccount.Login = "Youtube Login";
            Youtube.YoutubeAccount.Password = "Youtube Password";
            Youtube.YoutubeAccount.ProfilePath = @"\Profiles\";
            Youtube.YoutubeAccount.ZPfile = @"YProfile";
            Youtube.YouProfile = Youtube.YoutubeAccount.ProfilePath + Youtube.YoutubeAccount.ZPfile;

            if(File.Exists(Youtube.YouProfile))
            {
                Youtube.Logon(Youtube.YouProfile);
            }
            else
            {
                Youtube.Logon();
            }
            
            foreach(var VkLink in Vkontakte.GetLinks())
            {
                Youtube.NavigateVideo(VkLink);
                Youtube.Like(VkLink);
            }

        }
    }
}
