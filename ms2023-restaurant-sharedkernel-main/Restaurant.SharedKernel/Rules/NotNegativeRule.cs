﻿using NurBNB.Reservas.SharedKernel.Core;

namespace NurBNB.Reservas.SharedKernel.Rules;

public class NotNegativeRule : IBussinessRule
{
    private readonly decimal _value;

    public string Message => "Value cannot be negative";

    public NotNegativeRule(decimal value)
    {
	   _value = value;
    }
    public bool IsValid()
    {
	   return _value >= 0;
    }
}
