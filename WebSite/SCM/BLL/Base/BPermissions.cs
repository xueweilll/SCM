﻿using System;
using System.Data;
using System.Collections.Generic;
using SCM.Common;
using SCM.Model;
using SCM.DALFactory;
using SCM.IDAL;
namespace SCM.Bll
{
	/// <summary>
	/// Base_Permissions
	/// </summary>
	public partial class BPermissions
	{
        private readonly IBasePermissions dal = DataAccess.CreatePermissionsManage();
		public BPermissions()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(SCM.Model.BasePermissionsTable model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SCM.Model.BasePermissionsTable model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SCM.Model.BasePermissionsTable GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SCM.Model.BasePermissionsTable GetModelByCache(int ID)
		{
			
			string CacheKey = "Base_PermissionsModel-" + ID;
			object objModel = SCM.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(ID);
					if (objModel != null)
					{
						int ModelCache = SCM.Common.ConfigHelper.GetConfigInt("ModelCache");
						SCM.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SCM.Model.BasePermissionsTable)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SCM.Model.BasePermissionsTable> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SCM.Model.BasePermissionsTable> DataTableToList(DataTable dt)
		{
			List<SCM.Model.BasePermissionsTable> modelList = new List<SCM.Model.BasePermissionsTable>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SCM.Model.BasePermissionsTable model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new SCM.Model.BasePermissionsTable();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["DESCRIPTION"]!=null && dt.Rows[n]["DESCRIPTION"].ToString()!="")
					{
					model.DESCRIPTION=dt.Rows[n]["DESCRIPTION"].ToString();
					}
					if(dt.Rows[n]["CATEGORY_ID"]!=null && dt.Rows[n]["CATEGORY_ID"].ToString()!="")
					{
						model.CATEGORY_ID=int.Parse(dt.Rows[n]["CATEGORY_ID"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
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
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

