namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

    //TODO - Refactor this, be more generic
    internal static class QueryBuilderExtensionsForHotels
    {
        public static IEnumerable<HotelServiceInformation> GetFor(
            this IList<HotelServiceInformation> services,
            INeedHotelServicesRequest message)
        {
            IEnumerable<HotelServiceInformation> query = new HotelServiceInformation[0];

            IEnumerable<Func<HotelServiceInformation, bool>> predicates = SearchPredicates.GetFor(message);

            foreach (Func<HotelServiceInformation, bool> predicate in predicates)
            {
                query = services.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            public static IEnumerable<Func<HotelServiceInformation, bool>> GetFor(INeedHotelServicesRequest message)
            {
                yield return NumberOfStarsPredicate(message);
            }

            private static Func<HotelServiceInformation, bool> NumberOfStarsPredicate(INeedHotelServicesRequest message)
            {
                if (message.NumberOfStars == null)
                {
                    return x => true;
                }

                return x => x.NumberOfStars <= message.NumberOfStars.Max && x.NumberOfStars >= message.NumberOfStars.Min;
            }
        }
    }
}