using PageWeb.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ControllerTest testcontroller = new ControllerTest();
        List<Dictionary<string, string>> cumples = new List<Dictionary<string, string>>();
        string cumpleaños = "";
        string nombre = "";

        bool dropdownCreated = false;
        public WebForm1()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            loadBirthdate();

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = "El cumpleaños de "  + DropDownList1.SelectedItem+ " es el " + DropDownList1.SelectedValue;
            DropDownList1.Items.Clear();
            loadBirthdate();
        }
        public void loadBirthdate()
        {
            int contador = 0;
            cumples = testcontroller.GetAllCumples();
            foreach (var item in cumples)
            {
                foreach (var i in item)
                {
                    DropDownList1.Items.Add(i.Key);
                    DropDownList1.Items[contador].Value = i.Value; 
                }
                contador++;
            }
        }
    }
}