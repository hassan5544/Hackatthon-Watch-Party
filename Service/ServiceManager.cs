using AutoMapper;
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

        public ServiceManager(IRepositoryManager repositoryManager , ILoggerManager loggerManager , IMapper mapper)
        {
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager , loggerManager , mapper));
            _videoService = new Lazy<IVideoService>(() => new VideoService(repositoryManager , loggerManager , mapper));
        }
        public IUserService UserService => _userService.Value;

        public IVideoService VideoService => _videoService.Value;
    }
}
