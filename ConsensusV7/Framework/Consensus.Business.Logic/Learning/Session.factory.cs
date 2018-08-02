using System;
using System.Collections.Generic;
using System.Linq;

namespace Consensus.Learning
{
    /// <summary>
    ///     Supports the instantiation of the <see cref="SessionModel" /> object.
    /// </summary>
    public partial class LocalSessionFactory
    {
        public LocalSessionModel CreateFromEvent(String eventId)
        {
            LocalSessionModel session = this.Create();
            LocalEventModel eventModel = this.Provider.Learning.Event.FetchById(eventId);
            if (eventModel != null)
            {
                session.ProductId = eventModel.ProductId;
                session.Name = eventModel.Product.Name;
                session.MaxPlaces = eventModel.MaxPlaces;
                session.MinPlaces = eventModel.MinPlaces;
                session.FreePlaces = eventModel.FreePlaces;
                session.ActionDate = eventModel.StartDate;
                session.EndDate = session.ActionDate.Value.AddDays(eventModel.Product.CourseLen.HasValue ? eventModel.Product.CourseLen.Value : 0);
                session.OrganisationId = eventModel.OrganisationId;
                session.LocationId = eventModel.LocationId;
                session.Address = eventModel.Address.MailString;
                session.SellingCompanyId = eventModel.SellingCompanyId;
                session.SessionXrefActivity.Add(this.Provider.Learning.SessionXref.Create());
                
            }
            return session;
        }
    }
}
