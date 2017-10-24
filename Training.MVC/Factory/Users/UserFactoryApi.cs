﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Training.MVC.Factory.Users
{
    public class UserFactoryApi : IUserFactoryApi
    {
        #region Const

        private const string _API_PATH_USER = "/api/User/";
        private const string _API_RESOURCE_GetUserFirstName = "GetUserFirstName";

        #endregion

        #region Declaration

        private readonly IFactoryApi _factoryApi;
        
        #endregion

        public UserFactoryApi()
        {
            this._factoryApi = new FactoryApi();
        }

        public virtual string GetUserFirstName()
        {
            return _factoryApi.GetAPISingle<string>(Path.Combine(_API_PATH_USER, _API_RESOURCE_GetUserFirstName));
        }
    }
}