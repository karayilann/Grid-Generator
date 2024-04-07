using System;
using _Project.Runtime.Scripts;
using UnityEditor;
using UnityEngine;

namespace _Project.Editor
{
    [CustomEditor(typeof(GridGenerator))]
    public class MyGridToolMhk : UnityEditor.Editor
    {
        public int index = 0;
        public string[] options = new string[] {"XY Axis", "XZ Axis", "YZ Axis"};
        
        [MenuItem("Tools/My Grid Tool")]
        static void Init()
        {
            GameObject prefab = Resources.Load<GameObject>("MyGridToolMhk"); 
            if (prefab != null)
            {
                Instantiate(prefab, Vector3.zero, Quaternion.identity);
            }
            else
            {
                Debug.LogError("Prefab reference is null. Please assign a prefab.");
            }
        }

        
        // Buradaki sıralamda önce kesenleri seçecek ardından ise diğer scripttekine uygun olarak devam edecek en sonda ise butondan generate işlemi yapılarak bitirilecek.
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            index = EditorGUILayout.Popup(index, options);
            
            GridGenerator _gridGenerator = (GridGenerator)target;
            
            GUILayout.Space(10);

            if (GUILayout.Button("Generate Grid"))
            {
                _gridGenerator.GenerateGridXY();
            }

            GUILayout.Space(10);
            
            
            if (GUILayout.Button("Show Index"))
            {
                Debug.Log("Selected Option : " + index);
            }
        }
    }
}