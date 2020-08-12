using System;
using Squibi.Core.Components;

namespace Squibi.Core.Exceptions
{
    public class ComponentNotFoundException<TC> : Exception where TC : IComponent
    {
        public ComponentNotFoundException() : base($"{typeof(TC).Name} not found on owner")
        {
        }
    }
}