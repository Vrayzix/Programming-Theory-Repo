using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string color;
    public string Color
    {
        //ENCAPSULATION
        get
        {
            return color;
        }
        set
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    Debug.LogError("You cant include numbers buddy");
                    break;
                }
                color = value;
            }
        }
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    //POLYMORPHISM
    protected abstract void DisplayText();

    //ABSTRACTION
    protected void PrintColor()
    {
        if (Color != null)
        {
            Debug.Log(Color);
        }
    }
}
