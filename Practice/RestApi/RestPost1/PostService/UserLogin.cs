using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PostService
{
    [DataContract]
    public class UserLogin
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int Id { get; set; }
    }

    public class UsersLayer {
        private static readonly UsersLayer _Instance = new UsersLayer();

        public static UsersLayer Instance { get { return _Instance; } }

        public static List<UserLogin> coll = new List<UserLogin>();

        public int adddata(UserLogin obj)
        {
            coll.Add(obj);
            return coll.Count;



        }
        public List<UserLogin> getdata()
        {

            return coll;
        }
    }
}