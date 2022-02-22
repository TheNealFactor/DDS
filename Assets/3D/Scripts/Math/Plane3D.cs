using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane3D
{
    public Vector3 pos;

    public Vector3 normal;

    public Plane3D(Vector3 pos, Vector3 normal)
    {
        this.pos = pos;

        this.normal = normal;
    }
}