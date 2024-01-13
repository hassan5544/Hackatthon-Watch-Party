using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IUsersRepository
    {
        IEnumerable<User> GetAllUsers(bool trackChanges);

        User GetUserByNameAndPassword(string UserName, string Password , bool trackChanges);
    }
}
