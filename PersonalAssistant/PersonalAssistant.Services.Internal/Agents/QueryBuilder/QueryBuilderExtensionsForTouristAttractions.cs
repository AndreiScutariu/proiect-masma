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
            IEnumerable<TouristAttractionServiceInformation> query = new TouristAttractionServiceInformation[0];

            IEnumerable<Func<TouristAttractionServiceInformation, bool>> predicates = SearchPredicates.GetFor(message);

            foreach (Func<TouristAttractionServiceInformation, bool> predicate in predicates)
            {
                query = services.Where(predicate);
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
                if (message.EventDate == null || message.EventDate.Min == null && message.EventDate.Max == null)
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
                return x => message.EventDate.Min >= x.DateStart && message.EventDate.Max <= x.DateEnd;
            }

            private static Func<TouristAttractionServiceInformation, bool> LocationPredicate(INeedTouristAttractionServicesRequest message)
            {
                if (message.Location == null)
                {
                    return x => true;
                }

                return x => x.City == message.Location;
            }
        }
    }
}