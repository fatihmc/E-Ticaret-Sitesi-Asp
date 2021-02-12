using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace itpwebsite
{

    public static class Globals
    {
        //public const bool IsLoggedIn = false;
        ////{
        ////    get { return} 
        ////}
        
        static bool _isLoggedIn = false;
        public static bool IsLoggedIn {
            get { return _isLoggedIn; }
            set
            {
                _isLoggedIn = value;
            }
            
        }


    }
    public partial class Site1 : System.Web.UI.MasterPage
    {
        bool isLoggedln = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}