using EmporioDaCarne_POS.Models;
using EmporioDaCarne_POS.Models.Enums;

namespace EmporioDaCarne_POS.Services
{
    public static class AuthenticationService   
    {
        public static bool _authorization { get; private set; } = false;
        public static User _userAuthenticated { get; private set; }

        public static void SetTrueAuthorization(User user)
        {
            _authorization = true;
            _userAuthenticated = user;
        }

        public static void SetFalseAuthorization()  
        {
            _authorization = false;
            _userAuthenticated = null;
        }

        public static bool GetAuthorization()
        {
            return _authorization;
        }

        public static User GetUserAuthenticated()
        {
            return _userAuthenticated;
        }
    }
}
