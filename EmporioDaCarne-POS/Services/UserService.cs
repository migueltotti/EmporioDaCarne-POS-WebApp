using EmporioDaCarne_POS.Data;
using EmporioDaCarne_POS.Models;
using Microsoft.EntityFrameworkCore;

namespace EmporioDaCarne_POS.Services
{
    public class UserService
    {
        private readonly EmporioDaCarne_POSContext _context;

        public UserService(EmporioDaCarne_POSContext context)
        {
            _context = context;
        }

        public async Task<User> Authenticate(string email, string password)
        {

            if(email != null && password != null)
            {
                var result = await _context.User.FirstOrDefaultAsync(x => x.Email == email && x.Password == password);

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
