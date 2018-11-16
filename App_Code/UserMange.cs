using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UserMange
/// </summary>
public class UserMange
{
        private string Email;
    public string EMAIL
    {
        get { return Email; }
        set { Email = value; }
    }
    private string Password;
    public string PASSWORD
    {
        get { return Password; }
        set { Password = value; }
    }
    public UserMange(string Email, string Password)
    {
            this.Email = Email;
            this.Password = Password;
    }
}