using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Pankaj_Project.Entities
{
    /// <summary> 
    /// Represents a pricelist entity with essential details
    /// </summary>
    public class PriceList
    {
        /// <summary>
        /// TenantId of the PriceList 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Primary key for the PriceList 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// PriceListBaseType of the PriceList 
        /// </summary>
        public int? PriceListBaseType { get; set; }
        /// <summary>
        /// PricelistType of the PriceList 
        /// </summary>
        public int? PricelistType { get; set; }

        /// <summary>
        /// Required field Name of the PriceList 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// PricelistStatus of the PriceList 
        /// </summary>
        public int? PricelistStatus { get; set; }
        /// <summary>
        /// Notes of the PriceList 
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// StartDate of the PriceList 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// EndDate of the PriceList 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// CreatedBy of the PriceList 
        /// </summary>
        public Guid? CreatedBy { get; set; }

        /// <summary>
        /// CreatedOn of the PriceList 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the PriceList 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// UpdatedOn of the PriceList 
        /// </summary>
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// Enable of the PriceList 
        /// </summary>
        public bool? Enable { get; set; }
    }
}