using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPlaneGenerator : MonoBehaviour
{
    public float size;
    public int gridSize = 16;

    private MeshFilter filter;
    // Start is called before the first frame update
    private void Start()
    {
        filter = GetComponent<MeshFilter>();
        filter.mesh = GenerateMesh();
    }
    private Mesh GenerateMesh()
    {
        Mesh m = new Mesh();

        var verticities = new List<Vector3>(); // values of x,y,z
        var normals = new List<Vector3>();
        var UVS = new List<Vector2>(); // Values of x, z only

        for (int x = 0; x < gridSize + 1; x++)
        {
            for (int y = 0; y < gridSize + 1; y++ )
            {
                verticities.Add(new Vector3(-size * 0.5f + size * (x / ((float)gridSize)), 0, -size * 0.5f + size * 0.5f + size * (y / ((float)gridSize))));
                normals.Add(Vector3.up);
                UVS.Add(new Vector2(x / (float)gridSize, y / (float)gridSize));
            }
        }

        var triangles = new List<int>();
        var vertCount = gridSize + 1;
        for (int i = 0; i < vertCount * vertCount - vertCount; i++)
        {
            if ((i+1)% vertCount == 0)
            {
                continue;
            }

            triangles.AddRange(new List<int>()
            {
                i+1+vertCount, i+vertCount, i, 
                i, i+ 1, i+vertCount+1
            });
        }

        m.SetVertices(verticities);
        m.SetNormals(normals);
        m.SetUVs(0, UVS);
        m.SetTriangles(triangles, 0);

        return m;
    }

}
