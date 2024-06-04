using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    public static MapManager instance;

    [SerializeField] private int width = 80, height = 45;
    [SerializeField] private Color32 darkColor = new Color32(0, 0, 0, 0), lightColor = new Color32(255, 255, 255, 255);
    [SerializeField] private TileBase floorTile, wallTile;
    [SerializeField] private Tilemap floorMap, obstacleMap;

    public Tilemap FloorMap { get => floorMap; }
    public Tilemap ObstacleMap { get => obstacleMap; }

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Vector3Int centerTile = new Vector3Int(width / 2, height / 2, 0);

        BoundsInt wallBounds = new BoundsInt(new Vector)
    }

}