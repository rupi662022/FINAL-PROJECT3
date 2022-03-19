﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FINAL_PROJECT3.Models.DAL;

namespace FINAL_PROJECT3.Models
{
    public class GatePass
    {
        int gateId;
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
        DateTime createdDate;


        public GatePass(){ }

        public GatePass(int gateId, string containerNum, string containerType, string transportCompany, string importer, string customsBroker, string shippingCompanyAndLine, string storageCertificate, string caseNumber, string note, string officeNote, string goToRepair, string returnFromRepair, string isActive, string userEmail, DateTime createdDate)
        {
            this.gateId = gateId;
            this.containerNum = containerNum;
            this.containerType = containerType;
            this.transportCompany = transportCompany;
            this.importer = importer;
            this.customsBroker = customsBroker;
            this.shippingCompanyAndLine = shippingCompanyAndLine;
            this.storageCertificate = storageCertificate;
            this.caseNumber = caseNumber;
            this.note = note;
            this.officeNote = officeNote;
            this.goToRepair = goToRepair;
            this.returnFromRepair = returnFromRepair;
            this.isActive = isActive;
            this.userEmail = userEmail;
            this.createdDate = createdDate;
<<<<<<< Updated upstream
        }

        public int GateId { get => gateId; set => gateId = value; }
=======
        }

<<<<<<< HEAD
        public GatePass(int id, string containerNum, string containerType, string transportCompany, string importer, string customsBroker, string shippingCompanyAndLine, string storageCertificate, string caseNumber, string note, string officeNote, string goToRepair, string returnFromRepair, string isActive, string userEmail, DateTime createdDate)
        {
            this.id = id;
            this.containerNum = containerNum;
            this.containerType = containerType;
            this.transportCompany = transportCompany;
            this.importer = importer;
            this.customsBroker = customsBroker;
            this.shippingCompanyAndLine = shippingCompanyAndLine;
            this.storageCertificate = storageCertificate;
            this.caseNumber = caseNumber;
            this.note = note;
            this.officeNote = officeNote;
            this.goToRepair = goToRepair;
            this.returnFromRepair = returnFromRepair;
            this.isActive = isActive;
            this.userEmail = userEmail;
            this.createdDate = createdDate;
        }

        public int Id { get => id; set => id = value; }
=======
        public int GateId { get => gateId; set => gateId = value; }
>>>>>>> 99bdca16236b7e94e40ee57a8062f8495901b1da
>>>>>>> Stashed changes
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
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }

<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        public int Insert()
        {
            DataServices ds = new DataServices();
            return ds.Insert(this);
        }
=======
>>>>>>> Stashed changes








<<<<<<< Updated upstream
=======
>>>>>>> 99bdca16236b7e94e40ee57a8062f8495901b1da
>>>>>>> Stashed changes
    }
}