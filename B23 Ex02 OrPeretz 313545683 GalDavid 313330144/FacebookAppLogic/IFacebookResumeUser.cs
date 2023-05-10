using System.Collections.Generic;

namespace FacebookAppLogic
{
    public interface IFacebookResumeUser
    {
        string Introduction { get; set; }

        List<string> Achievements { get; }

        List<string> Hobbies { get; }

        List<string> Certifications { get; }

        List<string> References { get; }
    }
}