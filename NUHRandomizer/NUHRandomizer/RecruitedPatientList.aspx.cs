using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using NUHRandomizer.Models;

namespace NUHRandomizer
{
    public partial class RecruitedPatientList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated)
                Response.Redirect("~\\Account\\Login.aspx");
            else
            {
                if (!IsPostBack)
                {
                    PopulatePatient();
                }
            }

        }

        private void PopulatePatient()
        {
            var user = Context.GetOwinContext().GetUserManager<ApplicationUserManager>()
                .FindById(User.Identity.GetUserId());
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                gdvPatients.DataSource = cxt.Patients.Where(x => x.HospitalId == user.HospitalId).ToList();
                gdvPatients.DataBind();
            }

        }

        protected void OnRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvPatients.EditIndex = -1;
            PopulatePatient();
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvPatients.EditIndex = e.NewEditIndex;

            PopulatePatient();

        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if ((e.Row.RowState & DataControlRowState.Edit) > 0)
                {
                    NUHRandomizerEntities cxt = new NUHRandomizerEntities();
                    DropDownList ddlStatus = (e.Row.FindControl("ddlStatus") as DropDownList);
                    ddlStatus.DataSource = cxt.RecruitmentStatus.ToList();
                    ddlStatus.DataTextField = "Status";
                    ddlStatus.DataValueField = "Id";
                    ddlStatus.DataBind();
                }
            }
           
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            NUHRandomizerEntities cxt = new NUHRandomizerEntities();
            GridViewRow row = gdvPatients.Rows[e.RowIndex];

            int status = Convert.ToInt32(((row.FindControl("ddlStatus") as DropDownList).SelectedValue));
            string remark = (row.FindControl("txtRemark") as TextBox).Text;

            int patient = Convert.ToInt32(gdvPatients.DataKeys[e.RowIndex].Value.ToString());
            var result = cxt.Patients.SingleOrDefault(x => x.Id == patient);
            if (result != null)
            {
                result.RecruitStatusId = status;
                result.Remarks = remark;
                cxt.SaveChanges();
            }

            gdvPatients.EditIndex = -1;
            PopulatePatient();
        }
    }
}