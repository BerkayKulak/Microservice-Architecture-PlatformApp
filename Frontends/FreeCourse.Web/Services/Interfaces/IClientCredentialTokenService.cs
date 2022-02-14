using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}
