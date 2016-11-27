using System.ComponentModel.Design;
using PersonalAssistant.Services.External.Messages;

namespace PersonalAssistant.Services.Internal.Agents.QueryBuilder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using PersonalAssistant.Services.DataContract.ServiceInformation;
    using PersonalAssistant.Services.External.Messages.Contracts.Requests;

    //TODO - Refactor this, be more generic
    internal static class QueryBuilderExtensionsForHotels
    {
        public static IEnumerable<HotelServiceInformation> GetFor(
            this IList<HotelServiceInformation> services,
            INeedHotelServicesRequest message)
        {
            IEnumerable<HotelServiceInformation> query = services;

            IEnumerable<Func<HotelServiceInformation, bool>> predicates = SearchPredicates.GetFor(message);

            foreach (Func<HotelServiceInformation, bool> predicate in predicates)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        private static class SearchPredicates
        {
            public static IEnumerable<Func<HotelServiceInformation, bool>> GetFor(INeedHotelServicesRequest message)
            {
                yield return NumberOfStarsPredicate(message);
                yield return CountryPredicate(message);
                yield return CityPredicate(message);
                yield return IntervalOfTimePredicate(message);
                yield return NumberOfRoomsPredicate(message);
                yield return NumberOfPlpPerRoomPredicate(message);
                yield return HotelPricePredicate(message);
            }

            private static Func<HotelServiceInformation, bool> NumberOfStarsPredicate(INeedHotelServicesRequest message)
            {
                if (message.NumberOfStars.IsNull())
                {
                    return x => true;
                }
                else if (message.NumberOfStars.Min == null && message.NumberOfStars.Max != null)
                {
                    return x => message.NumberOfStars.Max >= x.NumberOfStars;
                }
                else if (message.NumberOfStars.Min != null && message.NumberOfStars.Max == null)
                {
                    return x => message.NumberOfStars.Min <= x.NumberOfStars;
                }
                return x => x.NumberOfStars <= message.NumberOfStars.Max && x.NumberOfStars >= message.NumberOfStars.Min;
            }

            private static Func<HotelServiceInformation, bool> CountryPredicate(INeedHotelServicesRequest message)
            {
                if (String.IsNullOrEmpty(message.HotelCountry))
                {
                    return x => true;
                }

                return x => x.Country == message.HotelCountry;
            }

            private static Func<HotelServiceInformation, bool> CityPredicate(INeedHotelServicesRequest message)
            {
                if (String.IsNullOrEmpty(message.Location))
                {
                    return x => true;
                }

                return x => x.City == message.Location;
            }

            private static Func<HotelServiceInformation, bool> IntervalOfTimePredicate(INeedHotelServicesRequest message)
            {
                if (message.IntervalOfDays.IsNull())
                {
                    return x => true;
                }
                else if (message.IntervalOfDays.Min == null && message.IntervalOfDays.Max != null)
                {
                    return x => message.IntervalOfDays.Max >= x.DateStart && message.IntervalOfDays.Max <= x.DateEnd;
                }
                else if(message.IntervalOfDays.Min != null && message.IntervalOfDays.Max == null)
                {
                    return x => message.IntervalOfDays.Min >= x.DateStart && message.IntervalOfDays.Min <= x.DateEnd;
                }
                return x => message.IntervalOfDays.Min >= x.DateStart && message.IntervalOfDays.Max <= x.DateEnd;
            }

            private static Func<HotelServiceInformation, bool> NumberOfRoomsPredicate(INeedHotelServicesRequest message)
            {
                if (message.NumberOfRooms == null)
                {
                    return x => true;
                }

                return x => x.NumberOfRooms >= message.NumberOfRooms;
            }

            private static Func<HotelServiceInformation, bool> NumberOfPlpPerRoomPredicate(INeedHotelServicesRequest message)
            {
                if (message.NumberOfPeoplePerRoom == null)
                {
                    return x => true;
                }

                return x => x.NumberOfPeoplePerRoom == message.NumberOfPeoplePerRoom;
            }

            private static Func<HotelServiceInformation, bool> HotelPricePredicate(INeedHotelServicesRequest message)
            {
                if (message.HotelPrice.IsNull())
                {
                    return x => true;
                }
                else if (message.HotelPrice.Min == null && message.HotelPrice.Max != null)
                {
                    return x => message.HotelPrice.Max >= x.Price;
                }
                else if (message.HotelPrice.Min != null && message.HotelPrice.Max == null)
                {
                    return x => message.HotelPrice.Min <= x.Price;
                }
                return x => x.Price <= message.HotelPrice.Max && x.Price >= message.HotelPrice.Min;
            }
        }
    }
}