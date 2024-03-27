using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.LiskovSubstitution
{
    public class NPC : Character
    {
        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount / 2);
        }
    }
}