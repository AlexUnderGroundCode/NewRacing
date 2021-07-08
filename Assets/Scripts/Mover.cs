using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mover : MonoBehaviour
{
    public Transform SelfTransform;
    private Vector3 force;
    private bool isAccelerated;
    public Tilemap Map;
    public TileBase GroundTile;

    public void LeftRotation()
    {
        SelfTransform.Rotate(0, 0, 5);
    }
    public void RightRotation()
    {
        SelfTransform.Rotate(0, 0, -5);
    }
    public void Acceleration()
    {
        isAccelerated = true;
        force += (SelfTransform.up * Time.deltaTime) * 0.06f;
    }
    
    public void LateUpdate()
    {
        if(!isAccelerated)
        {
            force = Vector3.Lerp(force, Vector3.zero, Time.deltaTime);
        }
        if( GroundTile == Map.GetTile(new Vector3Int((int)SelfTransform.position.x,
            (int)SelfTransform.position.y,
            (int)SelfTransform.position.z)))
        {
           force *= 0.9f;
        }
        
        SelfTransform.position += force;
        
        
        isAccelerated = false;

    }
}
