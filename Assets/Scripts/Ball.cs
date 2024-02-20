using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball
{
    float radius;

    public float Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public Ball(float radius)
    {
        this.radius = radius;
    }
}
