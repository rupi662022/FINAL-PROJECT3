﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FINAL_PROJECT3.Models.DAL

namespace FINAL_PROJECT3.Models
{
    public class GatePass
    {
        int id;
        string containerNum;
        string containerType;
        string transportCompany;
        string importer;
        string customsBroker;
        string shippingCompanyAndLine;
        string storageCertificate;
        string caseNumber;
        string note;
        string officeNote;
        string goToRepair;
        string returnFromRepair;
        string isActive;
        string userEmail;
        string createdDate;


        public GatePass()
        { 
        }

        public int Id { get => id; set => id = value; }
        public string ContainerNum { get => containerNum; set => containerNum = value; }
        public string ContainerType { get => containerType; set => containerType = value; }
        public string TransportCompany { get => transportCompany; set => transportCompany = value; }
        public string Importer { get => importer; set => importer = value; }
        public string CustomsBroker { get => customsBroker; set => customsBroker = value; }
        public string ShippingCompanyAndLine { get => shippingCompanyAndLine; set => shippingCompanyAndLine = value; }
        public string StorageCertificate { get => storageCertificate; set => storageCertificate = value; }
        public string CaseNumber { get => caseNumber; set => caseNumber = value; }
        public string Note { get => note; set => note = value; }
        public string OfficeNote { get => officeNote; set => officeNote = value; }
        public string GoToRepair { get => goToRepair; set => goToRepair = value; }
        public string ReturnFromRepair { get => returnFromRepair; set => returnFromRepair = value; }
        public string IsActive { get => isActive; set => isActive = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }
        public string CreatedDate { get => createdDate; set => createdDate = value; }
    }
}