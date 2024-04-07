using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.Runtime.Scripts
{
    public class GridGenerator : MonoBehaviour
    {
        [Header("Cell Dimensions")]
        public int Width;
        public int Height;
        
        [Header("Cell Spacing")]
        public float CellSpacingX;
        public float CellSpacingY;

        [Header("")]
        public GameObject GridPrefab;
        public Vector3 StartOffset = Vector3.zero;
        
        public void GenerateGridXY()
        {
            CellSpacingX += GridPrefab.transform.localScale.x;
            CellSpacingY += GridPrefab.transform.localScale.y;
            
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Vector3 _prefabPosition = new Vector3(x * CellSpacingX, y * CellSpacingY, 0f);
                    
                    _prefabPosition += StartOffset;

                    var instantiatedObject = Instantiate(GridPrefab, _prefabPosition, Quaternion.identity, gameObject.transform);
                }
            }
        }
        
        // Inspector ekranından seçilen eksenlerde üretecek minimum kodlu grid generator yazılacak.
        // Seçilen eksenin buraya göndereceği değer ile üretecek
        
        
        
        
    }
}
