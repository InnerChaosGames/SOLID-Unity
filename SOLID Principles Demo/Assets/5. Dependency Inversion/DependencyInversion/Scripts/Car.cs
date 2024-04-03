using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion
{


    public class Car : MonoBehaviour
    {
        [SerializeField]
        private CarSettings carSettings;

        private ICarInput carInput;
        private CarControl carControl;

        private void Awake()
        {
            carInput = carSettings.UseConstantInput ?
                new ConstantInput() : new KeyboardInput();

            carControl = new CarControl(carInput, transform, carSettings);
        }

        private void Update()
        {
            carInput.ReadInput();
            carControl.Tick();
        }
    }
}