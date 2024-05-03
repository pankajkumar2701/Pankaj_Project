using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Pankaj_Project.Entities
{
    /// <summary> 
    /// Represents a druglistitems entity with essential details
    /// </summary>
    public class DrugListItems
    {
        /// <summary>
        /// Primary key for the DrugListItems 
        /// </summary>
        [Key]
        public Guid? Id { get; set; }
        /// <summary>
        /// TenantId of the DrugListItems 
        /// </summary>
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Required field Name of the DrugListItems 
        /// </summary>
        [Required]
        public string Name { get; set; }
        /// <summary>
        /// Foreign key referencing the DrugList to which the DrugListItems belongs 
        /// </summary>
        public Guid? DrugListId { get; set; }

        /// <summary>
        /// Navigation property representing the associated DrugList
        /// </summary>
        [ForeignKey("DrugListId")]
        public DrugList? DrugListId_DrugList { get; set; }
        /// <summary>
        /// Foreign key referencing the Medication to which the DrugListItems belongs 
        /// </summary>
        public Guid? MedicationId { get; set; }

        /// <summary>
        /// Navigation property representing the associated Medication
        /// </summary>
        [ForeignKey("MedicationId")]
        public Medication? MedicationId_Medication { get; set; }
    }
}