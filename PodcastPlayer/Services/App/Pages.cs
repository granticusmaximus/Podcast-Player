﻿using System;
namespace PodcastPlayer.Services.App
{
    //static class for app pages common information
    public static partial class Pages
    {
        public static class Membership
        {
            public const string ControllerName = "Membership";
            public const string RoleName = "Membership";
            public const string UrlDefault = "/Membership/Index";
            public const string NavigationName = "Membership";
        }

        public static class Role
        {
            public const string ControllerName = "Role";
            public const string RoleName = "Role";
            public const string UrlDefault = "/Role/Index";
            public const string NavigationName = "Role";
        }
    }
}
