using MongoDB.Driver;
using EventsCoolFun_ECF_.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventsCoolFun_ECF_.Data;

namespace EventsCoolFun_ECF_.Services
{
    public class EventService
    {
        private readonly IMongoCollection<Participant> _participantCollection;
        private readonly ApplicationDbContext _dbContext;

        public EventService(MongoDbContext mongoDbContext, ApplicationDbContext dbContext)
        {
            _participantCollection = mongoDbContext.Participants;
            _dbContext = dbContext;
        }

        public async Task<Event> GetEventWithParticipantNames(Guid eventId)
        {

            var eventEntity = await _dbContext.Events.FirstOrDefaultAsync(e => e.Id == eventId);

            if (eventEntity == null)
            {
                return null;
            }

           
            var participantIds = eventEntity.ParticipantIds;
            var participants = await _participantCollection
                .Find(p => participantIds.Contains(p.Id))
                .ToListAsync();

            // Ajoute les noms des participants à l'événement
            eventEntity.ParticipantNames = participants.Select(p => p.Name).ToList();

            return eventEntity;
        }
    }
}
