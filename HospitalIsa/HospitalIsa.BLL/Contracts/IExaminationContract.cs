﻿using HospitalIsa.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HospitalIsa.BLL.Contracts
{
    public interface IExaminationContract
    {
        Task<object> GetClinicByTypeDateExamination(string type, DateTime dateTime);
        Task<object> GetFreeExaminationAndDoctorByClinic(Guid idClinic, string type, DateTime dateTime);
        Task<bool> AddExamination(ExaminationPOCO examinationPOCO);
        Task<object> GetExaminationRequests(Guid clinicId);
        Task<bool> AcceptExaminationRequest(RoomExaminationPOCO roomExaminationPOCO );
        Task<object> GetOccupancyForRoomByDate(RoomDatePOCO roomDatePOCO);
        Task<object> FirstAvailableByDate(RoomDatePOCO roomDatePOCO);
        Task<object> GetExaminationPriceByTypeAndClinic(Guid clinicId, string type);
        Task<string> AddPreDefinitionExamination(ExaminationPOCO examinationPOCO);
        Task<bool> AcceptPreDefinitionExamination(ExaminationPOCO examinationPOCO);
        Task<object> GetPreDefinitionExamination();
        Task<object> GetExaminationById(Guid examinationId);
        Task<object> GetAllExaminationsByUserId(Guid userId);
        Task<bool> AddReview(ReviewPOCO reviewPOCO);
        Task<object> CheckIfAlreadyReviewed(Guid patientId, Guid reviewedId);
        Task<object> GetAllFinishedExaminationsByClinic(Guid clinicId);
    }
}
