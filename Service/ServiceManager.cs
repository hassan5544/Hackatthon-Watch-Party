using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IVideoService> _videoService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager , ILoggerManager loggerManager , IMapper mapper , UserManager<User> userManager , IConfiguration configuration)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager , loggerManager , mapper));
            _videoService = new Lazy<IVideoService>(() => new VideoService(repositoryManager , loggerManager , mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() =>
            new AuthenticationService(loggerManager, mapper, userManager,
            configuration));
        }
        public IUserService UserService => _userService.Value;

        public IVideoService VideoService => _videoService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
