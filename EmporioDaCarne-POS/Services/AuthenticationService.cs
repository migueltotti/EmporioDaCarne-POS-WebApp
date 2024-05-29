using EmporioDaCarne_POS.Models.Enums;

namespace EmporioDaCarne_POS.Services
{
    public static class AuthenticationService   
    {
        public static bool _authorization { get; private set; } = false;

        public static void SetTrueAuthorization()
        {
            _authorization = true;
        }

        public static void SetFalseAuthorization()  
        {
            _authorization = false;
        }

        public static bool GetAuthorization()
        {
            return _authorization;
        }
    }
}
