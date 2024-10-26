using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class Line : MonoBehaviour
{
    public float Y;

    public Line(float y)
    {
        Y = y;
    }
}
