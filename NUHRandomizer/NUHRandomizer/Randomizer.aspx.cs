using NUHRandomizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NUHRandomizer
{
    public partial class Randomizer : System.Web.UI.Page
    {
        NUHRandomizerEntities context = new NUHRandomizerEntities();
        Random random = new Random();
        int lowHighNumber;
        int stopContinueNumber;
        int extraRandom;
        int strata;
        string ars;
        int highCCount;
        int highSCount;
        int lowCCount;
        int lowSCount;
        int totalPatients;
        int count;
        int nextCount;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
                Response.Redirect("~\\Account\\Login.aspx");

            lowHighNumber = random.Next(0, 10);
            stopContinueNumber = random.Next(0, 10);
            nextCount = context.Patients.Count() + 1;         
            if (!IsPostBack)
            {
                List<Hospital> hospitals = context.Hospitals.ToList();
                ddlHospital.DataSource = hospitals;
                ddlHospital.DataTextField = "HospitalShortName";
                ddlHospital.DataValueField = "Id";
                ddlHospital.DataBind();
                BindddlResearchArm();

            }
            
        }
        private void BindddlResearchArm()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                ddlQhbsag.DataSource = cxt.ResearchArms.GroupBy(x => x.Strata).Select(x => x.FirstOrDefault()).ToList();
                ddlQhbsag.DataTextField = "Strata";
                ddlQhbsag.DataValueField = "id";
                ddlQhbsag.SelectedIndex = 0;
                ddlQhbsag.DataBind();
            }
        }

        protected void ButtonRandomize_Click(object sender, EventArgs e)
        {
            highCCount = context.ResearchArms.Where(x => x.Id == 1).Select(x => x.RecruitedCount).First();
            highSCount = context.ResearchArms.Where(x => x.Id == 2).Select(x => x.RecruitedCount).First();
            lowCCount = context.ResearchArms.Where(x => x.Id == 3).Select(x => x.RecruitedCount).First();
            lowSCount = context.ResearchArms.Where(x => x.Id == 4).Select(x => x.RecruitedCount).First();
            strata = ddlQhbsag.SelectedIndex;
            if (stopContinueNumber < 5)
            {
                ars = "s";
            }
            else
            {
                ars = "c";
            }
            List<Patient> patients = context.Patients.ToList();
            count = context.Patients.Count() + 1;
            Patient patient = new Patient();
            patient.PatientId = count.ToString("000");
            patient.TrialId = "HALT-" + count.ToString("000");
            totalPatients = context.ResearchArms.Select(x => x.RecruitedCount).Sum();

            if (strata == 1)
            {
                if (ars == "c")
                {
                    if (highCCount >= 28)
                    {                   
                        patient.ResearchArmsId = 2;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                        researchArm.RecruitedCount = highSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                    else
                    {
                        patient.ResearchArmsId = 1;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                        researchArm.RecruitedCount = highCCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if(highSCount >= 56)
                    {
                        patient.ResearchArmsId = 1;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                        researchArm.RecruitedCount = highSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                    else
                    {
                        patient.ResearchArmsId = 2;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                        researchArm.RecruitedCount = highSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                }
            }
            else
            {
                if (ars == "c")
                {
                    if (lowCCount >= 28)
                    {
                        patient.ResearchArmsId = 4;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                        researchArm.RecruitedCount = lowSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                    else
                    {
                        patient.ResearchArmsId = 3;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                        researchArm.RecruitedCount = lowCCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                }
                else
                {
                    if(lowSCount >= 56)
                    {
                        patient.ResearchArmsId = 3;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                        researchArm.RecruitedCount = lowSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                    else
                    {
                        patient.ResearchArmsId = 4;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                        researchArm.RecruitedCount = lowSCount + 1;
                        patient.RecruitStatusId = 1;
                        patient.RecruitDate = DateTime.Now;
                        patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);
                        context.Patients.Add(patient);
                        context.SaveChanges();
                    }
                }
            }
            int id = patient.ResearchArmsId;
            if (id == 1)
            {
                Label1.Text = "Subject Number : " + patient.TrialId +
                    "<br/>Hospital: " + ddlHospital.SelectedItem +
                    "<br/>qHBsAg : High(≥10IU/ml)<br/>Treatment Arm : Continue";
            }
            else if (id == 2)
            {
                Label1.Text = "Subject Number : " + patient.TrialId +
                    "<br/>Hospital: " + ddlHospital.SelectedItem +
                    "<br/>qHBsAg : High(≥10IU/ml)<br/>Treatment Arm : Halt";
            }
            else if (id == 3)
            {
                Label1.Text = "Subject Number : " + patient.TrialId +
                    "<br/>Hospital: " + ddlHospital.SelectedItem +
                      "<br/>qHBsAg : Low(<10IU/ml)<br/>Treatment Arm : Continue";
            }
            else
            {
                Label1.Text = "Subject Number : " + patient.TrialId +
                    "<br/>Hospital: " + ddlHospital.SelectedItem +
                   "<br/>qHBsAg : Low(<10IU/ml)<br/>Treatment Arm : Halt";
            }
            ddlHospital.SelectedIndex = 0;
            ddlQhbsag.SelectedIndex = 0;
            alertConfirm.Visible = true;
        }
    }
}
