using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MyFirstBot.Dialogs
{
    [Serializable]
    public class DonationFirstDialog : IDialog<object>
    {
        string name;
        string email;
        string phone;
        string plandetails;
        public DonationFirstDialog(string plan)
        {
            plandetails = plan;
        }

        public async Task StartAsync(IDialogContext context)
        {
            await context.PostAsync("Thanks for Select " + plandetails + " Option , Can I Help for Registrtion ? ");

            context.Wait(MessageReceivedAsync);
        }


        /*
         * Thank you. Your donation will be 100% Tax deductible
         * 
            What's your name?  -- input

            How much would you like to donate?
            10
            30
            50
            100
            More than 100 


            $10 will help us buy food for a 2-3 people for one day
            button- Happy to help  -- no input

            Can you share your email address? We don't spam -- input validate email

            Would you like to subscribe to our email updates on how your donations are helping the people?
            button Yes,NO  -- no input

            Are you interested in being a volunteer for fund raising?
            button Yes,NO  -- no input

            Okay. Thank you for your valuable time

         * */

        public virtual async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> activity)
        {
            var response = await activity;
            if (response.Text.ToLower().Contains("yes"))
            {
                PromptDialog.Text(
                    context: context,
                    resume: ResumeGetName,
                    prompt: "Please share your good name",
                    retry: "Sorry, I didn't understand that. Please try again."
                );
            }
            else
            {
                context.Done(this);
            }

        }

        public virtual async Task ResumeGetName(IDialogContext context, IAwaitable<string> Username)
        {
            string response = await Username;
            name = response; ;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetEmail,
                prompt: "Please share your Email ID",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }

        public virtual async Task ResumeGetEmail(IDialogContext context, IAwaitable<string> UserEmail)
        {
            string response = await UserEmail;
            email = response; ;

            PromptDialog.Text(
                context: context,
                resume: ResumeGetPhone,
                prompt: "Please share your Mobile Number",
                retry: "Sorry, I didn't understand that. Please try again."
            );
        }
        public virtual async Task ResumeGetPhone(IDialogContext context, IAwaitable<string> mobile)
        {
            string response = await mobile;
            phone = response;

            await context.PostAsync(String.Format("Hello {0} ,Congratulation :) Name = {0} Email = {1} Mobile Number {2} . You will get Confirmation email and SMS", name, email, phone));

            context.Done(this);
        }
    }
}