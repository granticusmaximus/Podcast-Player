using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PodcastPlayer.Models;

namespace PodcastPlayer.Services.Security
{
    public interface ICommon
    {
        Task CreateDefaultSuperAdmin();

        List<String> GetAllRoles();

        List<ApplicationUser> GetAllMembers();

        ApplicationUser GetMemberByApplicationId(string applicationId);

        Task<ApplicationUser> CreateApplicationUser(ApplicationUser applicationUser, string password);

    }
}