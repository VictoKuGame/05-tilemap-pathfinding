using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile: KeyboardMover {
    [SerializeField] Tilemap tilemap = null;
    [SerializeField] AllowedTiles allowedTiles = null;
    [SerializeField] TileBase grassTile;

    private TileBase TileOnPosition(Vector3 worldPosition) {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void Update()  {
        Vector3 newPosition = NewPosition();
        TileBase tileOnNewPosition = TileOnPosition(newPosition);
        if (allowedTiles.Contain(tileOnNewPosition)) {
            transform.position = newPosition;
        } else {
            if (tileOnNewPosition != null && tileOnNewPosition.name == "mountains")
            {
                if (Input.GetKey("x"))
                {
                    Vector3Int newPositionV3 = tilemap.WorldToCell(newPosition);
                    tilemap.SetTile(newPositionV3, grassTile);
                    if(tileOnNewPosition.name == "grass")
                    {
                        transform.position = newPosition;
                    }
                }
                if (tileOnNewPosition.name != "grass")
                {
                    Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
                }
            }
        }
    }
}
