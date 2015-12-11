using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.OData.Builder;
using Microsoft.OData.Edm;

namespace ODataDemo.DAL.Model
{
    public class Order
    {
        [Key]
        public Guid OrderId { get; set; }

        public string OrderName { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        [ActionOnDelete(EdmOnDeleteAction.Cascade)]
        public Customer Customer { get; set; }
    }
}