using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alicate4.PrimitiveVariables
{
    public class FloatVariable : ScriptableObject
    {
        #region Properties
        [Multiline]
        [SerializeField]
        private string description;
        
        [SerializeField]
        private float floatValue;

        #endregion

        #region Setters and getters
        public float Value { get => floatValue; set => floatValue = value; }

        public float Increase(float value = 0.0f)
        {
            floatValue += value;
            return floatValue;
        }

        public float Decrease(float value = 0.0f)
        {
            floatValue -= value;
            return floatValue;
        }
        #endregion




    }

}
