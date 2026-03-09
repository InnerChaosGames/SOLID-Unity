using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.InterfaceSegregation
{
    public interface ICanTalk
    {
        string Dialogue { get; }

        void Talk();
    }
}