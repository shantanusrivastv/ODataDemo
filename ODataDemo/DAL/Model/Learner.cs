using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ODataDemo.DAL.Model
{
    [Table("sims.sims_person")]
    public partial class Learner
    {
        [Key]
        public int person_id { get; set; }

        

        [StringLength(1)]
        public string gender { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? deceased { get; set; }

        [Required]
        [StringLength(60)]
        public string surname { get; set; }

       

        [StringLength(60)]
        public string forename { get; set; }

        [StringLength(60)]
        public string legal_surname { get; set; }

        [StringLength(60)]
        public string chosen_forename { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dob { get; set; }

        public int aggregate_role { get; set; }

        public int? photo_id { get; set; }

        

        [StringLength(11)]
        public string dm_chosen_forename { get; set; }

        [StringLength(11)]
        public string dm_legal_surname { get; set; }

        public Guid external_id { get; set; }

        [StringLength(32)]
        public string honours { get; set; }

        [StringLength(100)]
        public string salutation { get; set; }

        [StringLength(100)]
        public string addressee { get; set; }

        public long? memberships_chksum { get; set; }

        public Guid? sif_ref_id { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] rowversion { get; set; }

        [StringLength(15)]
        public string uid { get; set; }
    }
}
