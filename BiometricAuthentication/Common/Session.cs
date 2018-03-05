using System;

namespace BiometricAuthentication.Business
{
    public class Session
    {
        private const double ExpiryTimeInSeconds = 600; 

        public Session()
        {
            SessionId = Guid.NewGuid();
            Console.WriteLine("New Session ID : " + SessionId);
            SessionStartTime = DateTime.Now;
            Console.WriteLine("Session Start Time : " + SessionStartTime);
            SessionEndTime = DateTime.Now.AddSeconds(ExpiryTimeInSeconds);
            Console.WriteLine("Session End Time : " + SessionEndTime);
            Console.WriteLine("New Session ID, Session Start Time and Expiry Time are configured");
        }
        //
        public Guid SessionId;
        public DateTime SessionStartTime;
        public DateTime SessionEndTime;
        public bool IsExpired => DateTime.Now > SessionEndTime;
    }
}
