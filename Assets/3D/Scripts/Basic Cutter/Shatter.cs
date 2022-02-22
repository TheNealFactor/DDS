using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shatter : MonoBehaviour
{
    public Material insideMaterial;
    public float loadTime;
    public int generations;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Contains("Shatter"))
        {
            StartCoroutine(ShatterObject(collision.gameObject, generations));
        }
    }

    private IEnumerator ShatterObject(GameObject obj, int gen)
    {
        yield return new WaitForSeconds(Random.Range(loadTime, loadTime * 2));

        GameObject[] pieces = MeshManipulation.MeshCut.Cut(obj, obj.GetComponent<Collider>().bounds.center, GetAngle(obj, gen), insideMaterial);

        foreach(GameObject piece in pieces)
        {
            piece.AddComponent<Rigidbody>().ResetCenterOfMass();
            piece.AddComponent<MeshCollider>().convex = true;
            //piece.AddComponent<Shatter>().loadTime = 0.15f;
            piece.tag = "Shatter";

            if(gen > 0)
            {
                StartCoroutine(ShatterObject(piece, gen - 1));
            }
        }
        Destroy(obj);
    }

    private Vector3 GetAngle(GameObject obj, int gen)
    {
        Quaternion q = Quaternion.Euler(Random.Range(-40, 40), Random.Range(-40, 40), Random.Range(-40, 40));
        Vector3[] faces = { obj.transform.forward, obj.transform.right, obj.transform.up };
        return q * faces[gen % 3];
    }
    // Start is called before the first frame update

}
