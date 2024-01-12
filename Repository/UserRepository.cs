using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : RepositoryBase<User> , IUsersRepository
    {
        public UserRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
        {

        }

    }
}
