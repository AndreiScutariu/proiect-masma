using System;
using System.Collections.Generic;
using System.Linq;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    internal static class QueryBuilderExtensionsForTouristAttractions
    {
        public static IEnumerable<TouristAttractionServiceInformation> GetFor(this IList<TouristAttractionServiceInformation> services,
            INeedTouristAttractionServicesRequest message)
        {
            IEnumerable<TouristAttractionServiceInformation> query = new TouristAttractionServiceInformation[0];

            var predicates = SearchPredicates.GetFor(message);

            foreach (var predicate in predicates)
            {
                query = services.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            private static Func<TouristAttractionServiceInformation, bool> ActivityTypePredicate(INeedTouristAttractionServicesRequest message)
            {
                if (message.ActivityType == null)
                {
                    return x => true;
                }

                return x => x.ActivityType == message.ActivityType;
            }

            public static IEnumerable<Func<TouristAttractionServiceInformation, bool>> GetFor(INeedTouristAttractionServicesRequest message)
            {
                yield return ActivityTypePredicate(message);
            }
        }

    }
}
