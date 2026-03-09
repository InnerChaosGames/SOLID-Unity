using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOLID.DependencyInversion.InspectorDI
{
    public class Car : MonoBehaviour
    {
        [SerializeField] private CarSettings carSettings;
        [SerializeField] private MonoBehaviour inputSource;

        private ICarInput carInput;
        private CarControl carControl;

        private void Awake()
        {
            carInput = inputSource as ICarInput;

            if (carInput == null)
            {
                Debug.LogError("Assigned inputSource does not implement ICarInput.", this);
                enabled = false;
                return;
            }
            
            carControl = new CarControl(carInput, transform, carSettings);
        }

        private void Update()
        {
            carInput.ReadInput();
            carControl.Tick();
        }
    }
}