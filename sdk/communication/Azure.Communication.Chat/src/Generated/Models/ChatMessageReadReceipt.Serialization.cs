// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.Chat
{
    public partial class ChatMessageReadReceipt
    {
        internal static ChatMessageReadReceipt DeserializeChatMessageReadReceipt(JsonElement element)
        {
            CommunicationIdentifierModel senderCommunicationIdentifier = default;
            string chatMessageId = default;
            DateTimeOffset readOn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("senderCommunicationIdentifier"))
                {
                    senderCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("chatMessageId"))
                {
                    chatMessageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readOn"))
                {
                    readOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ChatMessageReadReceipt(senderCommunicationIdentifier, chatMessageId, readOn);
        }
    }
}
