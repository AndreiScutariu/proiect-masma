namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

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
        }
    }
}