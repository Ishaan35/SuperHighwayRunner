using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSomeNoise : MonoBehaviour
{
    public float power = 3;
    public float scale = 1;
    public float timescale = 1;

    private float Xoffset;
    private float Yoffset;
    private MeshFilter mf;
    // Start is called before the first frame update
    void Start()
    {
        mf = GetComponent<MeshFilter>();
        MakeNoise();
    }

    // Update is called once per frame
    void Update()
    {
        MakeNoise();
        Xoffset += Time.deltaTime * timescale;
        Yoffset += Time.deltaTime * timescale;
    }

    void MakeNoise()
    {
        Vector3[] verticies = mf.mesh.vertices;

        for (int i = 0; i < verticies.Length; i++)
        {
            verticies[i].y = CalculateHeight(verticies[i].x, verticies[i].z) * power;
        }

        mf.mesh.vertices = verticies;


    }

    float CalculateHeight(float x, float y)
    {
        float xCord = x * scale + Xoffset;
        float yCord = y * scale + Yoffset;

        return Mathf.PerlinNoise(xCord, yCord);
    }
   

    
    
}
