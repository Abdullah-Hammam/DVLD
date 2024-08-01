﻿using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Buisness
{
    public class clsTestType
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2,StreetTest=3 };

        public enTestType ID { set; get; }
        public string Title { set; get; }
        public string Description { set; get; } 
        public float Fees { set; get; }

        public clsTestType()
        {
            this.ID = enTestType.VisionTest;
            this.Title = "";
            this.Description = "";
            this.Fees = 0;

            Mode = enMode.AddNew;
        }

        public clsTestType(enTestType ID, string TestTypeTitel,string Description,float TestTypeFees)
        {
            this.ID = ID;
            this.Title = TestTypeTitel;
            this.Description = Description;
            this.Fees = TestTypeFees;

            Mode = enMode.Update;
        }

        public static clsTestType Find(enTestType TestTypeID)
        {
            string Title = "", Description = "";
            float Fees = 0;

            if (clsTestTypeData.GetTestTypeInfoByID((int) TestTypeID, ref Title,ref Description, ref Fees))

                return new clsTestType(TestTypeID, Title, Description,Fees);
            else
                return null;

        }

        // xxxxx
        private bool _AddNewTestType()
        {
            this.ID =(enTestType) clsTestTypeData.AddNewTestType(this.Title, this.Description, this.Fees);
              
            return (this.Title !="");
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int) this.ID, this.Title, this.Description, this.Fees);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestType())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateTestType();

            }

            return false;
        }

        public static DataTable GetAllTestTypes() => clsTestTypeData.GetAllTestTypes();

    }
}
