using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace EventsCoolFun_ECF_.Models
{
    public class Event
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Le nom est obligatoire")]
        [StringLength(50, ErrorMessage = "Le nom ne peut pas exceder 50 charactères")]
        public string? Name { get; set; }
        public DateTime Date { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
      
        public List<Guid>? ParticipantIds { get; set; } // Liste des GUID des participants

        // Liste des noms des participants, récupérés via MongoDB
        [BsonIgnore]
        public List<string> ParticipantNames { get; set; }
    }
}
