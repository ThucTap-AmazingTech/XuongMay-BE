﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using XuongMay_BE.Core.Base;

namespace XuongMay_BE.Contract.Repositories.Entities
{
    public class Order : BaseModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
            Tasks = new HashSet<Task>();
        }

        public decimal? Total_amount { get; set; }

        [Required]
        public string Note { get; set; }

        [Required]
        [StringLength(450)]
        public string CustomerId { get; set; }

        [StringLength(450)]
        public string UserId { get; set; }

        [JsonIgnore]
        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
      

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
