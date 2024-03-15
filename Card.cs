﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCards;

class Card(Values value, Suits suit)
{

    public Values Value { get { return value; } }

    public Suits Suit { get { return suit; } }

    public string Name
    {
        get { return $"{Value} of {Suit}"; }
    }

    public override string ToString()
    {
        return Name;
    }

}
