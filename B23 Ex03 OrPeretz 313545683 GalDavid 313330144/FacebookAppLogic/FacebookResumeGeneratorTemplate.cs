using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    public abstract class FacebookResumeGeneratorTemplate
    {
        public string GenerateUserResume(FacebookResumeUser o_CurrentUser)
        {
            StringBuilder resumeText = new StringBuilder();
            try
            {
                resumeText.AppendLine(generateUserPersonaInformation(o_CurrentUser));
            }
            catch (Exception)
            {
                goto Introduction;
            }

        Introduction:
            try
            {
                resumeText.AppendLine(generateUserResumeAbout(o_CurrentUser));
            }
            catch (Exception)
            {
                goto WorkExperience;
            }

        WorkExperience:
            try
            {
                resumeText.AppendLine(generateUserWorkExperience(o_CurrentUser));
            }
            catch (Exception)
            {
                goto Educations;
            }

        Educations:
            try
            {
                resumeText.AppendLine(generateUserEducations(o_CurrentUser));
            }
            catch (Exception)
            {
                goto OtherProperties;
            }

        OtherProperties:
            try
            {
                resumeText.AppendLine(generateProxyResumeUserProperties(o_CurrentUser));
            }
            catch (Exception)
            {
                goto Return;
            }

        Return:
            return resumeText.ToString();
        }
        protected abstract string generateUserResumeAbout(FacebookResumeUser i_CurrentUser);
        protected abstract string generateProxyResumeUserProperties(FacebookResumeUser i_CurrentUser);
        protected abstract string generateUserEducations(FacebookResumeUser i_CurrentUser);
        protected abstract string generateUserWorkExperience(FacebookResumeUser i_CurrentUser);
        protected abstract string generateUserPersonaInformation(FacebookResumeUser i_CurrentUser);

    }
}
