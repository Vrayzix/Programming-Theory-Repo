using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITENCE
public class Sphere : Shape
{
    //POLYMORPHISM
    protected override void DisplayText()
    {
        Debug.Log("Sphere");
        Color = "Green";
        //ABSTRACTION
        PrintColor();
    }
}
