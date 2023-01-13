using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiOtelWebForm
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Rooms.aspx?Tarih1="+Tarih1.SelectedDate.ToShortDateString()+"&Tarih2="+Tarih2.SelectedDate.ToShortDateString());
           
        }
    }
}