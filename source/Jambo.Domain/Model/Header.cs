﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Jambo.Domain.Model
{
    public class Header
    {
        public Guid CorrelationId { get; private set; }
        public Guid UserId { get; private set; }
        public string UserName { get; private set; }

        public Header(Guid correlationId, Guid userId, string userName)
        {
            this.CorrelationId = correlationId;
            this.UserId = userId;
            this.UserName = userName;
        }

        public static Header Create(Guid correlationId, Guid userId, string userName)
        {
            Header header = new Header(correlationId, userId, userName);
            return header;
        }

        public static Header Create(Guid correlationId)
        {
            Header header = new Header(correlationId, Guid.Empty, null);
            return header;
        }
    }
}
