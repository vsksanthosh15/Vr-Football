using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour
{
    public Renderer MaterialRenderer;
    public float Xoffset;
    // Start is called before the first frame update
    void Start()
    {
        MaterialRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MaterialRenderer.material.mainTextureOffset = new Vector2(Xoffset * Time.time, 1);
    }
}
