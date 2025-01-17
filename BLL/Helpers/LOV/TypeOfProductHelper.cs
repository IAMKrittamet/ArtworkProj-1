﻿using BLL.Services;
using DAL;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Helpers
{
    public class TypeOfProductHelper
    {
        public static SAP_M_TYPE_OF_PRODUCT_RESULT GetTypeOfProduct(SAP_M_TYPE_OF_PRODUCT_REQUEST param)
        {
            SAP_M_TYPE_OF_PRODUCT_RESULT Results = new SAP_M_TYPE_OF_PRODUCT_RESULT();
            try
            {
                using (var context = new ARTWORKEntities())
                {
                    using (CNService.IsolationLevel(context))
                    {
                        if (param == null || param.data == null)
                        {
                            SAP_M_TYPE_OF_PRODUCT TypeProduct = new SAP_M_TYPE_OF_PRODUCT();
                            TypeProduct.IS_ACTIVE = "X";
                            Results.data = MapperServices.SAP_M_TYPE_OF_PRODUCT(SAP_M_TYPE_OF_PRODUCT_SERVICE.GetByItem(MapperServices.SAP_M_TYPE_OF_PRODUCT(TypeProduct), context));

                        }
                        else
                        {
                            param.data.IS_ACTIVE = "X";
                            Results.data = MapperServices.SAP_M_TYPE_OF_PRODUCT(SAP_M_TYPE_OF_PRODUCT_SERVICE.GetByItem(MapperServices.SAP_M_TYPE_OF_PRODUCT(param.data), context));
                        }

                        if (Results.data.Count > 0)
                        {
                            for (int i = 0; i < Results.data.Count; i++)
                            {
                                Results.data[i].ID = Results.data[i].TYPE_OF_PRODUCT_ID;
                                Results.data[i].DISPLAY_TXT = Results.data[i].TYPE_OF_PRODUCT + ":" + Results.data[i].DESCRIPTION;
                            }

                            if (param != null && param.data != null && !String.IsNullOrEmpty(param.data.DISPLAY_TXT))
                            {
                                Results.data = (from u1 in Results.data
                                                where (u1.DISPLAY_TXT.ToLower().Contains(param.data.DISPLAY_TXT.ToLower()))
                                                select u1).ToList();
                            }

                            Results.data = Results.data.OrderBy(x => x.DISPLAY_TXT).ToList();
                        }
                    }
                }
                Results.status = "S";
            }
            catch (Exception ex)
            {
                Results.status = "E";
                Results.msg = CNService.GetErrorMessage(ex);
            }

            return Results;
        }
    }
}
