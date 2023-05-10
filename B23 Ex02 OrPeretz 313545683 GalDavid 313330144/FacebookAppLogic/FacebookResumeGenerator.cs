using System;
using System.Text;
using System.Reflection;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public static class FacebookResumeGenerator
    {
        public static string GenerateUserResume(FacebookResumeUser o_CurrentUser)
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
                resumeText.AppendLine(generateUserResumeIntro(o_CurrentUser));
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
                resumeText.AppendLine(generateProxyResumeUserPropeties(o_CurrentUser));
            }
            catch (Exception)
            {
                goto Return;
            }

        Return:
            return resumeText.ToString();
        }

        private static string generateUserPersonaInformation(FacebookResumeUser i_CurrentUser)
        {
            StringBuilder personalText = new StringBuilder();
            personalText.AppendLine($"{new string(' ', 20)}{i_CurrentUser.FacebookUser.Name}");
            personalText.AppendLine($"Email - {i_CurrentUser.FacebookUser.Email}");
            personalText.AppendLine($"Location - {i_CurrentUser.FacebookUser.Location.Name}");
            personalText.AppendLine($"Birthday - {i_CurrentUser.FacebookUser.Birthday}");
            return personalText.ToString();
        }

        private static string generateUserWorkExperience(FacebookResumeUser i_CurrentUser)
        {
            StringBuilder workExperienceText = new StringBuilder();
            WorkExperience[] workExperiences = i_CurrentUser.FacebookUser.WorkExperiences;
            workExperienceText.AppendLine($"{new string(' ', 20)}Work Experience");
            workExperienceText.AppendLine(addSectionUnderline());
            if (workExperiences == null)
            {
                workExperienceText.AppendLine("No Work Experience to be displayed.");
            }
            else
            {
                foreach (WorkExperience experience in workExperiences)
                {
                    workExperienceText.AppendLine($"• Job Title - {experience.Position.Name}");
                    workExperienceText.AppendLine($"• Employer - {experience.Employer.Name}, {experience.StartDate.ToString()} - {experience.EndDate.ToString()}");
                    workExperienceText.AppendLine($"• Description - {experience.Description}");
                    workExperienceText.AppendLine($"{new string('-', 100)}");
                }
            }

            return workExperienceText.ToString();
        }

        private static string generateUserEducations(FacebookResumeUser i_CurrentUser)
        {
            StringBuilder educationText = new StringBuilder();
            Education[] educations = i_CurrentUser.FacebookUser.Educations;
            educationText.AppendLine($"{new string(' ', 20)}Education");
            educationText.AppendLine(addSectionUnderline());
            if (educations == null)
            {
                educationText.AppendLine("No Education to be displayed.");
            }
            else
            {
                foreach (Education education in i_CurrentUser.FacebookUser.Educations)
                {
                    educationText.AppendLine($"• Degree - {education.Degree}");
                    educationText.AppendLine($"• Academic institution - {education.School}, {education.Year.Name}");
                    educationText.AppendLine($"• Type - {education.Type}");
                    educationText.AppendLine($"• Concetration -");
                    foreach (Page concetration in education.Concentration)
                    {
                        educationText.AppendLine($" • {concetration.Name}");
                    }

                    educationText.AppendLine($"{new string('-', 100)}");
                }
            }

            return educationText.ToString();
        }

        private static string generateUserResumeIntro(FacebookResumeUser i_CurrentUser)
        {
            StringBuilder introTextBuilder = new StringBuilder();
            introTextBuilder.AppendLine($"{new string(' ', 20)}Introduction");
            introTextBuilder.AppendLine(addSectionUnderline());
            if (string.IsNullOrEmpty(i_CurrentUser.Introduction))
            {
                introTextBuilder.AppendLine("No Introduction to be displayed.");
            }
            else
            {
                introTextBuilder.AppendLine(i_CurrentUser.Introduction);
            }

            introTextBuilder.AppendLine();
            return introTextBuilder.ToString();
        }

        private static string generateProxyResumeUserPropeties(FacebookResumeUser i_CurrentUser)
        {
            StringBuilder propertiesTexts = new StringBuilder();
            foreach (PropertyInfo propertyInfo in i_CurrentUser.GetType().GetProperties())
            {
                if (propertyInfo.PropertyType == typeof(List<string>))
                {
                    propertiesTexts.AppendLine($"{new string(' ', 20)}{propertyInfo.Name}");
                    propertiesTexts.AppendLine(addSectionUnderline());
                    List<string> currentPropertyList = propertyInfo.GetValue(i_CurrentUser) as List<string>;
                    if (currentPropertyList == null || currentPropertyList.Count == 0)
                    {
                        propertiesTexts.AppendLine($"No {propertyInfo.Name} to be displayed.");
                    }
                    else
                    {
                        foreach (string textInPropertyValue in currentPropertyList)
                        {
                            propertiesTexts.AppendLine($"- {textInPropertyValue}");
                        }
                    }

                    propertiesTexts.AppendLine();
                }
            }

            return propertiesTexts.ToString();
        }

        private static string addSectionUnderline()
        {
            return new string('-', 100);
        }
    }
}
