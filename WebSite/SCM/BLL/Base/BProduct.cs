﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SCM.Common;
using SCM.Model;
using SCM.DALFactory;
using SCM.IDAL;
using System.Data;

namespace SCM.Bll
{
    public partial class BProduct
    {
        private readonly IProduct dal = DataAccess.CreateProductManage();
        public BProduct()
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
        public int Add(BaseProductTable model)
        {
           return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(BaseProductTable model)
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

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SCM.Model.BaseProductTable GetModel(string CODE)
        {

            return dal.GetModel(CODE);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中
        /// </summary>
        public SCM.Model.BaseProductTable GetModelByCache(string CODE)
        {

            string CacheKey = "BASE_PRODUCTModel-" + CODE;
            object objModel = SCM.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(CODE);
                    if (objModel != null)
                    {
                        int ModelCache = SCM.Common.ConfigHelper.GetConfigInt("ModelCache");
                        SCM.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (SCM.Model.BaseProductTable)objModel;
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            return dal.GetRecordCount(strWhere);
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
        }


        #endregion  Method
    }
}
