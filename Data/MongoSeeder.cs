using EventsCoolFun_ECF_.Models;
using MongoDB.Driver;

namespace EventsCoolFun_ECF_.Data
{
    public class MongoSeeder
    {
        public class MongoDbSeeder
        {
            private readonly IMongoCollection<Participant> _participantCollection;

            public MongoDbSeeder(MongoDbContext mongoDbContext)
            {
                _participantCollection = mongoDbContext.Participants;
            }

            public void Seed()
            {
              
                var participants = new[]
                {
              new Participant { Id = Guid.NewGuid(), Name = "Tom Hanks", Email = "tom.hanks@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Meryl Streep", Email = "meryl.streep@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Leonardo DiCaprio", Email = "leo.dicaprio@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Dwayne Johnson", Email = "dwayne.johnson@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Scarlett Johansson", Email = "scarlett.johansson@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Will Smith", Email = "will.smith@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Emma Watson", Email = "emma.watson@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Chris Hemsworth", Email = "chris.hemsworth@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Johnny Depp", Email = "johnny.depp@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Angelina Jolie", Email = "angelina.jolie@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Brad Pitt", Email = "brad.pitt@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Taylor Swift", Email = "taylor.swift@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Ariana Grande", Email = "ariana.grande@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Beyoncé", Email = "beyonce@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Kim Kardashian", Email = "kim.kardashian@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Kanye West", Email = "kanye.west@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Oprah Winfrey", Email = "oprah.winfrey@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Barack Obama", Email = "barack.obama@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Taylor Swift", Email = "taylor.swift@gmail.com" },
            new Participant { Id = Guid.NewGuid(), Name = "Rihanna", Email = "rihanna@gmail.com" }
            };

                _participantCollection.InsertMany(participants);
            }
        }
    }
}
