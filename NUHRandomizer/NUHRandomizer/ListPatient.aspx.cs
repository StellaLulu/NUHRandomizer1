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
    public partial class ListPatient : System.Web.UI.Page
    {
        NUHRandomizerEntities cxt = new NUHRandomizerEntities();

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

            if (!IsPostBack)
            {
                //BindGdvPatient();
                BindddlResearchArm();
                BindddlARS();
                BindddlHospital();
            }
        }

        //private void BindGdvPatient()
        //{
        //    using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
        //    {
        //        int id = Convert.ToInt32(ddlResearchArm.SelectedValue);
        //        if (ddlResearchArm.SelectedValue == "0")
        //        {
        //            gdvPatient.DataSource = cxt.Patients.ToList();
        //            gdvPatient.DataBind();
        //        }
        //        else
        //        {
        //            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == id).ToList();
        //            gdvPatient.DataBind();
        //        }
        //    }
        //}

        // Drop Down List for Research Arm
        private void BindddlResearchArm()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                ddlResearchArm.DataSource = cxt.ResearchArms.GroupBy(x => x.Strata).Select(x => x.FirstOrDefault()).ToList();
                ddlResearchArm.DataTextField = "Strata";
                ddlResearchArm.DataValueField = "id";
                ddlResearchArm.SelectedIndex = 0;
                ddlResearchArm.DataBind();
            }
        }

        //protected void ddlResearchArm_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
        //    {
        //        int id = Convert.ToInt32(ddlResearchArm.SelectedValue);
        //        if (id == 1 || id == 3)
        //        {
        //            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1 || x.ResearchArmsId == 2).ToList();
        //        }
        //        else if (id == 2 || id == 4)
        //        {
        //            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 3 || x.ResearchArmsId == 4).ToList();
        //        }
        //        gdvPatient.DataBind();
        //    }
        //    btnClear.Visible = true;
        //}

        // Drop Down List of ARS
        private void BindddlARS()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                ddlARS.DataSource = cxt.ResearchArms.GroupBy(x => x.ARS).Select(x => x.FirstOrDefault()).ToList();
                ddlARS.DataTextField = "ARS";
                ddlARS.DataValueField = "id";
                ddlARS.SelectedIndex = 0;
                ddlARS.DataBind();
            }
        }

        //protected void ddlARS_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
        //    {
        //        if(ddlResearchArm.SelectedIndex != 0)
        //        {
        //            int researchArmId = Convert.ToInt32(ddlResearchArm.SelectedValue);
        //            List<Patient> list = cxt.Patients.Where(x => x.ResearchArmsId == researchArmId).ToList();
        //            int id2 = Convert.ToInt32(ddlARS.SelectedValue);
        //            if (id2 == 1 || id2 == 3)
        //            {
        //                gdvPatient.DataSource = list.Where(x => x.ResearchArmsId == 1 || x.ResearchArmsId == 3).ToList();
        //            }
        //            else if (id2 == 2 || id2 == 4)
        //            {
        //                gdvPatient.DataSource = list.Where(x => x.ResearchArmsId == 2 || x.ResearchArmsId == 4).ToList();
        //            }
        //        }
        //        else
        //        {
        //            int id = Convert.ToInt32(ddlARS.SelectedValue);
        //            if (id == 1 || id == 3)
        //            {
        //                gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1 || x.ResearchArmsId == 3).ToList();
        //            }
        //            else if (id == 2 || id == 4)
        //            {
        //                gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 2 || x.ResearchArmsId == 4).ToList();
        //            }
        //        }

        //        gdvPatient.DataBind();
        //    }
        //    btnClear.Visible = true;
        //}

        // Drop Down List for Hospitals
        private void BindddlHospital()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                ddlHospital.DataSource = cxt.Hospitals.ToList();
                ddlHospital.DataTextField = "HospitalShortName";
                ddlHospital.DataValueField = "id";
                ddlHospital.SelectedIndex = 0;
                ddlHospital.DataBind();
            }
        }

        //protected void ddlHospital_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
        //    {
        //        int id = Convert.ToInt32(ddlHospital.SelectedValue);
        //        gdvPatient.DataSource = cxt.Patients.Where(x => x.HospitalId == id).ToList();
        //        gdvPatient.DataBind();
        //    }
        //    btnClear.Visible = true;
        //}

        //private List<Patient> ListPatients()
        //{
        //    using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
        //    {
        //        int id = Convert.ToInt32(ddlResearchArm.SelectedValue);
        //        if (ddlResearchArm.SelectedValue == "0")
        //        {
        //            return cxt.Patients.ToList();
        //        }
        //        else
        //        {
        //            return cxt.Patients.Where(x => x.ResearchArmsId == id).ToList();
        //        }
        //    }
        //}

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //ddlResearchArm.ClearSelection();
            //ddlARS.ClearSelection();
            //ddlHospital.ClearSelection();
            //btnClear.Visible = false;
            int arm = ddlResearchArm.SelectedIndex;
            int ars = ddlARS.SelectedIndex;
            int hospital = ddlHospital.SelectedIndex;
            if(arm == 0 && ars == 0 && hospital == 0)
            {
                gdvPatient.DataSource = cxt.Patients.ToList();
                gdvPatient.DataBind();
            }
            else
            {
                if(arm == 0 && ars == 0 && hospital != 0)
                {
                    gdvPatient.DataSource = cxt.Patients.Where(x => x.HospitalId == hospital).ToList();
                    gdvPatient.DataBind();
                }
                else if(arm == 0 && ars != 0 && hospital == 0)
                {
                    if(ars == 1)
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1 || x.ResearchArmsId == 3).ToList();
                        gdvPatient.DataBind();
                    }
                    else
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 2 || x.ResearchArmsId == 4).ToList();
                        gdvPatient.DataBind();
                    }
                }else if(arm == 0 && ars != 0 && hospital != 0)
                {
                    if(ars == 1)
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => (x.ResearchArmsId == 1 || x.ResearchArmsId == 3) && x.HospitalId == hospital).ToList();
                        gdvPatient.DataBind();
                    }
                    else
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => (x.ResearchArmsId == 2 || x.ResearchArmsId == 4) && x.HospitalId == hospital).ToList();
                        gdvPatient.DataBind();
                    }
                }else if(arm != 0 && ars == 0 && hospital == 0)
                {
                    if(arm == 1)
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1 || x.ResearchArmsId == 2).ToList();
                        gdvPatient.DataBind();
                    }
                    else
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 3 || x.ResearchArmsId == 4).ToList();
                        gdvPatient.DataBind();
                    }
                }else if(arm != 0 && ars == 0 && hospital != 0)
                {
                    if (arm == 1)
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => (x.ResearchArmsId == 1 || x.ResearchArmsId == 2) && x.HospitalId == hospital).ToList();
                        gdvPatient.DataBind();
                    }
                    else
                    {
                        gdvPatient.DataSource = cxt.Patients.Where(x => (x.ResearchArmsId == 3 || x.ResearchArmsId == 4) && x.HospitalId == hospital).ToList();
                        gdvPatient.DataBind();
                    }
                }else if(arm != 0 && ars != 0 && hospital == 0)
                {
                    if(arm == 1)
                    {
                        if(ars == 1)
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1).ToList();
                            gdvPatient.DataBind();
                        }
                        else
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 2).ToList();
                            gdvPatient.DataBind();
                        }
                    }
                    else
                    {
                        if(ars == 1)
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 3).ToList();
                            gdvPatient.DataBind();
                        }
                        else
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 4).ToList();
                            gdvPatient.DataBind();
                        }
                    }
                }
                else
                {
                    if (arm == 1)
                    {
                        if (ars == 1)
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 1 && x.HospitalId == hospital).ToList();
                            gdvPatient.DataBind();
                        }
                        else
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 2 && x.HospitalId == hospital).ToList();
                            gdvPatient.DataBind();
                        }
                    }
                    else
                    {
                        if (ars == 1)
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 3 && x.HospitalId == hospital).ToList();
                            gdvPatient.DataBind();
                        }
                        else
                        {
                            gdvPatient.DataSource = cxt.Patients.Where(x => x.ResearchArmsId == 4 && x.HospitalId == hospital).ToList();
                            gdvPatient.DataBind();
                        }
                    }
                }

            }


        }

        protected void btnPrint_Click(object sender, EventArgs e)
        {
            tblddl.Attributes.Add("style", "display: none");
            btnBack.Visible = true;
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            tblddl.Attributes.Add("style", "display: block");
            tblddl.Attributes.Add("style", "margin: 0 auto");
            btnBack.Visible = false;
        }
    }
}