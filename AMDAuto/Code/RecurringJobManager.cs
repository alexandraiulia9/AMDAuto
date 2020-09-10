using Hangfire;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMDAuto.Code
{
    public class RecurringJobManager
    {
        public RecurringJobManager()
        {

        }

        public void RegisterJobs()
        {
            RecurringJob.AddOrUpdate(() => InformClientsAboutFinishingAppointments(), Cron.Daily(3), TimeZoneInfo.Utc);
            RecurringJob.AddOrUpdate(() => InformClientsAboutIncomingAppointments(), Cron.Daily(3), TimeZoneInfo.Utc);
            RecurringJob.AddOrUpdate(() => InformEmployeesAboutLowNumberOfCarParts(), Cron.Daily(3), TimeZoneInfo.Utc);
        }

        [AutomaticRetry(Attempts = 3)]
        public async Task InformClientsAboutFinishingAppointments()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("administrator@AMDAuto.com", "AMDAuto Service");
            var tos = new List<EmailAddress>();

            tos.Add(new EmailAddress("dumitrutalexandra411@gmail.com", "Alexandra"));
            tos.Add(new EmailAddress("ionutalex.cobuz@gmail.com", "Ionut"));

            var subject = "Programare incheiata";
            var htmlContent = "<strong>Buna ziua! Va informam ca programarea dumneavoastra pentru operatia 'Inlocuit ulei' a ajuns la final. Puteti ridica masina din service. Va asteptam !</strong>";
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, "", htmlContent, false);
            var response = await client.SendEmailAsync(msg);
        }

        [AutomaticRetry(Attempts = 3)]
        public async Task InformEmployeesAboutLowNumberOfCarParts()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("administrator@AMDAuto.com", "AMDAuto Service");
            var tos = new List<EmailAddress>();

            tos.Add(new EmailAddress("dumitrutalexandra411@gmail.com", "Alexandra"));
            tos.Add(new EmailAddress("ionutalex.cobuz@gmail.com", "Ionut"));

            var subject = "Stoc piese";
            var htmlContent = "<strong>Cantitatea de piese cu denumirea 'Filtru ulei' a scazut sub 5. Va rugam refaceti stocul!</strong>";
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, "", htmlContent, false);
            var response = await client.SendEmailAsync(msg);
        }

        [AutomaticRetry(Attempts = 3)]
        public async Task InformClientsAboutIncomingAppointments()
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("administrator@AMDAuto.com", "AMDAuto Service");
            var tos = new List<EmailAddress>();

            tos.Add(new EmailAddress("dumitrutalexandra411@gmail.com", "Alexandra"));
            tos.Add(new EmailAddress("ionutalex.cobuz@gmail.com", "Ionut"));

            var subject = "Programare AMDAuto Service";
            var htmlContent = "<strong>Buna ziua! Nu uitati de programarea dumneavoastra din data de 15.07.2020. Va asteptam!</strong>";
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tos, subject, "", htmlContent, false);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
