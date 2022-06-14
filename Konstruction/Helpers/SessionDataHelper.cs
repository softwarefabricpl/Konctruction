using Konstruction.Model.Class;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Konstruction.Helpers
{
    public class SessionDataHelper
    {
        protected static HttpSessionState Session { get { return HttpContext.Current.Session; } }
        public static UserInfo UserInfoData
        {
            get
            {
                if (Session["UserInfoData"] == null)
                    Session["UserInfoData"] = null;
                return (UserInfo)Session["UserInfoData"];
            }
            set
            {
                Session["UserInfoData"] = value;
            }
        }

        #region form 2 session data
        public static Hashtable Form1PassZuweisungZSBNrData
        {
            get
            {
                if (Session["Form1PassZuweisungZSBNrData"] == null)
                    Session["Form1PassZuweisungZSBNrData"] = new Hashtable();
                return (Hashtable)Session["Form1PassZuweisungZSBNrData"];
            }
            set
            {
                Session["Form1PassZuweisungZSBNrData"] = value;
            }
        }
        public static Hashtable Form1PassZgRevisionData
        {
            get
            {
                if (Session["Form1PassZgRevisionData"] == null)
                    Session["Form1PassZgRevisionData"] = new Hashtable();
                return (Hashtable)Session["Form1PassZgRevisionData"];
            }
            set
            {
                Session["Form1PassZgRevisionData"] = value;
            }
        }
        public static Form1PassZuweisungZsbNrData GetForm1PassZuweisungZSBNrSessionData(string key )
        {
            if (HasForm1PassZuweisungZSBNrSessionData(key))
                return (Form1PassZuweisungZsbNrData)Form1PassZuweisungZSBNrData[key];

            return null;
        }
        public static Form1PassZgRevisioNrData GetForm1PassZgRevisionSessionData(string key)
        {
            if (HasForm1PassZgRevisionSessionData(key))
                return (Form1PassZgRevisioNrData)Form1PassZgRevisionData[key];

            return null;
        }
        public static void SetForm1PassZuweisungZSBNrSessionData(Form1PassZuweisungZsbNrData pf, string key)
        {
            if (Form1PassZuweisungZSBNrData[key] != null)
                Form1PassZuweisungZSBNrData[key] = pf;
            else
                Form1PassZuweisungZSBNrData.Add(key, pf);
        }
        public static void SetForm1PassZgRevisionSessionData(Form1PassZgRevisioNrData pf, string key)
        {
            if (Form1PassZgRevisionData[key] != null)
                Form1PassZgRevisionData[key] = pf;
            else
                Form1PassZgRevisionData.Add(key, pf);
        }
        public static bool HasForm1PassZuweisungZSBNrSessionData(string key)
        {
            return Form1PassZuweisungZSBNrData[key] != null;
        }
        public static bool HasForm1PassZgRevisionSessionData(string key)
        {
            return Form1PassZgRevisionData[key] != null;
        }
        
        public static void RemoveForm1PassZuweisungZSBNrSessionData(string key)
        {
            if (HasForm1PassZuweisungZSBNrSessionData(key))
                Form1PassZuweisungZSBNrData.Remove(key);
        }
        public static void RemoveForm1PassZgRevisionSessionData(string key)
        {
            if (HasForm1PassZgRevisionSessionData(key))
                Form1PassZgRevisionData.Remove(key);
        }

        #endregion

        #region form 1 session data
        public static Hashtable Form2KundeZuweisungZSBNrData
        {
            get
            {
                if (Session["Form2KundeZuweisungZSBNrData"] == null)
                    Session["Form2KundeZuweisungZSBNrData"] = new Hashtable();
                return (Hashtable)Session["Form2KundeZuweisungZSBNrData"];
            }
            set
            {
                Session["Form2KundeZuweisungZSBNrData"] = value;
            }
        }

        public static bool HasForm2KundeZuweisungZSBNrSessionData(string key)
        {
            return Form2KundeZuweisungZSBNrData[key] != null;
        }

        public static Form2KundeZuweisungZsbNrData GetForm2KundeZuweisungZSBNrSessionData(string key)
        {
            if (HasForm2KundeZuweisungZSBNrSessionData(key))
                return (Form2KundeZuweisungZsbNrData)Form2KundeZuweisungZSBNrData[key];

            return null;
        }
        public static void SetForm2KundeZuweisungZSBNrSessionData(Form2KundeZuweisungZsbNrData pf, string key)
        {
            if (Form2KundeZuweisungZSBNrData[key] != null)
                Form2KundeZuweisungZSBNrData[key] = pf;
            else
                Form2KundeZuweisungZSBNrData.Add(key, pf);
        }

        public static Hashtable Form2PassKundeZuweisungZSBNrData
        {
            get
            {
                if (Session["Form2PassKundeZuweisungZSBNrData"] == null)
                    Session["Form2PassKundeZuweisungZSBNrData"] = new Hashtable();
                return (Hashtable)Session["Form2PassKundeZuweisungZSBNrData"];
            }
            set
            {
                Session["Form2PassKundeZuweisungZSBNrData"] = value;
            }
        }

        public static bool HasForm2PassKundeZuweisungZSBNrSessionData(string key)
        {
            return Form2PassKundeZuweisungZSBNrData[key] != null;
        }

        public static Form2PassKundeZuweisungZsbNrData GetForm2PassKundeZuweisungZSBNrSessionData(string key)
        {
            if (HasForm2PassKundeZuweisungZSBNrSessionData(key))
                return (Form2PassKundeZuweisungZsbNrData)Form2PassKundeZuweisungZSBNrData[key];

            return null;
        }
        public static void SetForm2PassKundeZuweisungZSBNrSessionData(Form2PassKundeZuweisungZsbNrData pf, string key)
        {
            if (Form2PassKundeZuweisungZSBNrData[key] != null)
                Form2PassKundeZuweisungZSBNrData[key] = pf;
            else
                Form2PassKundeZuweisungZSBNrData.Add(key, pf);
        }


        public static Hashtable Form2KundeZgRevisionData
        {
            get
            {
                if (Session["Form2KundeZgRevisionData"] == null)
                    Session["Form2KundeZgRevisionData"] = new Hashtable();
                return (Hashtable)Session["Form2KundeZgRevisionData"];
            }
            set
            {
                Session["Form2KundeZgRevisionData"] = value;
            }
        }
        public static Form2KundeZgRevisioNrData GetForm2KundeZgRevisionSessionData(string key)
        {
            if (HasForm2KundeZgRevisionSessionData(key))
                return (Form2KundeZgRevisioNrData)Form2KundeZgRevisionData[key];

            return null;
        }
        public static bool HasForm2KundeZgRevisionSessionData(string key)
        {
            return Form2KundeZgRevisionData[key] != null;
        }
        public static void SetForm2KundeZgRevisionSessionData(Form2KundeZgRevisioNrData pf, string key)
        {
            if (Form2KundeZgRevisionData[key] != null)
                Form2KundeZgRevisionData[key] = pf;
            else
                Form2KundeZgRevisionData.Add(key, pf);
        }

        public static void RemoveForm2KundeZuweisungZSBNrSessionData(string key)
        {
            if (HasForm2KundeZuweisungZSBNrSessionData(key))
                Form2KundeZuweisungZSBNrData.Remove(key);
        }
        public static void RemoveForm2PassKundeZuweisungZSBNrSessionData(string key)
        {
            if (HasForm2PassKundeZuweisungZSBNrSessionData(key))
                Form2PassKundeZuweisungZSBNrData.Remove(key);
        }
        public static void RemoveForm2KundeZgRevisionSessionData(string key)
        {
            if (HasForm2KundeZgRevisionSessionData(key))
                Form2KundeZgRevisionData.Remove(key);
        }
        #endregion
        public static int? PassKundezuweisungZSBNrValueData
        {
            get
            {
                if (Session["PassKundezuweisungZSBNrValueData"] == null)
                    Session["PassKundezuweisungZSBNrValueData"] = (int?)null;
                return (int?)Session["PassKundezuweisungZSBNrValueData"];
            }
            set
            {
                Session["PassKundezuweisungZSBNrValueData"] = value;
            }
        }
        public static int? KundezuweisungZSBNrValueData
        {
            get
            {
                if (Session["KundezuweisungZSBNrValueData"] == null)
                    Session["KundezuweisungZSBNrValueData"] = (int?)null;
                return (int?)Session["KundezuweisungZSBNrValueData"];
            }
            set
            {
                Session["KundezuweisungZSBNrValueData"] = value;
            }
        }
        public static int? PasszuweisungZSBNrValueData
        {
            get
            {
                if (Session["PasszuweisungZSBNrValueData"] == null)
                    Session["PasszuweisungZSBNrValueData"] = (int?)null;
                return (int?)Session["PasszuweisungZSBNrValueData"];
            }
            set
            {
                Session["PasszuweisungZSBNrValueData"] = value;
            }
        }
        
    }
}