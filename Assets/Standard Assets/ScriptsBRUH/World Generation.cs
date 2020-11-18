
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
public class WorldGeneration : MonoBehaviour
{
    public Mesh mesh;
    Vector3[] vert;
    int[] tris;

    // Start is called before the first frame update
    void Start()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        CreateMesh();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateMesh()
    {
        vert = new Vector3[]
       {
           new  Vector3(0,0,0),
           new Vector3(0,1,0),
           new Vector3(0,0,1)
       };
        tris = new int[]
        {
            0,1,2
        };

        mesh.Clear();
        mesh.vertices = vert;
        mesh.triangles = tris;
    }
}
