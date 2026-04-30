using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CelciousFahrenheitConverter;

namespace WeatherApp
{
    public partial class DefaultPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void TempConv_btn_Click(object sender, EventArgs e)
        {
            if (TempConvSelect_ddl.Text == "C2F")
            {
                try
                {
                    double c = Double.Parse(TempConvInput_txt.Text);
                    double f = TempConverter.CtoF(c);
                    TempConvOutput_lbl.Text = f.ToString();
                }
                catch (FormatException ef)
                {
                    TempConvOutput_lbl.Text = "Enter a double";
                }
            }
            else if (TempConvSelect_ddl.Text == "F2C")
            {
                try
                {
                    double f = Double.Parse(TempConvInput_txt.Text);
                    double c = TempConverter.FtoC(f);
                    TempConvOutput_lbl.Text = c.ToString();
                }
                catch (FormatException ef)
                {
                    TempConvOutput_lbl.Text = "Enter a double";
                }
            }
            else
            {
                TempConvOutput_lbl.Text = "Please select a converter;";
            }
        }
    }
}