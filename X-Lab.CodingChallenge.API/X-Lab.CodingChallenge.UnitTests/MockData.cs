// <copyright file="MockData.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using XLab.CodingChallenge.API.Models;

namespace XLab.CodingChallenge.UnitTests
{
    static class MockData
    {
        public static readonly string CsvVenues =
            @"""name"",""category"",""url"",""date"",""excerpt"",""thumbnail"",""lat"",""lng"",""address"",""phone"",""twitter"",""stars_beer"",""stars_atmosphere"",""stars_amenities"",""stars_value"",""tags""
""...escobar"",""Closed venues"",""http://leedsbeer.info/?p=765"",""2012-11-30T21:58:52+00:00"",""...It's really dark in here!"",""http://leedsbeer.info/wp-content/uploads/2012/11/20121129_185815.jpg"",""53.8007317"",""-1.5481764"",""23-25 Great George Street, Leeds LS1 3BB"",""0113 220 4389"",""EscobarLeeds"",""2"",""3"",""3"",""3"",""food,live music,sofas""
""""""Golf"""" Cafe Bar"",""Bar reviews"",""http://leedsbeer.info/?p=1382"",""2013-04-27T14:44:22+00:00"",""FORE! You can play """"golf"""" here and enjoy a nice bottled ale. "",""http://leedsbeer.info/wp-content/uploads/2013/04/20130422_204442.jpg"",""53.7934952"",""-1.5478653"",""1 Little Neville Street, Granary Wharf, Leeds LS1 4ED"",""0113 244 4428"",""GolfCafeBar"",""2.5"",""2.5"",""3.5"",""2.5"",""beer garden,coffee,food,free wifi,sports""
""115 The Headrow"",""Pub reviews"",""http://leedsbeer.info/?p=2753"",""2014-10-18T15:48:51+00:00"",""A bar that lives up to its name."",""http://leedsbeer.info/wp-content/uploads/2014/10/115.jpg"",""53.7994003"",""-1.545981"",""115 The Headrow, Leeds, LS1 5JW"","""",""BLoungeGrp"",""1.5"",""3"",""2.5"",""2"",""coffee,food""
""1871 Bar & Lounge"",""Bar reviews"",""http://leedsbeer.info/?p=1455"",""2013-05-16T16:10:30+00:00"",""Not much going on here beer-wise, but they do serve food on a Sunday evening — quite a rarity amongst city centre bars. "",""http://leedsbeer.info/wp-content/uploads/2013/05/20130506_205930.jpg"",""53.7958908"",""-1.5433109"",""7-9 Boar Lane, Leeds LS1 5DD"",""0845 200 1871"",""1871BarLeeds"",""1.5"",""3"",""2.5"",""1.5"",""coffee,food,free wifi""
""314 In Progress"",""Bar reviews"",""http://leedsbeer.info/?p=3048"",""2015-03-24T20:31:30+00:00"",""This fashionable cocktail bar & club isn't really our scene but has surprisingly good beer."",""http://leedsbeer.info/wp-content/uploads/2015/03/IMG_20150209_175103005.jpg"",""53.8007202"",""-1.5483344"",""25 Great George Street, Leeds LS1 3AL"",""0113 397 1337"",""314Leeds"",""3"",""2.5"",""1.5"",""2"",""dance floor""
""360 Champagne & Cocktails"",""Bar reviews"",""http://leedsbeer.info/?p=2098"",""2013-11-16T21:47:20+00:00"",""Circular champagne bar is nice, but with a poor beer selection."",""http://leedsbeer.info/wp-content/uploads/2013/11/IMG_20131110_150923.jpg"",""53.7972984"",""-1.545344"",""Trinity Kitchen, Albion Street, Leeds LS1 5AT"","""",""360_Trinity"",""1"",""3"",""2.5"",""3"",""coffee,free wifi""
""51% Bourbon Lounge"",""Bar reviews"",""http://leedsbeer.info/?p=1843"",""2013-08-22T20:29:53+00:00"",""As the name suggests, the raison d'être of this spot is bourbon, but there are enough good American crafts to keep us happy. "",""http://leedsbeer.info/wp-content/uploads/2013/08/IMG_20130820_211253.jpg"",""53.795681"",""-1.5416881"",""11 - 15 Hirst's Yard, Leeds LS1 6NJ"",""0113 322 9919"",""51_Bourbon"",""3"",""4"",""2"",""3"",""free wifi""
""53° North"",""Bar reviews"",""http://leedsbeer.info/?p=3517"",""2016-08-09T12:37:30+00:00"",""A high-end cocktail nightspot in the financial district. Not really our scene, and not enough beers to get us back. "",""http://leedsbeer.info/wp-content/uploads/2016/08/IMG_20160710_192730025.jpg"",""53.7976761"",""-1.5493602"",""Goodbard House,, 15 Infirmary Street, Leeds LS1 2JS"",""0113 856 0011"",""53degreesLS"",""1.5"",""2.5"",""2"",""3"",""coffee,dance floor,food""
""Aire Bar"",""Pub reviews"",""http://leedsbeer.info/?p=1568"",""2013-06-05T22:02:07+00:00"",""Looks like a gym on the outside, but exercise kit is about the only thing you won't find in here!"",""http://leedsbeer.info/wp-content/uploads/2013/06/IMAG0035.jpg"",""53.7948723"",""-1.5391223"",""Sparrows Wharf, 32 The Calls, Leeds LS2 7EW"",""0113 245 5500"","""",""3"",""3.5"",""4.5"",""2"",""arcade games,beer garden,breakfast,food,free wifi,pool table,sofas,sports""
""All Bar One — Greek Street"",""Bar reviews"",""http://leedsbeer.info/?p=2305"",""2014-03-17T23:03:33+00:00"",""One of the two All Bar Ones in Leeds, and definitely the less interesting of the two."",""http://leedsbeer.info/wp-content/uploads/2014/03/IMG_20140310_184308.jpg"",""53.7985039"",""-1.5490319"",""27 East Parade, Leeds LS1 5BN"",""0113 245 2485"",""YourAllBarOne"",""3"",""2"",""3.5"",""2.5"",""beer garden,breakfast,coffee,food,free wifi""";

        public static readonly Venue[] Venues = new[]
        {
            new Venue
            {
                name = "...escobar",
                category = "Closed venues",
                url = "http://leedsbeer.info/?p=765",
                date = "2012-11-30T21:58:52+00:00",
                excerpt = "...It's really dark in here!",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2012/11/20121129_185815.jpg",
                lat = 53.8007317,
                lng = -1.5481764,
                address = "23-25 Great George Street, Leeds LS1 3BB",
                phone = "0113 220 4389",
                twitter = "EscobarLeeds",
                stars_beer = 2,
                stars_atmosphere = 3,
                stars_amenities = 3,
                stars_value = 3,
                tags = "food,live music,sofas"
            },
            new Venue
            {
                name = "\"Golf\" Cafe Bar",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=1382",
                date = "2013-04-27T14:44:22+00:00",
                excerpt = "FORE! You can play \"golf\" here and enjoy a nice bottled ale.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/04/20130422_204442.jpg",
                lat = 53.7934952,
                lng = -1.5478653,
                address = "1 Little Neville Street, Granary Wharf, Leeds LS1 4ED",
                phone = "0113 244 4428",
                twitter = "GolfCafeBar",
                stars_beer = 2.5,
                stars_atmosphere = 2.5,
                stars_amenities = 3.5,
                stars_value = 2.5,
                tags = "beer garden,coffee,food,free wifi,sports"
            },
            new Venue
            {
                name = "115 The Headrow",
                category = "Pub reviews",
                url = "http://leedsbeer.info/?p=2753",
                date = "2014-10-18T15:48:51+00:00",
                excerpt = "A bar that lives up to its name.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2014/10/115.jpg",
                lat = 53.7994003,
                lng = -1.545981,
                address = "115 The Headrow, Leeds, LS1 5JW",
                phone = "",
                twitter = "BLoungeGrp",
                stars_beer = 1.5,
                stars_atmosphere = 3,
                stars_amenities = 2.5,
                stars_value = 2,
                tags = "coffee,food"
            },
            new Venue
            {
                name = "1871 Bar & Lounge",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=1455",
                date = "2013-05-16T16:10:30+00:00",
                excerpt =
                    "Not much going on here beer-wise, but they do serve food on a Sunday evening — quite a rarity amongst city centre bars.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/05/20130506_205930.jpg",
                lat = 53.7958908,
                lng = -1.5433109,
                address = "7-9 Boar Lane, Leeds LS1 5DD",
                phone = "0845 200 1871",
                twitter = "1871BarLeeds",
                stars_beer = 1.5,
                stars_atmosphere = 3,
                stars_amenities = 2.5,
                stars_value = 1.5,
                tags = "coffee,food,free wifi"
            },
            new Venue
            {
                name = "314 In Progress",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=3048",
                date = "2015-03-24T20:31:30+00:00",
                excerpt = "This fashionable cocktail bar & club isn't really our scene but has surprisingly good beer.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2015/03/IMG_20150209_175103005.jpg",
                lat = 53.8007202,
                lng = -1.5483344,
                address = "25 Great George Street, Leeds LS1 3AL",
                phone = "0113 397 1337",
                twitter = "314Leeds",
                stars_beer = 3,
                stars_atmosphere = 2.5,
                stars_amenities = 1.5,
                stars_value = 2,
                tags = "dance floor"
            },
            new Venue
            {
                name = "360 Champagne & Cocktails",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=2098",
                date = "2013-11-16T21:47:20+00:00",
                excerpt = "Circular champagne bar is nice, but with a poor beer selection.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/11/IMG_20131110_150923.jpg",
                lat = 53.7972984,
                lng = -1.545344,
                address = "Trinity Kitchen, Albion Street, Leeds LS1 5AT",
                phone = "",
                twitter = "360_Trinity",
                stars_beer = 1,
                stars_atmosphere = 3,
                stars_amenities = 2.5,
                stars_value = 3,
                tags = "coffee,free wifi"
            },
            new Venue
            {
                name = "51% Bourbon Lounge",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=1843",
                date = "2013-08-22T20:29:53+00:00",
                excerpt =
                    "As the name suggests, the raison d'être of this spot is bourbon, but there are enough good American crafts to keep us happy.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/08/IMG_20130820_211253.jpg",
                lat = 53.795681,
                lng = -1.5416881,
                address = "11 - 15 Hirst's Yard, Leeds LS1 6NJ",
                phone = "0113 322 9919",
                twitter = "51_Bourbon",
                stars_beer = 3,
                stars_atmosphere = 4,
                stars_amenities = 2,
                stars_value = 3,
                tags = "free wifi"
            },
            new Venue
            {
                name = "53° North",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=3517",
                date = "2016-08-09T12:37:30+00:00",
                excerpt =
                    "A high-end cocktail nightspot in the financial district. Not really our scene, and not enough beers to get us back.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2016/08/IMG_20160710_192730025.jpg",
                lat = 53.7976761,
                lng = -1.5493602,
                address = "Goodbard House,, 15 Infirmary Street, Leeds LS1 2JS",
                phone = "0113 856 0011",
                twitter = "53degreesLS",
                stars_beer = 1.5,
                stars_atmosphere = 2.5,
                stars_amenities = 2,
                stars_value = 3,
                tags = "coffee,dance floor,food"
            },
            new Venue
            {
                name = "Aire Bar",
                category = "Pub reviews",
                url = "http://leedsbeer.info/?p=1568",
                date = "2013-06-05T22:02:07+00:00",
                excerpt =
                    "Looks like a gym on the outside, but exercise kit is about the only thing you won't find in here!",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2013/06/IMAG0035.jpg",
                lat = 53.7948723,
                lng = -1.5391223,
                address = "Sparrows Wharf, 32 The Calls, Leeds LS2 7EW",
                phone = "0113 245 5500",
                twitter = "",
                stars_beer = 3,
                stars_atmosphere = 3.5,
                stars_amenities = 4.5,
                stars_value = 2,
                tags = "arcade games,beer garden,breakfast,food,free wifi,pool table,sofas,sports"
            },
            new Venue
            {
                name = "All Bar One — Greek Street",
                category = "Bar reviews",
                url = "http://leedsbeer.info/?p=2305",
                date = "2014-03-17T23:03:33+00:00",
                excerpt = "One of the two All Bar Ones in Leeds, and definitely the less interesting of the two.",
                thumbnail = "http://leedsbeer.info/wp-content/uploads/2014/03/IMG_20140310_184308.jpg",
                lat = 53.7985039,
                lng = -1.5490319,
                address = "27 East Parade, Leeds LS1 5BN",
                phone = "0113 245 2485",
                twitter = "YourAllBarOne",
                stars_beer = 3,
                stars_atmosphere = 2,
                stars_amenities = 3.5,
                stars_value = 2.5,
                tags = "beer garden,breakfast,coffee,food,free wifi"
            },
        };
    }
}