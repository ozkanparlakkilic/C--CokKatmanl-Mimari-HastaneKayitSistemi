using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneInfo.WebFormsUI.Utilities.HashPassword
{
    public class HashPassword
    {
        private string hashPassword;
        SHA1 sha = new SHA1CryptoServiceProvider();

        public string hashPasswordText(TextBox textBox)
        {
            hashPassword = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(textBox.Text)));
            return hashPassword;
        }
    }
}
