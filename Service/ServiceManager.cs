using Contracts;
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

        public ServiceManager(IRepositoryManager repositoryManager , ILoggerManager loggerManager)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager , loggerManager));
            _videoService = new Lazy<IVideoService>(() => new VideoService(repositoryManager , loggerManager));
        }
        public IUserService UserService => _userService.Value;

        public IVideoService VideoService => _videoService.Value;
    }
}
