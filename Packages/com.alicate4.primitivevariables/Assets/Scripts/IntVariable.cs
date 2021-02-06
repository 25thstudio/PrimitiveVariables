using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntVariable : ScriptableObject
{
    #region Properties
    [Multiline]
    [SerializeField]
    private string description;

    [SerializeField]
    private int intValue;

    #endregion

    #region Setters and getters
    public int Value { get => intValue; set => intValue = value; }

    public int Increase(int value = 0)
    {
        intValue += value;
        return intValue;
    }

    public int Decrease(int value = 0)
    {
        intValue -= value;
        return intValue;
    }
    #endregion




}
