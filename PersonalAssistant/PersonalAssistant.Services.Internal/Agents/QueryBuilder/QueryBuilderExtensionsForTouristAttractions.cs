using PersonalAssistant.Services.External.Messages;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    internal static class QueryBuilderExtensionsForTouristAttractions
    {
        public static IEnumerable<TouristAttractionServiceInformation> GetFor(
            this IList<TouristAttractionServiceInformation> services,
            INeedTouristAttractionServicesRequest message)
        {
            IEnumerable<TouristAttractionServiceInformation> query = services;

            IEnumerable<Func<TouristAttractionServiceInformation, bool>> predicates = SearchPredicates.GetFor(message);

            foreach (Func<TouristAttractionServiceInformation, bool> predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            public static IEnumerable<Func<TouristAttractionServiceInformation, bool>> GetFor(
                INeedTouristAttractionServicesRequest message)
            {
                yield return ActivityTypePredicate(message);
                yield return ActivityDatePredicate(message);
                yield return LocationPredicate(message);
                yield return ActivityPricePredicate(message);
            }

            private static Func<TouristAttractionServiceInformation, bool> ActivityTypePredicate(
                INeedTouristAttractionServicesRequest message)
            {
                if (!message.ActivityTypes.Any())
                {
                    return x => true;
                }

                return x => message.ActivityTypes.ToList().Contains(x.ActivityType);
            }

            private static Func<TouristAttractionServiceInformation, bool> ActivityDatePredicate(INeedTouristAttractionServicesRequest message)
            {
                if (message.EventDate.IsNull())
                {
                    return x => true;
                }
                else if (message.EventDate.Min == null && message.EventDate.Max != null)
                {
                    return x => message.EventDate.Max >= x.DateStart && message.EventDate.Max <= x.DateEnd;
                }
                else if (message.EventDate.Min != null && message.EventDate.Max == null)
                {
                    return x => message.EventDate.Min >= x.DateStart && message.EventDate.Min <= x.DateEnd;
                }
                return x => message.EventDate.Min <= x.DateStart && message.EventDate.Max >= x.DateEnd;
            }

            private static Func<TouristAttractionServiceInformation, bool> LocationPredicate(INeedTouristAttractionServicesRequest message)
            {
                if (String.IsNullOrEmpty(message.Location))
                {
                    return x => true;
                }

                return x => x.City == message.Location;
            }

            private static Func<TouristAttractionServiceInformation, bool> ActivityPricePredicate(INeedTouristAttractionServicesRequest message)
            {
                if (message.TouristAttractionsPrice.IsNull())
                {
                    return x => true;
                }
                else if (message.TouristAttractionsPrice.Min == null && message.TouristAttractionsPrice.Max != null)
                {
                    return x => message.TouristAttractionsPrice.Max >= x.Price;
                }
                else if (message.TouristAttractionsPrice.Min != null && message.TouristAttractionsPrice.Max == null)
                {
                    return x => message.TouristAttractionsPrice.Min <= x.Price;
                }
                return x => x.Price <= message.TouristAttractionsPrice.Max && x.Price >= message.TouristAttractionsPrice.Min;
            }
        }
    }
}