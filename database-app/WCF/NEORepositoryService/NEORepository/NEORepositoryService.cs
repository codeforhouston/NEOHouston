using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NEORepository
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class NEORepositoryService : INEORepositoryService
    {

        public List<User> ListUsers()
        {
            throw new NotImplementedException();
        }

        public List<Observation> ListObservations()
        {
            throw new NotImplementedException();
        }

        public List<Observatory> ListObservatories()
        {
            throw new NotImplementedException();
        }

        public List<ObservationRelationship> ListObservationRelationships()
        {
            throw new NotImplementedException();
        }

        public List<NearEarthObject> ListNearEarthObjects()
        {
            throw new NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public void AddObservation(Observation observation)
        {
            throw new NotImplementedException();
        }

        public void AddObservatory(Observatory observatory)
        {
            throw new NotImplementedException();
        }

        public void AddObservationRelationship(ObservationRelationship observationRelationship)
        {
            throw new NotImplementedException();
        }
    }
}
