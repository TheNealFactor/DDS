using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfEdge3D
{
    //The vertex the edge points to
    public Vertex3D v;

    //The face this edge is a part of
    public Triangle3D t;

    //The next edge
    public HalfEdge3D nextEdge;
    //The previous
    public HalfEdge3D prevEdge;
    //The edge going in the opposite direction
    public HalfEdge3D oppositeEdge;

    //This structure assumes we have a vertex class with a reference to a half edge going from that vertex
    //and a face (triangle) class with a reference to a half edge which is a part of this face 
    public HalfEdge3D(Vertex3D v)
    {
        this.v = v;
    }
}