using Konstruction.Helpers;
using Konstruction.Model;
using Konstruction.Model.Class;
using Konstruction.Model.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.DirectoryServices;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Konstruction.Controllers
{
    public class SecurityController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login(string msg)
        {
            LoginViewModel model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]

        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                using (var db = new KonstructionEntities())
                {
                    if (((model.UserName.ToLower() == "safeportal" || model.UserName.ToLower() == "safeportal2") && model.Password == ConfigurationManager.AppSettings["OverridePassword"]))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                        UserInfo ui = new UserInfo();
                        ui.UserName = model.UserName;
                        ui.UserRole = UserRole.Full;
                        SessionDataHelper.UserInfoData = ui;

                        return RedirectToLocal(returnUrl);
                    }
                    else if ((model.UserName.ToLower() == "reader" && model.Password == ConfigurationManager.AppSettings["OverridePassword"]))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                        UserInfo ui = new UserInfo();
                        ui.UserName = model.UserName;
                        ui.UserRole = UserRole.Read;
                        SessionDataHelper.UserInfoData = ui;

                        return RedirectToLocal(returnUrl);
                    }
                    else if ((model.UserName.ToLower() == "create" && model.Password == ConfigurationManager.AppSettings["OverridePassword"]))
                    {
                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                        UserInfo ui = new UserInfo();
                        ui.UserName = model.UserName;
                        ui.UserRole = UserRole.Create;
                        SessionDataHelper.UserInfoData = ui;

                        return RedirectToLocal(returnUrl);
                    }
                    else
                    {
                        #region Login

                        var adSettings = db.ActiveDirectorySetting.FirstOrDefault(x => x.Type == 1);
                        if (adSettings != null)
                        {
                            try
                            {
                                using (var dictionaryEntry = new DirectoryEntry(adSettings.DC, model.UserName, model.Password))
                                {
                                    dictionaryEntry.Path = adSettings.Path;
                                    dictionaryEntry.AuthenticationType = AuthenticationTypes.Secure;

                                    var search = new DirectorySearcher(dictionaryEntry);
                                    search.Filter = "(cn=" + model.UserName + ")";
                                    SearchResult result = search.FindOne();
                                                               
                                    if (result != null)
                                    {
                                        UserInfo ui = new UserInfo();
                                        ui.UserRole = UserRole.Read;

                                        ResultPropertyCollection fields = result.Properties;
                                        foreach (String ldapField in fields.PropertyNames)
                                        {
                                            if (ldapField.ToLower().Replace(" ", "").Equals("memberof"))
                                            {
                                                foreach (Object myCollection in fields[ldapField])
                                                {
                                                    var userRolesString = myCollection.ToString().Replace("CN=", "");
                                                    var userRoles = userRolesString.Split(',');
                                                    if (userRoles.Length > 0)
                                                    {
                                                        switch (userRoles[0])
                                                        {
                                                            case "K":
                                                                ui.UserRole = UserRole.Full;
                                                                break;
                                                            case "K_PL":
                                                                ui.UserRole = UserRole.Create;
                                                                break;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                           
                                        ui.UserName = model.UserName;
                               
                                        SessionDataHelper.UserInfoData = ui;

                                        FormsAuthentication.SetAuthCookie(model.UserName, false);
                                        return RedirectToLocal(returnUrl);
                                    }
                                    else
                                    {
                                        ModelState.AddModelError("ValidationMessage", "Unbekannter Benutzer.");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                ModelState.AddModelError("ValidationMessage", "Verbindung zur Domäne nicht möglich: " + ex.Message);
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("ValidationMessage", "Parametrisierung des AD-Zugriffs nicht verfügbar.");
                        }

                        #endregion Login
                    }
                }
            }

            return View(model);
        }

        public ActionResult Unauthorized()
        {
            return View();
        }

        public ActionResult InvalidOperation()
        {

            return View();
        }

        public ActionResult NotFound()
        {
            return View();
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Form2Index", "Form");
            }
        }

        [AllowAnonymous]
        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Login");
        }

    }
}
