using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NUHRandomizer.Models
{
    public partial class Randomize : System.Web.UI.Page
    {
        NUHRandomizerEntities context = new NUHRandomizerEntities();
        Random random = new Random();
        int lowHighNumber;
        int stopContinueNumber;
        int strata;
        string ars;
        string trialID;
        protected void Page_Load(object sender, EventArgs e)
        {
            lowHighNumber = random.Next(0, 10);
            stopContinueNumber = random.Next(0, 10);
        }

        protected void ButtonRandomize_Click(object sender, EventArgs e)
        {
            if(lowHighNumber < 5)
            {
                strata = 1;
            }
            else
            {
                strata = 2;
            }
            if(stopContinueNumber < 5)
            {
                ars = "s";
            }
            else
            {
                ars = "c";
            }
            List<Patient> patients = context.Patients.ToList();
            int count = context.Patients.Count();
            
        }
    }
}