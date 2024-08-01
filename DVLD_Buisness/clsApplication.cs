using System;
using System.Data;
using DVLD_DataAccess;


namespace DVLD_Buisness
{
    public   class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public enum enApplicationType { NewDrivingLicense = 1, RenewDrivingLicense = 2, ReplaceLostDrivingLicense=3,
            ReplaceDamagedDrivingLicense=4, ReleaseDetainedDrivingLicsense=5, NewInternationalLicense=6,RetakeTest=7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Completed = 3 };

        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public clsPerson PersonInfo;
        public string ApplicantFullName
        {
            get
            {
                return clsPerson.Find(ApplicantPersonID).FullName;
            }
        }

        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { set; get; } 
        public string StatusText 
        {
            get { 
            
                switch (ApplicationStatus)
                {
                    case enApplicationStatus.New:
                        return "New";
                    case enApplicationStatus.Cancelled:
                        return "Cancelled";
                    case enApplicationStatus.Completed:
                        return "Completed";
                    default:
                        return "Unknown";  
                }
            }   
           
        }
        public DateTime LastStatusDate { set; get; }
        public float PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo;

        public clsApplication()

        {
            this.ApplicationID = -1;
            this.ApplicantPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = -1;
            this.ApplicationStatus = enApplicationStatus.New;
            this.LastStatusDate = DateTime.Now;
            this.PaidFees = 0;
            this.CreatedByUserID = -1;
           
            Mode = enMode.AddNew;

        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
                     enApplicationStatus ApplicationStatus, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
            
        {
            this.ApplicationID = ApplicationID;
            this.ApplicantPersonID = ApplicantPersonID;
            this.PersonInfo = clsPerson.Find(ApplicantPersonID);
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByUserID(CreatedByUserID);
            Mode = enMode.Update;
        }


        public  static clsApplication FindBaseApplication(int ApplicationID)
        {
            int ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.Now, LastStatusDate = DateTime.Now;
            byte ApplicationStatus = 1;
            float PaidFees = 0;

            bool IsFound = clsApplicationData.GetApplicationInfoByID(ApplicationID, ref ApplicantPersonID, ref ApplicationDate,
                                 ref ApplicationTypeID, ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
                return new clsApplication(ApplicationID,  ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                                  (enApplicationStatus) ApplicationStatus,  LastStatusDate, PaidFees, CreatedByUserID);

            else
                return null;
        }

        private bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication(ApplicantPersonID, ApplicationDate,
                           ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        private bool _UpdateApplication()
        {
            return clsApplicationData.UpdateApplication(ApplicationID, ApplicantPersonID, ApplicationDate,
                           ApplicationTypeID, (byte)ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);
           
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateApplication();

            }

            return false;
        }

        
        public bool Cancel()  =>  clsApplicationData.UpdateStatus(ApplicationID, 2);

        public bool SetComplete()  =>  clsApplicationData.UpdateStatus(ApplicationID, 3);

        public  bool Delete()  =>  clsApplicationData.DeleteApplication(this.ApplicationID);

        public static bool IsApplicationExist(int ApplicationID) => clsApplicationData.IsApplicationExist(ApplicationID);

        public static bool DoesPersonHaveActiveApplication(int PersonID,int ApplicationTypeID)
        {
            return clsApplicationData.DoesPersonHaveActiveApplication(PersonID,ApplicationTypeID);
        }

        public  bool DoesPersonHaveActiveApplication( int ApplicationTypeID)
        {
            return DoesPersonHaveActiveApplication(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationID(int PersonID, clsApplication.enApplicationType  ApplicationTypeID)
        {
            return clsApplicationData.GetActiveApplicationID(PersonID,(int) ApplicationTypeID);
        }
       
        public int GetActiveApplicationID(clsApplication.enApplicationType ApplicationTypeID)
        {
            return GetActiveApplicationID(this.ApplicantPersonID, ApplicationTypeID);
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, clsApplication.enApplicationType ApplicationTypeID,int LicenseClassID)
        {
            return clsApplicationData.GetActiveApplicationIDForLicenseClass(PersonID, (int)ApplicationTypeID,LicenseClassID );
        }

    }
}
