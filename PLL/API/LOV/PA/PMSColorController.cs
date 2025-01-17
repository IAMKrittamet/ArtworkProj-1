﻿using BLL.Services;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PLL.API.LOV.PA
{
    public class PMSColorController : ApiController
    {
        [Route("api/lov/pa/pms")]
        public SAP_M_CHARACTERISTIC_RESULT Get([FromUri]SAP_M_CHARACTERISTIC_REQUEST param)
        {
            SAP_M_CHARACTERISTIC_RESULT Results = new SAP_M_CHARACTERISTIC_RESULT();
            try
            {
                using (var context = new ARTWORKEntities())
                {
                    using (CNService.IsolationLevel(context))
                    {
                        if (param == null || param.data == null)
                        {
                            Results.status = "S";
                            Results.data = new List<SAP_M_CHARACTERISTIC_2>();
                            return Results;
                        }

                        if (param == null)
                        {
                            param = new SAP_M_CHARACTERISTIC_REQUEST();
                        }
                        if (param.data == null)
                        {
                            param.data = new SAP_M_CHARACTERISTIC_2();
                        }
                        var code = Helper.GetMaterialCode(param.data.MATERIAL_GROUP_ID);
                        switch (code)
                        {
                            case "C":
                                param.data.NAME = "ZPKG_SEC_CARD_PMS_COLOUR";
                                break;
                            case "D":
                                param.data.NAME = "ZPKG_SEC_DISP_PMS_COLOUR";
                                break;
                            case "R":
                                param.data.NAME = "ZPKG_SEC_INN_NO_PMS_COLOUR";
                                break;
                            case "N":
                                param.data.NAME = "ZPKG_SEC_INNER_PMS_COLOUR";
                                break;
                            case "P":
                                param.data.NAME = "ZPKG_SEC_INST_PMS_COLOUR";
                                break;
                            case "K":
                                param.data.NAME = "ZPKG_SEC_LABE_PMS_COLOUR";
                                break;
                            case "L":
                                param.data.NAME = "ZPKG_SEC_LEA_PMS_COLOUR";
                                break;
                            case "H":
                                param.data.NAME = "ZPKG_SEC_SLEV_PMS_COLOUR";
                                break;
                            case "J":
                                param.data.NAME = "ZPKG_SEC_STKC_PMS_COLOUR";
                                break;
                            case "G":
                                param.data.NAME = "ZPKG_SEC_TRAY_PMS_COLOUR";
                                break;
                            case "F":
                                param.data.NAME = "ZPKG_SEC_CAR_PMS_COLOUR";
                                break;
                            case "M":
                                param.data.NAME = "ZPKG_SEC_PLAST_PMS_COLOUR";
                                break;
                            default:
                                param.data.NAME = "XXXXXXXXXXXXXXXXXXXXXXX";
                                break;

                        }
                        param.data.DESCRIPTION = param.data.DISPLAY_TXT;
                        param.data.IS_ACTIVE = "X";
                        Results.data = MapperServices.SAP_M_CHARACTERISTIC(SAP_M_CHARACTERISTIC_SERVICE.GetByItemContain(MapperServices.SAP_M_CHARACTERISTIC(param.data), context));

                        Results.status = "S";

                        if (Results.data.Count > 0)
                        {
                            Results.data = Results.data.OrderBy(x => x.DESCRIPTION).ToList();

                            for (int i = 0; i < Results.data.Count; i++)
                            {
                                Results.data[i].ID = Results.data[i].CHARACTERISTIC_ID;
                                Results.data[i].DISPLAY_TXT = Results.data[i].DESCRIPTION;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Results.status = "E";
                Results.msg = CNService.GetErrorMessage(ex);
            }

            return Results;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}