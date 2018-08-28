using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace CBT.OnlineTutor
{
    public static class JsonConversionHelper
    {
        public static T ConvertFromJson<T>(string jsonString)
        {
            try
            {
                if (string.IsNullOrEmpty(jsonString))
                {
                    return default(T);
                }

                var data = JsonConvert.DeserializeObject<T>(
                    jsonString,
                    new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });
                return data;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static string ConvertToJson<T>(T model)
        {
            string data = JsonConvert.SerializeObject(
                model,
                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() });

            return data;
        }

        //public static IHtmlString ToJson(this HtmlHelper helper, object model)
        //{
        //    return
        //        helper.Raw(
        //            JsonConvert.SerializeObject(
        //                model,
        //                new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }));
        //}
    }
}
