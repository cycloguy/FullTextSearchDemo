using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace FullTextSearchDemo.Model
{
    public partial class Shipment
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FromName { get; set; }
        [StringLength(50)]
        public string ToName { get; set; }

        public string Address { get; set; }
    }

}