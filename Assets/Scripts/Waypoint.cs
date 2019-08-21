using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour {

    const int gridSize = 4;
    public bool hasCoin = false;
    public bool isPlaceable = true;

    [SerializeField] private Vector2Int gridPosition;

    void Start( ) {
        GetGridPosition( );
    }
    void OnMouseOver( ) {
        if( isPlaceable ) {
            if( Input.GetMouseButtonDown( 0 ) ) {
                SpawnCoin( );
            }
        }
    }

    private void SpawnCoin( ) {
        if( !hasCoin ) {
            
        }
    }

    public int getGridSize( ) {
        return gridSize;
    }
    public Vector2Int GetGridPosition( ) {
        gridPosition = new Vector2Int(
        Mathf.RoundToInt( transform.position.x / gridSize ),
        Mathf.RoundToInt( transform.position.z / gridSize ) );
        return gridPosition;
    }
    public bool CheckIsPlaceable( ) {
        return isPlaceable;
    }
}
