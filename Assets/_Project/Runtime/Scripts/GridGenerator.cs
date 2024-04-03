using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.Runtime.Scripts
{
    public class GridGenerator : MonoBehaviour
    {
        public int Width;
        public int Height;
        
        public float CellSpacingX;
        
        public float CellSpacingY;
        
        public GameObject GridPrefab;
        
        public Vector3 StartOffset = Vector3.zero;

        private void Start()
        {
            GenerateGrid();
        }

        private void GenerateGrid()
        {
            CellSpacingX += GridPrefab.transform.localScale.x;
            CellSpacingY += GridPrefab.transform.localScale.y;
            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Vector3 _prefabPosition = new Vector3(x * CellSpacingX, y * CellSpacingY, 0f);
                    
                    _prefabPosition += StartOffset;

                    var instantiatedObject = Instantiate(GridPrefab, _prefabPosition, Quaternion.identity);
                }
            }
        }
    }
}
