﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using POS.Common;
using POS.Model;
using POS.DALFactory;
using POS.IDAL;
using System.Data;

namespace POS.Bll
{
    public partial class BSalesPromotion
    {
        private readonly ISalesPromotion dal = DataAccess.CreateSalesPromotionManage();
        public BSalesPromotion()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string CODE)
        {
            return dal.Exists(CODE);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BaseSalesPromotionTable model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BaseSalesPromotionTable model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string CODE)
        {

            return dal.Delete(CODE);
        }

        public int GetPromotionCount(string strWhere)
        {
            return dal.GetPromotionCount(strWhere);
        }

        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }

        public POS.Model.BaseSalesPromotionTable GetModel(string CODE)
        {
            return dal.GetModel(CODE);
        }

        public  bool isDelete(string CODE) 
        {
            return dal.isDelete(CODE);
        }

        #endregion  Method
    }
}
