﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Messages.Events.People
{
    public class PersonMoved : IEvent
    {
        public PersonMoved(Guid id, string oldStreet, string oldNumber, string newStreet, string newNumber)
        {
            this.AggregateId = id;
            this.OldStreet = oldStreet;
            this.OldNumber = oldNumber;
            this.NewStreet = newStreet;
            this.NewNumber = newNumber;
        }

        public Guid AggregateId { get; private set; }

        public string OldStreet { get; private set; }
        public string OldNumber { get; private set; }

        public string NewStreet { get; private set; }
        public string NewNumber { get; private set; }
    }
}