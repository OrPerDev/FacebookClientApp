using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    public interface IFacebookResumeUser
    {
        string ResumeIntroduction { get; }
        List<string> Achievements { get; }
        List<string> Hobbies { get; }
        List<string> Certifications { get; }
        List<string> References { get; }
    }
}
