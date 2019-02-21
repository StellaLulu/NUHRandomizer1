using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using NUHRandomizer.Models;

namespace NUHRandomizer
{
    public partial class _Default : System.Web.UI.Page
    {
        private static string uDept;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                if (Page.User.IsInRole("Coordinator"))
                    Response.Redirect("~\\Randomizer.aspx");
            }
            else
            {
                Response.Redirect("~\\Account\\Login.aspx");
            }

            lblNUH.Text = ListNUH().Count.ToString();
            lblNUHHighC.Text = ListNUHHighC().Count.ToString();
            lblNUHHighS.Text = ListNUHHighS().Count.ToString();
            lblNUHLowC.Text = ListNUHLowC().Count.ToString();
            lblNUHLowS.Text = ListNUHLowS().Count.ToString();

            lblCGH.Text = ListCGH().Count.ToString();
            lblCGHHighC.Text = ListCGHHighC().Count.ToString();
            lblCGHHighS.Text = ListCGHHighS().Count.ToString();
            lblCGHLowC.Text = ListCGHLowC().Count.ToString();
            lblCGHLowS.Text = ListCGHLowS().Count.ToString();

            lblTTSH.Text = ListTTSH().Count.ToString();
            lblTTSHHighC.Text = ListTTSHHighC().Count.ToString();
            lblTTSHHighS.Text = ListTTSHHighS().Count.ToString();
            lblTTSHLowC.Text = ListTTSHLowC().Count.ToString();
            lblTTSHLowS.Text = ListTTSHLowS().Count.ToString();


            lblSGH.Text = ListSGH().Count.ToString();
            lblSGHHighC.Text = ListSGHHighC().Count.ToString();
            lblSGHHighS.Text = ListSGHHighS().Count.ToString();
            lblSGHLowC.Text = ListSGHLowC().Count.ToString();
            lblSGHLowS.Text = ListSGHLowS().Count.ToString();

            lblTotal.Text = ListPatients().Count.ToString();
            lblTotalHighC.Text = ListPatientsHighC().Count.ToString();
            lblTotalHighS.Text = ListPatientsHighS().Count.ToString();
            lblTotalLowC.Text = ListPatientsLowC().Count.ToString();
            lblTotalLowS.Text = ListPatientsLowS().Count.ToString();
        }

        protected List<Patient> ListNUH()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "NUH").ToList();
            }
        }
        protected List<Patient> ListNUHHighC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "NUH" && x.ResearchArmsId == 1).ToList();
            }
        }
        protected List<Patient> ListNUHHighS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "NUH" && x.ResearchArmsId==2).ToList();
            }
        }
        protected List<Patient> ListNUHLowC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "NUH" && x.ResearchArmsId == 3).ToList();
            }
        }
        protected List<Patient> ListNUHLowS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "NUH" && x.ResearchArmsId == 4).ToList();
            }
        }
        protected List<Patient> ListCGH()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "CGH").ToList();
            }
        }
        protected List<Patient> ListCGHHighC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "CGH" && x.ResearchArmsId == 1).ToList();
            }
        }
        protected List<Patient> ListCGHHighS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "CGH" && x.ResearchArmsId == 2).ToList();
            }
        }
        protected List<Patient> ListCGHLowC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "CGH" && x.ResearchArmsId == 3).ToList();
            }
        }
        protected List<Patient> ListCGHLowS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "CGH" && x.ResearchArmsId == 4).ToList();
            }
        }
        protected List<Patient> ListTTSH()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "TTSH").ToList();
            }
        }
        protected List<Patient> ListTTSHHighC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "TTSH" && x.ResearchArmsId == 1).ToList();
            }
        }
        protected List<Patient> ListTTSHHighS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "TTSH" && x.ResearchArmsId == 2).ToList();
            }
        }
        protected List<Patient> ListTTSHLowC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "TTSH" && x.ResearchArmsId == 3).ToList();
            }
        }
        protected List<Patient> ListTTSHLowS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "TTSH" && x.ResearchArmsId == 4).ToList();
            }
        }
        protected List<Patient> ListSGH()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "SGH").ToList();
            }
        }
        protected List<Patient> ListSGHHighC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "SGH" && x.ResearchArmsId == 1).ToList();
            }
        }
        protected List<Patient> ListSGHHighS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "SGH" && x.ResearchArmsId == 2).ToList();
            }
        }
        protected List<Patient> ListSGHLowC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "SGH" && x.ResearchArmsId == 3).ToList();
            }
        }
        protected List<Patient> ListSGHLowS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.Hospital.HospitalShortName == "SGH" && x.ResearchArmsId == 4).ToList();
            }
        }
        protected List<Patient> ListPatients()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.ToList();
            }
        }
        protected List<Patient> ListPatientsHighC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.ResearchArmsId == 1).ToList();
            }
        }
        protected List<Patient> ListPatientsHighS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.ResearchArmsId == 2).ToList();
            }
        }
        protected List<Patient> ListPatientsLowC()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.ResearchArmsId == 3).ToList();
            }
        }
        protected List<Patient> ListPatientsLowS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Patients.Where(x => x.ResearchArmsId == 4).ToList();
            }
        }
    }
}