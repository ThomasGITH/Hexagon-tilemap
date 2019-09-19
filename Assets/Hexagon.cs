using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Material material;

    void Awake()
    {
        Vector3[] vertices = new Vector3[7];
        Vector2[] uv = new Vector2[7];
        int[] triangles = new int[18];

        vertices[0] = new Vector3(0.25f, 0.0f);
        vertices[1] = new Vector3(0.75f, 0.0f);
        vertices[2] = new Vector3(0.5f, 0.5f);
        vertices[3] = new Vector3(1.0f, 0.5f);
        vertices[4] = new Vector3(0.75f, 1.0f);
        vertices[5] = new Vector3(0.25f, 1.0f);
        vertices[6] = new Vector3(0.0f, 0.5f);

        uv[0] = new Vector2(0.25f, 0.0f);
        uv[1] = new Vector2(0.75f, 0.0f);
        uv[2] = new Vector2(0.5f, 0.0f);
        uv[3] = new Vector2(1.0f, 0.5f);
        uv[4] = new Vector2(0.75f, 1.0f);
        uv[5] = new Vector2(0.25f, 1.0f);
        uv[6] = new Vector2(0.0f, 0.5f);

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;

        triangles[3] = 2;
        triangles[4] = 1;
        triangles[5] = 3;

        triangles[6] = 3;
        triangles[7] = 4;
        triangles[8] = 2;

        triangles[9] = 2;
        triangles[10] = 4;
        triangles[11] = 5;

        triangles[12] = 2;
        triangles[13] = 5;
        triangles[14] = 6;

        triangles[15] = 2;
        triangles[16] = 6;
        triangles[17] = 0;

        Mesh mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = triangles;

        GameObject go = new GameObject("Hexagon", typeof(MeshFilter), typeof(MeshRenderer));
        go.transform.position = new Vector2(-20,-20);
        go.GetComponent<MeshFilter>().mesh = mesh;

        go.GetComponent<MeshRenderer>().material = material;

    }
}
