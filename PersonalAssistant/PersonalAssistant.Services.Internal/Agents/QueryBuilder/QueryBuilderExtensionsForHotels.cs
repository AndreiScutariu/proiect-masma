using System;
using System.Collections.Generic;
using System.Linq;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    //TODO - Refactor this, be more generic
    internal static class QueryBuilderExtensionsForHotels
    {
        public static IEnumerable<HotelServiceInformation> GetFor(this IList<HotelServiceInformation> services,
            INeedHotelServicesRequest message)
        {
            IEnumerable<HotelServiceInformation> query = new HotelServiceInformation[0];

            var predicates = SearchPredicates.GetFor(message);

            foreach (var predicate in predicates)
            {
                query = services.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            private static Func<HotelServiceInformation, bool> NumberOfStarsPredicate(INeedHotelServicesRequest message)
            {
                if (message.NumberOfStars == null)
                {
                    return x => true;
                }

                return x => x.NumberOfStars < message.NumberOfStars.Max && x.NumberOfStars > message.NumberOfStars.Min;
            }

            public static IEnumerable<Func<HotelServiceInformation, bool>> GetFor(INeedHotelServicesRequest message)
            {
                yield return NumberOfStarsPredicate(message);
            }
        }
    }
}