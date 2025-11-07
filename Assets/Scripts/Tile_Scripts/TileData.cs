using UnityEngine;

[System.Serializable]
public class TileData
{
    public TileType type;
    public bool walkable;
    public bool cuttable;
    public bool regrows;
    public float regrowTime;
}
public enum TileType
{
    Grass,
    Tree,
    Boulder,
    House
}

