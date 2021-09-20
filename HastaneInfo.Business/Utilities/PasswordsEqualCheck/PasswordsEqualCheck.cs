using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneInfo.WebFormsUI.Utilities.PasswordsEqualCheck
{
    public class PasswordsEqualCheck
    {
        public bool CheckPasswordsToEqual(string newPassword, string newPasswordAgain)
        {
            if (newPassword == newPasswordAgain)
            {
                return true;
            }

            return false;
        }
    }
}
