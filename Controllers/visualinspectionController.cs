﻿using Inspection.Web.DataBase;
using Inspection.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspection.Web.Controllers
{
    public class visualinspectionController : Controller
    {
        // GET: visualinspection
        ITe_INDIAEntities DB = new ITe_INDIAEntities();
        InwardDataModel List = new InwardDataModel();
       
        public ActionResult Index(int? id, string value)
        {
            List<Submodel> _List = new List<Submodel>();
            try
            {
                List = (from model in DB.Final_Inspection_Data.Where(p => p.ID == id)
                        select new InwardDataModel
                        {
                            id = model.ID,
                            InwardTime = model.Inward_Time,		
                            InwardDate = model.Inward_Date,
                            JobNo = model.JobNum,
                            Partno = model.PartNum,
                            Stage = model.Stage,
                            ERev = model.EpiRev,
                            ActualRev = model.ActRev,
                            Qty = model.Qty,
                            Status = model.Status,
                            currentstage = value,
                            _submodel = new Submodel(),
                        }
                        ).FirstOrDefault();


                _List = (from model in DB.Final_Inspection_Process
                        select new Submodel
                        {
                            id = model.ID,
                            inspectiondate = model.Inspection_date,
                            StartTime = model.starttime,
                            EndTime = model.JobNum,
                            InspectedQty = model.Inspection_Qty,
                            InspectionBy = model.done_by,
                        }
                        ).ToList();


                var mainmodel = new mAINPROGRESSModel
                {
                    _INWARD = List,
                    SUBMODEL = _List
                };

                return View(mainmodel);
            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }
        public ActionResult AddData(InwardDataModel _model)
        {
            try
            {
                if (_model != null)
                {
                    Final_Inspection_Process _Inspection_Data = new Final_Inspection_Process();
                    _Inspection_Data.PID = _model.id;
                    _Inspection_Data.MID = 1;
                    _Inspection_Data.Inspection_ID = "";
                    _Inspection_Data.Rework_Id = 0;
                    _Inspection_Data.Inspection_date = _model._submodel.inspectiondate;
                    _Inspection_Data.starttime = _model._submodel.StartTime;
                    _Inspection_Data.endtime = _model._submodel.EndTime;
                    _Inspection_Data.Inspection_Qty = Convert.ToInt32(_model._submodel.InspectedQty);
                    _Inspection_Data.done_by = _model._submodel.User;
                    DB.Final_Inspection_Process.Add(_Inspection_Data);
                    DB.SaveChanges();


                    return PartialView("_SubIndex", List);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
    }
}