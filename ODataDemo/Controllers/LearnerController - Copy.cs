//using System;
//using System.Collections.Generic;
//using System.Collections.ObjectModel;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Web;
//using System.Web.Http;
//using System.Web.Http.Description;
//using System.Web.Mvc;
//using System.Web.OData;
//using ODataDemo.DAL;
//using ODataDemo.DAL.Model;


//namespace ODataDemo.Controllers
//{
//    [EnableQuery]
//    [ApiExplorerSettings(IgnoreApi = false)]
//    public class LearnerController : ApiController
//    {
//        private readonly LearnerContext _db = new LearnerContext();

//        //public static IQueryable<Learner> GetLearners()
//        ////{
//        ////    return new List<Learner>()
//        ////    {
//        ////        new Learner() {person_id = 22, dm_forename = "Ram", gender = "M"},
//        ////        new Learner() {person_id = 22, dm_forename = "Shyam", gender = "M"},
//        ////        new Learner() {person_id = 22, dm_forename = "Sita", gender = "F"}
//        ////    }.AsQueryable();
//        ////}

//        private bool ProductExists(int key)
//        {
//            return _db.Learners.Any(p => p.person_id == key);
//        }

//        /// <summary>
//        /// Get all learners
//        /// </summary>
//        /// <returns>All leanres in the db</returns>

//        [EnableQuery]
//        public IQueryable<Learner> Get()
//        {
//            // return GetLearners();

//            var some = Nothing();

//            return _db.Learners.Take(100);
//        }

//        public System.Net.Http.HttpResponseMessage SomethingElse()
//        {
//            var desc = GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions;
//            return new System.Net.Http.HttpResponseMessage()
//            {
//                Content = new System.Net.Http.StringContent("This is a sample response")
//            };

//        }

//        public Collection<ApiDescription> Nothing()
//        {
//            //var controllers = GlobalConfiguration
//            //                   .Configuration
//            //                   .Services
//            //                   .GetApiExplorer()
//            //                   .ApiDescriptions;
//            var apiEx = new ApiExplorer(ControllerContext.Configuration);
//            return apiEx.ApiDescriptions;
//        }


//        protected override void Dispose(bool disposing)
//        {
//            _db.Dispose();
//            base.Dispose(disposing);
//        }

//        [EnableQuery]
//        public HttpResponseMessage Post(Learner learner)
//        {
//            if (!ModelState.IsValid)
//            {
//                return Request.CreateResponse<Learner>(HttpStatusCode.BadRequest, learner);
//            }
//            _db.Learners.Add(learner);
//            _db.SaveChangesAsync();
//            return Request.CreateResponse<Learner>(HttpStatusCode.Created, learner);
//        }

//    }
//}