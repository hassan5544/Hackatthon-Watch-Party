using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Repository
{
    public class UserRepository : RepositoryBase<User> , IUsersRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {

        }
        public IEnumerable<User> GetAllUsers(bool trackChanges) =>
                FindAll(trackChanges)
                .OrderBy(c => c.Name)
                .ToList();
    }
}
