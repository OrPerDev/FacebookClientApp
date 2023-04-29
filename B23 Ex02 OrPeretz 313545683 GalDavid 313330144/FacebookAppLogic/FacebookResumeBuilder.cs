using System;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public static class FacebookResumeBuilder
    {
        public static string GenerateUserResume(User o_CurrentUser)
        {
            StringBuilder resumeText = new StringBuilder();
            try
            {
                resumeText.AppendLine(generateUserPersonaInformation(o_CurrentUser));
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
                goto Return;
            }

        Return:
            return resumeText.ToString();
        }

        private static string generateUserPersonaInformation(User i_CurrentUser)
        {
            StringBuilder personalText = new StringBuilder();
            personalText.AppendLine($"{new string(' ', 20)}{i_CurrentUser.Name}");
            personalText.AppendLine($"Email - {i_CurrentUser.Email}");
            personalText.AppendLine($"Location - {i_CurrentUser.Location.ToString()}");
            personalText.AppendLine($"Birthday - {i_CurrentUser.Birthday}");
            return personalText.ToString();
        }

        private static string generateUserWorkExperience(User i_CurrentUser)
        {
            StringBuilder workExperienceText = new StringBuilder();
            WorkExperience[] workExperiences = i_CurrentUser.WorkExperiences;
            workExperienceText.AppendLine($"{new string('-', 20)}Work Experience{new string('-', 20)}");
            if (workExperiences == null)
            {
                workExperienceText.AppendLine("No work experience to be displayed");
            }
            else
            {
                foreach (WorkExperience experience in workExperiences)
                {
                    workExperienceText.AppendLine($"• Job Title - {experience.Position.Name}");
                    workExperienceText.AppendLine($"• Employer - {experience.Employer.Name}, {experience.StartDate.ToString()} - {experience.EndDate.ToString()}");
                    workExperienceText.AppendLine($"• Description - {experience.Description}");
                    workExperienceText.AppendLine($"{new string('-', 50)}");
                }
            }

            return workExperienceText.ToString();
        }

        private static string generateUserEducations(User i_CurrentUser)
        {
            StringBuilder educationText = new StringBuilder();
            Education[] educations = i_CurrentUser.Educations;
            educationText.AppendLine($"{new string('-', 26)}Education{new string('-', 26)}");
            if (educations == null)
            {
                educationText.AppendLine("No Education to be displayed");
            }
            else
            {
                foreach (Education education in i_CurrentUser.Educations)
                {
                    educationText.AppendLine($"• Degree - {education.Degree}");
                    educationText.AppendLine($"• Academic institution - {education.School}, {education.Year.Name}");
                    educationText.AppendLine($"• Type - {education.Type}");
                    educationText.AppendLine($"• Concetration -");
                    foreach (Page concetration in education.Concentration)
                    {
                        educationText.AppendLine($" • {concetration.Name}");
                    }

                    educationText.AppendLine($"{new string('-', 50)}");
                }
            }

            return educationText.ToString();
        }
    }
}
