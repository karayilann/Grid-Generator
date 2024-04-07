using _Project.Runtime.Scripts;
using UnityEditor;
using UnityEngine;

namespace _Project.Editor
{
    [CustomEditor(typeof(GridGenerator))]
    public class MyGridToolMhk : UnityEditor.Editor
    {
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

        public override void OnInspectorGUI()
        {
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