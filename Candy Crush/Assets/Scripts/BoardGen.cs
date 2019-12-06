using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardGen : MonoBehaviour
{

    public Vector2 BoardSize;
    public Vector2 TopLeft;
    public Vector2 cellSize;
    public GameObject[] spriteList;
    public Vector2 StartTile()
    {

        //topleft
        int x, y;
        x = (int)(-(BoardSize.x / 2));
        y = (int)(BoardSize.y / 2);
        return new Vector2(x, y);
    }


    public void AddSprite()
    {

    }
   
    void Start()
    {
        //int board;
        transform.localScale = new Vector3(BoardSize.x, BoardSize.y);
        TopLeft = StartTile();
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
