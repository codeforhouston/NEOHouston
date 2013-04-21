using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NEORepository
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INEORepositoryService
    {
        [OperationContract]
        List<User> ListUsers();

        [OperationContract]
        List<Observation> ListObservations();

        [OperationContract]
        List<Observatory> ListObservatories();

        [OperationContract]
        List<ObservationRelationship> ListObservationRelationships();

        [OperationContract]
        List<NearEarthObject> ListNearEarthObjects();

        [OperationContract]
        public void AddUser(User user);

        [OperationContract]
        public void AddObservation(Observation observation);

        [OperationContract]
        public void AddObservatory(Observatory observatory);

        [OperationContract]
        public void AddObservationRelationship(ObservationRelationship observationRelationship);        

    }

    /// <summary>
    /// This Data Contract represents the User
    /// </summary>
    [DataContract]
    public class User
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public DateTime CreateTime { get; set; }

        [DataMember]
        public DateTime ModTime { get; set; }

        [DataMember]
        public bool ContactPublic { get; set; }

        [DataMember]
        public bool LocationPublic { get; set; }

        [DataMember]
        public bool Notifications { get; set; }

        [DataMember]
        public string ProfileDescription { get; set; }

        [DataMember]
        public string Location { get; set; }

        [DataMember]
        public Security SecurityType { get; set; }
    }

    /// <summary>
    /// This Data Contract represents the security role
    /// </summary>
    [DataContract]
    public class Security
    {
        private string _SecurityType;
        private string error = "_SecurityType has not been set";

        [DataMember]
        enum SecurityTypeEnum { Administrator, User };

        [DataMember]
        public void SetSecurityType(SecurityTypeEnum elem)
        {
            _SecurityType = elem.ToString();
        }

        [DataMember]
        public string GetSecurityType()
        {
            if (_SecurityType != null)
            {
                return _SecurityType;
            }
            else
            {
                return error;
            }
        }  
    }

    [DataContract]
    public class Observation
    {
        private string _notes;
        [DataMember]
        public User GetUser { get; set; }

        [DataMember]
        public string ObservationName { get; set; }

        [DataMember]
        public NearEarthObject nearEarthObject { get; set; }

        [DataMember]
        public DateTime DiscoveryDate { get; set; }

        [DataMember]
        public string RightAscension { get; set; }

        [DataMember]
        public string Declination { get; set; }

        [DataMember]
        public string Visibility { get; set; }

        [DataMember]
        public string AddNotes 
        {
            get
            {
                return _notes;
            }

            set
            {
                _notes += value;
            }
        }

        [DataMember]
        public string EditNotes 
        {
            set 
            {
                _notes = value;
            }
        }

        [DataMember]
        public string ImageURL { get; set; }

    }

    [DataContract]
    public class Observatory
    {
        [DataMember]
        public string ObservatoryCode { get; set; }

        [DataMember]
        public float Longitude { get; set; }

        [DataMember]
        public float Sine { get; set; }

        [DataMember]
        public float Cosine { get; set; }
    }

    [DataContract]
    public class ObservationRelationship
    {
        [DataMember]
        public Observation NEOObservationRelationShipOne { get; set; }

        [DataMember]
        public Observation NEOObervationRelationshipTwo { get; set; }

        [DataMember]
        public int Vote { get; set; }
    }

    [DataContract]
    public class NearEarthObject
    {
        [DataMember]
        public int DesireabilityScore { get;}

        [DataMember]
        public int NumberOfObservations { get; set; }

        [DataMember]
        public int Rank { get; set; }

        [DataMember]
        public Arc NEOArc { get; set; }
    }

    [DataContract]
    public class Arc
    {

    }


}
