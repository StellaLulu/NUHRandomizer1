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
            txtPatientId.Text = "HALT-" + nextCount.ToString("000");
            if (!IsPostBack)
            {
                List<Hospital> hospitals = context.Hospitals.ToList();
                ddlHospital.DataSource = hospitals;
                ddlHospital.DataTextField = "HospitalShortName";
                ddlHospital.DataValueField = "Id";
                ddlHospital.DataBind();

            }
        }

        protected void ButtonRandomize_Click(object sender, EventArgs e)
        {
            highCCount = context.ResearchArms.Where(x => x.Id == 1).Select(x => x.RecruitedCount).First();
            highSCount = context.ResearchArms.Where(x => x.Id == 2).Select(x => x.RecruitedCount).First();
            lowCCount = context.ResearchArms.Where(x => x.Id == 3).Select(x => x.RecruitedCount).First();
            lowSCount = context.ResearchArms.Where(x => x.Id == 4).Select(x => x.RecruitedCount).First();
            if (lowHighNumber < 5)
            {
                strata = 1;
            }
            else
            {
                strata = 2;
            }
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
            if (totalPatients <= 160)
            {
                if (strata == 2 && ars == "c")
                {
                    if (highCCount >= 56)
                    {
                        if (highSCount >= 28)
                        {
                            extraRandom = random.Next(0, 10);
                            if (extraRandom < 5)
                            {
                                if (lowSCount < 28)
                                {
                                    patient.ResearchArmsId = 4;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                                    researchArm.RecruitedCount = lowSCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 3;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                                    researchArm.RecruitedCount = lowCCount + 1;
                                }
                            }
                            else
                            {
                                if (lowCCount < 56)
                                {
                                    patient.ResearchArmsId = 3;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                                    researchArm.RecruitedCount = lowCCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 4;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                                    researchArm.RecruitedCount = lowSCount + 1;
                                }
                            }
                        }
                        else
                        {
                            patient.ResearchArmsId = 2;
                            ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                            researchArm.RecruitedCount = highSCount + 1;

                        }
                    }
                    else
                    {
                        patient.ResearchArmsId = 1;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                        researchArm.RecruitedCount = highCCount + 1;
                    }

                }
                else if (strata == 2 && ars == "s")
                {
                    if (highSCount >= 28)
                    {
                        if (highCCount >= 56)
                        {
                            extraRandom = random.Next(0, 10);
                            if (extraRandom < 5)
                            {
                                if (lowSCount < 28)
                                {
                                    patient.ResearchArmsId = 4;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                                    researchArm.RecruitedCount = lowSCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 3;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                                    researchArm.RecruitedCount = lowCCount + 1;
                                }
                            }
                            else
                            {
                                patient.ResearchArmsId = 3;
                                ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                                researchArm.RecruitedCount = lowCCount + 1;

                            }
                        }
                        else
                        {
                            patient.ResearchArmsId = 1;
                            ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                            researchArm.RecruitedCount = highCCount + 1;
                        }
                    }
                    else
                    {
                        patient.ResearchArmsId = 2;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                        researchArm.RecruitedCount = highSCount + 1;
                    }
                }
                else if (strata == 1 && ars == "c")
                {
                    if (lowCCount >= 56)
                    {
                        if (lowSCount >= 28)
                        {
                            extraRandom = random.Next(0, 10);
                            if (extraRandom < 5)
                            {
                                if (highSCount < 28)
                                {
                                    patient.ResearchArmsId = 2;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                                    researchArm.RecruitedCount = highSCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 1;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                                    researchArm.RecruitedCount = highCCount + 1;
                                }
                            }
                            else
                            {
                                if (highCCount < 56)
                                {
                                    patient.ResearchArmsId = 1;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                                    researchArm.RecruitedCount = highCCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 2;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                                    researchArm.RecruitedCount = highSCount + 1;
                                }

                            }
                        }
                        else
                        {
                            patient.ResearchArmsId = 4;
                            ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                            researchArm.RecruitedCount = lowSCount + 1;
                        }
                    }
                    else
                    {
                        patient.ResearchArmsId = 3;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                        researchArm.RecruitedCount = lowCCount + 1;
                    }
                }
                else
                {
                    if (lowSCount >= 28)
                    {
                        if (lowCCount >= 56)
                        {
                            extraRandom = random.Next(0, 10);
                            if (extraRandom < 5)
                            {
                                if (highSCount < 28)
                                {
                                    patient.ResearchArmsId = 2;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                                    researchArm.RecruitedCount = highSCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 1;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                                    researchArm.RecruitedCount = highCCount + 1;
                                }
                            }
                            else
                            {
                                if (highCCount < 56)
                                {
                                    patient.ResearchArmsId = 1;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 1).First();
                                    researchArm.RecruitedCount = highCCount + 1;
                                }
                                else
                                {
                                    patient.ResearchArmsId = 2;
                                    ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 2).First();
                                    researchArm.RecruitedCount = highSCount + 1;
                                }

                            }
                        }
                        else
                        {
                            patient.ResearchArmsId = 3;
                            ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 3).First();
                            researchArm.RecruitedCount = lowCCount + 1;
                        }
                    }
                    else
                    {
                        patient.ResearchArmsId = 4;
                        ResearchArm researchArm = context.ResearchArms.Where(x => x.Id == 4).First();
                        researchArm.RecruitedCount = lowSCount + 1;
                    }
                }

                patient.RecruitStatusId = 1;
                patient.RecruitDate = DateTime.Now;
                patient.HospitalId = Int32.Parse(ddlHospital.SelectedValue);

                context.Patients.Add(patient);
                context.SaveChanges();
                int id = patient.ResearchArmsId;
                if (id == 1)
                {
                    //MessageBox.Show("Patient " + txtPatientId.Text + " has been assigned to\n" +
                    //    "Strata : HIGH\nAssigned Random Sequence : C");
                    Label1.Text = "Patient : " + txtPatientId.Text  +
                        "<br/>Strata : HIGH<br/>Assigned Random Sequence : C";
                }
                else if (id == 2)
                {
                    //MessageBox.Show("Patient " + txtPatientId.Text + " has been assigned to\n" +
                    //    "Strata : HIGH\nAssigned Random Sequence : S");
                    Label1.Text = "Patient : " + txtPatientId.Text  +
                        "<br/>Strata : HIGH<br/>Assigned Random Sequence : S";
                }
                else if (id == 3)
                {
                    //MessageBox.Show("Patient " + txtPatientId.Text + " has been assigned to\n" +
                    //    "Strata : LOW\nAssigned Random Sequence : C");
                    Label1.Text = "Patient : " + txtPatientId.Text  +
                          "<br/>Strata : LOW<br/>Assigned Random Sequence : C";
                }
                else
                {
                    //MessageBox.Show("Patient " + txtPatientId.Text + " has been assigned to\n" +
                    //    "Strata : LOW\nAssigned Random Sequence : S");
                    Label1.Text = "Patient : " + txtPatientId.Text  +
                       "<br/>Strata : LOW<br/>Assigned Random Sequence : S";
                }
            }
            else
            {
                //MessageBox.Show("Total patients quentity greater than 160");
                Label2.Text = "Total patients quentity greater than 160";
            }
            nextCount = context.Patients.Count() + 1;
            txtPatientId.Text = "HALT-" + nextCount.ToString("000");
            ddlHospital.SelectedIndex = 0;
            alertConfirm.Visible = true;
        }
    }
}
