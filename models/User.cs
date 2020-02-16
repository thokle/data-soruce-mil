using System;
using System.Net.Sockets;

namespace data_soruce_mil.models
{
    public class User
    {
        
        private string _firstname;
        private string _lastname;
        private string _username;
        private long _longitude;
        private long lattiude;
        private string _zipcode;
        private int _intentionArea;
        private DateTime _createdDate;
        private string _city;    
        
        
        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public long Longitude
        {
            get => _longitude;
            set => _longitude = value;
        }

        public long Lattiude
        {
            get => lattiude;
            set => lattiude = value;
        }

        public string Zipcode
        {
            get => _zipcode;
            set => _zipcode = value;
        }

        public int IntentionArea
        {
            get => _intentionArea;
            set => _intentionArea = value;
        }

        public DateTime CreatedDate
        {
            get => _createdDate;
            set => _createdDate = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

       
        
        
        
    }
}