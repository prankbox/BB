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
            Vkontakte.Logon();
            Vkontakte.GoToChat();
            if(Vkontakte.GetLinks().Count==0)
            {
                System.Console.WriteLine("Нет ссылок для лайкинга");
                return;
            }


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
