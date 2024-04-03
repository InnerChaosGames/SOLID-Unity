using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

namespace SOLID.DependencyInversion
{
    public class CarControl
    {
        private readonly ICarInput carInput;
        private readonly Transform transform;
        private readonly CarSettings carSettings;

        public CarControl(ICarInput carInput, Transform transform, CarSettings carSettings)
        {
            this.carInput = carInput;
            this.transform = transform;
            this.carSettings = carSettings;
        }

        public void Tick()
        {
            transform.Rotate(Vector3.back * carInput.Rotation * Time.deltaTime * carSettings.TurnSpeed);
            transform.position += transform.up * carInput.Movement * Time.deltaTime * carSettings.MoveSpeed;
        }
    }
}