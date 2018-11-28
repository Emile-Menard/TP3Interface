using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_PM
{
    public static class UserMethods
    {
        public static bool Exists(this PhotoManagerClient.User u)
        {
            return u != null;
        }
    }

    //Convertit les items dans la ListBox en un string où ces derniers sont séparés par des espaces
    public static class GenericMethods
    {
        public static string ListBoxToString(this ListBox lbx)
        {
            string str = "";
            foreach (string item in lbx.Items)
            {
                str += item;
                str += " ";
            }
            //Enlever le dernier espace de trop à la fin
            if (str != "")
            {
                str = str.Remove(str.Length - 1);
            }

            return str;
        }
    }

   
}
