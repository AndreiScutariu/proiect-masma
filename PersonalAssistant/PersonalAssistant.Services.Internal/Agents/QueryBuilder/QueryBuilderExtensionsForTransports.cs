using PersonalAssistant.Services.External.Messages;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    internal static class QueryBuilderExtensionsForTransports
    {
        public static IEnumerable<TransportServiceInformation> GetFor(
            this IList<TransportServiceInformation> services,
            INeedTransportServicesRequest message)
        {
            IEnumerable<TransportServiceInformation> query = services;

            IEnumerable<Func<TransportServiceInformation, bool>> predicates = SearchPredicates.GetFor(message);

            foreach (Func<TransportServiceInformation, bool> predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            public static IEnumerable<Func<TransportServiceInformation, bool>> GetFor(
                INeedTransportServicesRequest message)
            {
                yield return TransportTypePredicate(message);
                yield return YourCountryPredicate(message);
                yield return YourCityPredicate(message);
                yield return ActivityPricePredicate(message);
            }

            private static Func<TransportServiceInformation, bool> TransportTypePredicate(
                INeedTransportServicesRequest message)
            {
                if (!message.TransportTypes.Any())
                {
                    return x => true;
                }

                return x => message.TransportTypes.Contains(x.TransportType);
            }

            private static Func<TransportServiceInformation, bool> YourCountryPredicate(
                INeedTransportServicesRequest message)
            {
                if (string.IsNullOrEmpty(message.YourCountry))
                {
                    return x => true;
                }

                return x => x.TransportFromCountry == message.YourCountry;
            }
            
            private static Func<TransportServiceInformation, bool> YourCityPredicate(
                INeedTransportServicesRequest message)
            {
                if (string.IsNullOrEmpty(message.YourCity))
                {
                    return x => true;
                }

                return x => x.TransportFromCity == message.YourCity;
            }

            private static Func<TransportServiceInformation, bool> ActivityPricePredicate(INeedTransportServicesRequest message)
            {
                if (message.TransportPrice.IsNull())
                {
                    return x => true;
                }
                else if (message.TransportPrice.Min == null && message.TransportPrice.Max != null)
                {
                    return x => message.TransportPrice.Max >= x.Price;
                }
                else if (message.TransportPrice.Min != null && message.TransportPrice.Max == null)
                {
                    return x => message.TransportPrice.Min <= x.Price;
                }
                return x => x.Price <= message.TransportPrice.Max && x.Price >= message.TransportPrice.Min;
            }
        }
    }
}