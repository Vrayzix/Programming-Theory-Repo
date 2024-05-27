using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITENCE
public class Capsule : Shape
{
    //POLYMORPHISM
    protected override void DisplayText()
    {
        Debug.Log("Capsule");
        Color = "White";
        //ABSTRACTION
        PrintColor();
    }
}
