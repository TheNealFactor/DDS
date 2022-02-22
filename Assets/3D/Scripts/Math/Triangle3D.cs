using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle3D
{
    //Corners
    public Vertex3D v1;
    public Vertex3D v2;
    public Vertex3D v3;

    //If we are using the half edge mesh structure, we just need one half edge
    public HalfEdge3D halfEdge;

    public Triangle3D(Vertex3D v1, Vertex3D v2, Vertex3D v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

    public Triangle3D(Vector3 v1, Vector3 v2, Vector3 v3)
    {
        this.v1 = new Vertex3D(v1);
        this.v2 = new Vertex3D(v2);
        this.v3 = new Vertex3D(v3);
    }

    public Triangle3D(HalfEdge3D halfEdge)
    {
        this.halfEdge = halfEdge;
    }

    //Change orientation of triangle from cw -> ccw or ccw -> cw
    public void ChangeOrientation()
    {
        Vertex3D temp = this.v1;

        this.v1 = this.v2;

        this.v2 = temp;
    }
}