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
            Debug.Log("Muhammet Hamit Karayılan");
            Debug.Log("https://linktr.ee/karayilann");

            // Prefab instantiate işlemi
            GameObject prefab = Resources.Load<GameObject>("MyGridToolMhk"); // Prefab ismi ile değiştirilmeli
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