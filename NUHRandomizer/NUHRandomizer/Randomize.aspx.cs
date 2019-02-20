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
        int extraRandom;
        int strata;
        string ars;
        int highCCount;
        int highSCount;
        int lowCCount;
        int lowSCount;
        protected void Page_Load(object sender, EventArgs e)
        {
            lowHighNumber = random.Next(0, 10);
            stopContinueNumber = random.Next(0, 10);
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
            if(stopContinueNumber < 5)
            {
                ars = "s";
            }
            else
            {
                ars = "c";
            }
            List<Patient> patients = context.Patients.ToList();
            int count = context.Patients.Count() + 1;
            Patient patient = new Patient();
            patient.PatientId = count.ToString("000");
            patient.TrialId = "HALT" + count.ToString("000");
            if(strata == 2 && ars == "c")
            {                
                if(highCCount >= 56)
                {                   
                    if(highSCount >= 28)
                    {
                        extraRandom = random.Next(0, 10);
                        if(extraRandom < 5)
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
            else if(strata == 2 && ars == "s")
            {
                if(highSCount >= 28)
                {
                    if(highCCount >= 56)
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
            else if(strata == 1 && ars == "c")
            {
                if(lowCCount >= 56)
                {
                    if(lowSCount >= 28)
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
                if(lowSCount >= 28)
                {
                    if(lowCCount >= 56)
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
            patient.Remarks = txtRemarks.Text;
            patient.HospitalId = 1;
            context.Patients.Add(patient);
            context.SaveChanges();
        }
    }
}