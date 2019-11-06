using System;
namespace PodcastPlayer.ViewModels
{
    //view model for changeroles screen
    public class ChangeRoles
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public bool IsMembershipRegistered { get; set; }
        public bool IsRoleRegistered { get; set; }
    }
}
