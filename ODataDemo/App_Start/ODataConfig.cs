using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using Microsoft.OData.Edm;
using ODataDemo.DAL.Model;
using SwashbuckleODataSample.Versioning;

namespace ODataDemo
{
    public static class ODataConfig
    {
        public static void Register(HttpConfiguration config)
        {

            // New code:
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Learner>("Learner");
      
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: null,
                model: builder.GetEdmModel());
        }

        private static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Learner>("Learner");
            return builder.GetEdmModel();
        }

    }
}


  
    