// <copyright file="Venue.cs" company="Bruno DUVAL">
// Copyright (c) Bruno DUVAL.</copyright>

using System;
using FileHelpers;
using Swashbuckle.AspNetCore.Annotations;

namespace XLab.CodingChallenge.API.Models
{
    [DelimitedRecord(",")]
    [IgnoreFirst]
    public class Venue
    {
        [SwaggerSchema("The name of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string name { get; set; }

        [SwaggerSchema("The category of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string category { get; set; }

        [SwaggerSchema("The BeerQuest url", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string url { get; set; }

        [SwaggerSchema("The date of the review", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string date { get; set; }

        [SwaggerSchema("The excerpt of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string excerpt { get; set; }

        [SwaggerSchema("The thumbnail of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string thumbnail { get; set; }

        [SwaggerSchema("The latitude of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double lat { get; set; }

        [SwaggerSchema("The longitude of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double lng { get; set; }

        [SwaggerSchema("The address of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string address { get; set; }

        [SwaggerSchema("The phone of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string phone { get; set; }

        [SwaggerSchema("The twitter account of the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string twitter { get; set; }

        [SwaggerSchema("The beer rating of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double stars_beer { get; set; }

        [SwaggerSchema("The atmosphere rating of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double stars_atmosphere { get; set; }

        [SwaggerSchema("The amenties rating of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double stars_amenities { get; set; }

        [SwaggerSchema("The overall rating of the venue", ReadOnly = true)]
        [FieldConverter(ConverterKind.Double)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public double stars_value { get; set; }

        [SwaggerSchema("The tags associated with the venue", ReadOnly = true)]
        [FieldQuoted('"', QuoteMode.OptionalForBoth)]
        [FieldTrim(TrimMode.Both)]
        public string tags { get; set; }
    }
}