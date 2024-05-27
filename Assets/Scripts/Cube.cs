using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITENCE
public class Cube : Shape
{
    
    //POLYMORPHISM
    protected override void DisplayText()
    {
        Debug.Log("Cube");
        Color = "Red";
        //ABSTRACTION
        PrintColor();
    }
}
