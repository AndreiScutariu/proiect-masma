using System;
using System.Collections.Generic;
using System.Linq;
using PersonalAssistant.Services.DataContract.ServiceInformation;
using PersonalAssistant.Services.External.DataContract.Contracts.Requests;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    internal static class QueryBuilderExtensionsForTransports
    {
        //TODO - Refactor this, be more generic
        public static IEnumerable<TransportServiceInformation> GetFor(this IList<TransportServiceInformation> services,
            INeedTransportServicesRequest message)
        {
            IEnumerable<TransportServiceInformation> query = new TransportServiceInformation[0];

            var predicates = SearchPredicates.GetFor(message);

            foreach (var predicate in predicates)
            {
                query = services.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            private static Func<TransportServiceInformation, bool> YourLocationPredicate(
                INeedTransportServicesRequest message)
            {
                if (message.YourLocation == null)
                {
                    return x => true;
                }

                return x => x.YourLocation == message.YourLocation;
            }

            public static IEnumerable<Func<TransportServiceInformation, bool>> GetFor(
                INeedTransportServicesRequest message)
            {
                yield return YourLocationPredicate(message);
            }
        }
    }
}