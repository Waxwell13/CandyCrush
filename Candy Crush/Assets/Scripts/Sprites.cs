using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour
{
    public List<Sprite> sprites = new List<Sprite>(5);
    public SpriteRenderer spriteRenderer;
    public int shape;
    public 
    enum Spirtes
    { Square,Circle,Diamond,Star,Hexagon }



    // Start is called before the first frame update
    void Start()
    {
        shape = (int)Random.Range(0, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
