//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Brokers.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class brokers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public brokers()
        {
            this.appointments = new HashSet<appointments>();
        }

        [Display(Name = "Courtier")]
        public int idBroker { get; set; }

        [Display(Name = "Nom de famille")]
        [Required(ErrorMessage = "Votre nom est nécessaire")]
        [MaxLength(50, ErrorMessage = "Ce champ est limité à 50 caractères")]
        public string lastname { get; set; }

        [Display(Name = "Prénom")]
        [Required(ErrorMessage = "Votre prénom est nécessaire")]
        [MaxLength(25, ErrorMessage = "Ce champ est limité à 25 caractères")]
        public string firstname { get; set; }

        [Display(Name = "Adresse e-mail")]
        [Required(ErrorMessage = "Votre adresse mail est nécessaire")]
        [EmailAddress(ErrorMessage = "Le format de l'adresse email est incorrecte")]
        public string mail { get; set; }

        [Display(Name = "Numéro de téléphone")]
        [Required(ErrorMessage = "Votre numéro de téléphone est nécessaire")]
        [Phone(ErrorMessage = "Veuillez rentrer un numéro valide, composé de 10 chiffres")]
        [MaxLength(10, ErrorMessage = "Ce champ est limité à 25 caractères")]
        public string phoneNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<appointments> appointments { get; set; }
    }
}
