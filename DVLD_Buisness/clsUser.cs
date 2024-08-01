﻿using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public  class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID { set; get; }
        public int PersonID { set; get; }
        public clsPerson PersonInfo;
        public string UserName { set; get; }
        public string Password { set; get; }
        public bool IsActive { set; get; }
     
        public clsUser()
        {     
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;
            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, int PersonID, string Username,string Password, bool IsActive)
        {
            this.UserID = UserID; 
            this.PersonID = PersonID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.UserName = Username;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static string ComputeHash(string Password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                Byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static clsUser FindByUserID(int UserID)
        {
            int PersonID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUserID(UserID, ref PersonID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUser(UserID,PersonID,UserName,Password,IsActive);
            else
                return null;
        }
        public static clsUser FindByPersonID(int PersonID)
        {
            int UserID = -1;
            string UserName = "", Password = "";
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByPersonID(PersonID, ref UserID, ref UserName, ref Password, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }
        public static clsUser FindByUsernameAndPassword(string UserName,string Password)
        {
            int UserID = -1, PersonID = -1;
            bool IsActive = false;

            bool IsFound = clsUserData.GetUserInfoByUsernameAndPassword(UserName, ComputeHash(Password), ref UserID, ref PersonID, ref IsActive);

            if (IsFound)
                return new clsUser(UserID, PersonID, UserName, Password, IsActive);
            else
                return null;
        }

        private bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.PersonID, this.UserName, ComputeHash(this.Password), this.IsActive);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID,this.PersonID,this.UserName, ComputeHash(this.Password), this.IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateUser();

            }

            return false;
        }


        public static DataTable GetAllUsers() => clsUserData.GetAllUsers();

        public static bool DeleteUser(int UserID) => clsUserData.DeleteUser(UserID);

        public static bool isUserExist(int UserID) => clsUserData.IsUserExist(UserID);

        public static bool isUserExist(string UserName) => clsUserData.IsUserExist(UserName);

        public static bool isUserExistForPersonID(int PersonID) => clsUserData.IsUserExistForPersonID(PersonID);


    }
}
