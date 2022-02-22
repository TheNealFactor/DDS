using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//And edge between two vertices
public class Edge3D
{
    public Vertex3D v1;
    public Vertex3D v2;

    //Is this edge intersecting with another edge?
    public bool isIntersecting = false;

    public Edge3D(Vertex3D v1, Vertex3D v2)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public Edge3D(Vector3 v1, Vector3 v2)
    {
        this.v1 = new Vertex3D(v1);
        this.v2 = new Vertex3D(v2);
    }

    //Get vertex in 2d space (assuming x, z)
    public Vector2 GetVertex2D(Vertex3D v)
    {
        return new Vector2(v.position.x, v.position.z);
    }

    //Flip edge
    public void FlipEdge()
    {
        Vertex3D temp = v1;

        v1 = v2;

        v2 = temp;
    }
}