using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {


    // public float speed;
    // public float Xend;
    // public float Xstart;

    // private void Update()
    // {
    //     transform.Translate(Vector2.left * speed * Time.deltaTime);
    //     if (transform.position.x < Xend) {
    //         Vector2 pos = new Vector2(Xstart, transform.position.y);
    //         transform.position = pos;
    //     } 
    // }
    public float backgroundSpeed;
    public Renderer backgroundRenderer;

    private void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
