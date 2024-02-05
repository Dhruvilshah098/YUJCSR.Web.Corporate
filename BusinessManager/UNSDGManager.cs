﻿using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Reflection;
using YUJCSR.Web.Corporate.Helper;
using YUJCSR.Web.Corporate.Models;
using YUJCSR.Web.Project.Models;

namespace YUJCSR.Web.Corporate.BusinessManager
{
    public class UNSDGManager
    {
        private string _baseurl;
        private IConfiguration _configuration;
        public UNSDGManager(IConfiguration iConfig)
        {
            _configuration = iConfig;
            _baseurl = _configuration.GetValue<string>("BaseUrl") + "/api/";
        }


        public UNSDGResultModel GetUNSDG()
        {
            try
            {
                UNSDGResultModel model = new UNSDGResultModel();
                string dataResponse = CommonAPIHelper.GetApiData(_baseurl, "unsdg");

                if (!string.IsNullOrEmpty(dataResponse))
                {
                     model = JsonConvert.DeserializeObject<UNSDGResultModel>(dataResponse);

                }
                return model;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
