﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrderEMS.Models;
using WorkOrderEMS.Models.CommonModels;
using WorkOrderEMS.Models.ServiceModel;

namespace WorkOrderEMS.BusinessLogic.Interfaces
{
    public interface IeFleetFuelingManager
    {
        ServiceResponseModel<string> InserteFleetFueling(eFleetFuelingModelForService objModel);
        VehicleScanModel GeteFleetVehicleById(string QRCodeID, long locationId);
        ServiceResponseModel<VehicleScanModel> GeteFleetVehicleDetailsByID(VehicleScanModel ObjServiceVehicleModel);
        JQGridModel<FuelJQGridList> GetListeFleetFuelingForJQGridDetails(long? locationid, int? pageIndex, int? numberOfRows, string sortColumnName, string sortOrderBy, string textSearch, long? statusType, DateTime FromDate, DateTime ToDate);
        eFleetFuelingModelForService GeteFleetFuelingDetailsById(long fuelID);
    }
}
