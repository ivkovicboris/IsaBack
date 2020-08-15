﻿using AutoMapper;
using HospitalIsa.API.Models;
using HospitalIsa.BLL.Models;
using HospitalIsa.DAL.Entites;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalIsa.API.Services
{
    public class SetupAutoMapper : Profile
    {
        
        public SetupAutoMapper()
        {
            //relation API <=> BLL
            CreateMap<RegisterModel, RegisterPOCO>();
            CreateMap<RegisterPOCO, RegisterModel>();
            CreateMap<LoginModel, LoginPOCO>();
            CreateMap<LoginPOCO, LoginModel>();
            CreateMap<UserModel, UserPOCO>();
            CreateMap<UserPOCO, UserModel>();
            CreateMap<MailModel, MailPOCO>();
            CreateMap<MailPOCO, MailModel>();
            CreateMap<ClinicModel, ClinicPOCO>();
            CreateMap<ClinicPOCO, ClinicModel>();
            CreateMap<PatientModel, PatientPOCO>();
            CreateMap<PatientPOCO, PatientModel>();
            CreateMap<EmployeeModel, EmployeePOCO>();
            CreateMap<EmployeePOCO, EmployeeModel>();
            CreateMap<RoomModel, RoomPOCO>();
            CreateMap<RoomPOCO, RoomModel>();
            CreateMap<PricelistModel, PricelistPOCO>();
            CreateMap<PricelistPOCO, PricelistModel>();
            CreateMap<ChangePasswordModel, ChangePasswordPOCO>();

            //relation BLL <=> DAL
            CreateMap<RegisterPOCO, User>();
            CreateMap<User, RegisterPOCO>();
            CreateMap<PatientPOCO, Patient>();
            CreateMap<Patient, PatientPOCO>();
            CreateMap<EmployeePOCO, Employee>();
            CreateMap<Employee, EmployeePOCO>();
            CreateMap<ClinicPOCO, Clinic>();
            CreateMap<Clinic, ClinicPOCO>();
            CreateMap<RoomPOCO, Room>();
            CreateMap<Room, RoomPOCO>();
            CreateMap<PricelistPOCO, Pricelist>();
            CreateMap<Pricelist, PricelistPOCO>();

        }
       
    }
}
