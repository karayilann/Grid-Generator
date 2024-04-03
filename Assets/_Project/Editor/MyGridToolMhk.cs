using System;
using _Project.Runtime.Scripts;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Project.Editor
{
    [CustomEditor(typeof(GridGenerator))]
    public class MyGridToolMhk : UnityEditor.Editor
    {
        public SerializedProperty _MyGridToolMhkPrefab;
        
        [MenuItem("Tools/My Grid Tool")]
        static void Init()
        {
            Debug.Log("Muhammet Hamit Karayılan");
            Debug.Log("https://linktr.ee/karayilann");
        }
        
        public override void OnInspectorGUI()
        {
            if (GUILayout.Button("Go To Developer Page"))
            {
                Application.OpenURL("https://linktr.ee/karayilann");
            }
            
            GUILayout.Space(20);
            
            base.OnInspectorGUI();
            
            GridGenerator _gridGenerator = (GridGenerator)target;
            
            GUILayout.Space(10);
            
            if (GUILayout.Button("Generate Grid"))
            {
                _gridGenerator.GenerateGrid();
            }

        }
    }
}
