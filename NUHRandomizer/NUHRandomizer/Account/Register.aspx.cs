using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using NUHRandomizer.Models;
using System.Collections.Generic;
using Microsoft.AspNet.Identity.EntityFramework;


namespace NUHRandomizer.Account
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.User.Identity.IsAuthenticated)
            {
                if (Page.User.IsInRole("User"))
                    Response.Redirect("~\\Default.aspx");
                if (Page.User.IsInRole("Coordinator"))
                    Response.Redirect("~\\Randomizer.aspx");
            }
            else
            {
                Response.Redirect("~\\Account\\Login.aspx");
            }

               


            if (!IsPostBack)
            {
                LoadHospital();
            }
        }

        private void LoadHospital()
        {
            ddlHospital.DataSource = ListHospital();
            ddlHospital.DataTextField = "HospitalName";
            ddlHospital.DataValueField = "id";
            ddlHospital.DataBind();

        }

        private List<Hospital> ListHospital()
        {
            using (NUHRandomizerEntities cxt = new NUHRandomizerEntities())
            {
                return cxt.Hospitals.ToList();
            }
        }

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = txtEmail.Text, Email = txtEmail.Text, EmployeeName = txtEmployeeName.Text, HospitalId = Convert.ToInt32(ddlHospital.SelectedValue) };
            IdentityResult result = manager.Create(user, txtPassword.Text);
            string s = user.Id;

            if (result.Succeeded)
            {
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
                //userManager.AddToRole(s, "Administrator");
                userManager.AddToRole(s, "User");
                //userManager.AddToRole(s, "Coordinator");
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}