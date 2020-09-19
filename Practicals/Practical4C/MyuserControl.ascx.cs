using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical4C
{
    public partial class MyuserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSave.Click += new EventHandler(this.txtSave_Click);

        }
        protected void txtSave_Click(object sender, EventArgs e)
        {
            Label1.Text = "Your Name is " + txtName.Text + " and you are from " +
           txtcity.Text;
        }
    }
}