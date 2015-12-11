using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.OData;
using ODataDemo.DAL;
using ODataDemo.DAL.Model;
using System.Web.Http.Description;
using System.Collections.ObjectModel;

namespace ODataDemo.Controllers
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class LearnerController : ODataController
    {
        private readonly LearnerContext _db = new LearnerContext();

        //public static IQueryable<Learner> GetLearners()
        ////{
        ////    return new List<Learner>()
        ////    {
        ////        new Learner() {person_id = 22, dm_forename = "Ram", gender = "M"},
        ////        new Learner() {person_id = 22, dm_forename = "Shyam", gender = "M"},
        ////        new Learner() {person_id = 22, dm_forename = "Sita", gender = "F"}
        ////    }.AsQueryable();
        ////}

        private bool ProductExists(int key)
        {
            return _db.Learners.Any(p => p.person_id == key);
        }

        /// <summary>
        /// Get all learners
        /// </summary>
        /// <returns></returns>
        /// 
        [EnableQuery]
        public IQueryable<Learner> Get()
        {
            // return GetLearners();
            var not = GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions;

            return _db.Learners.Take(100);
        }

        //public Collection<ApiDescription> Nothing()
        //{
        //    //var controllers = GlobalConfiguration
        //    //                   .Configuration
        //    //                   .Services
        //    //                   .GetApiExplorer()
        //    //                   .ApiDescriptions;

        //    //var apiEx = new ApiExplorer(ControllerContext.Configuration);
        //    //return apiEx.ApiDescriptions;
        //}


        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
            base.Dispose(disposing);
        }

        [EnableQuery]
        public async Task<IHttpActionResult> Post(Learner learner)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _db.Learners.Add(learner);
            await _db.SaveChangesAsync();
            return Created(learner);
        }

    }
}