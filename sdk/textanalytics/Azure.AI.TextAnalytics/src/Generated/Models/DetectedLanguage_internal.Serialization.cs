// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial struct DetectedLanguage_internal
    {
        internal static DetectedLanguage_internal DeserializeDetectedLanguage_internal(JsonElement element)
        {
            string name = default;
            string iso6391Name = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iso6391Name"))
                {
                    iso6391Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new DetectedLanguage_internal(name, iso6391Name, confidenceScore);
        }
    }
}
