// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class KeyValueElement_internal
    {
        internal static KeyValueElement_internal DeserializeKeyValueElement_internal(JsonElement element)
        {
            KeyValueElement_internal result = new KeyValueElement_internal();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    result.Text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingBox"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.BoundingBox = new List<float>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.BoundingBox.Add(item.GetSingle());
                    }
                    continue;
                }
                if (property.NameEquals("elements"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Elements = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Elements.Add(item.GetString());
                    }
                    continue;
                }
            }
            return result;
        }
    }
}