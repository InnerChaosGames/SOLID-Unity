using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;


namespace SOLID.InterfaceSegregation
{
    public class NPC : MonoBehaviour, IHaveHealth, ICanTalk
    {
        [field: SerializeField]
        public int Health { get; private set; }

        [field: SerializeField]
        public int MaxHealth { get; private set; }

        [field: SerializeField]
        public string Dialogue { get; private set; }

        public void TakeDamage(int damageToDeal)
        {
            Health -= damageToDeal;
            Debug.Log("NPC" + " Remaining Health: " + Health);
        }

        public void Talk()
        {
            Debug.Log(Dialogue);
        }
    }
}