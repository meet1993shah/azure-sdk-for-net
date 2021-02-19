// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.ObjectAnchors.Models
{
    internal partial class Vector4 : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x");
            writer.WriteNumberValue(X);
            writer.WritePropertyName("y");
            writer.WriteNumberValue(Y);
            writer.WritePropertyName("z");
            writer.WriteNumberValue(Z);
            writer.WritePropertyName("w");
            writer.WriteNumberValue(W);
            writer.WriteEndObject();
        }

        internal static Vector4 DeserializeVector4(JsonElement element)
        {
            float x = default;
            float y = default;
            float z = default;
            float w = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"))
                {
                    x = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("y"))
                {
                    y = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("z"))
                {
                    z = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("w"))
                {
                    w = property.Value.GetSingle();
                    continue;
                }
            }
            return new Vector4(x, y, z, w);
        }
    }
}
