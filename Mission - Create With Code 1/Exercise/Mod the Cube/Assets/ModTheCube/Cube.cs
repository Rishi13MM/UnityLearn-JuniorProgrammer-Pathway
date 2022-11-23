using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float rotateSpeed;
    private float cubeSize;
    
    void Start()
    {
        InvokeRepeating("ChangeCubeColor",1.0f,3f);
        rotateSpeed = Random.Range(10f,30f);
        cubeSize = Random.Range(1f,5f);

        transform.position = new Vector3(3, 4, 1);
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
        transform.localScale = Vector3.one * cubeSize;

    }
    
    void Update()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0.0f, 0.0f);
    }

    void ChangeCubeColor()
    {
        Color cubeColor = new Color(Random.Range(0f,255f)/255f,Random.Range(0f,255f)/255f,Random.Range(0f,255f)/255f,Random.Range(0f,1f));
        Renderer.material.color = cubeColor;
    }
}
