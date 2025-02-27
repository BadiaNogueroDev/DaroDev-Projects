using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TabGroup))]
public class TabGroupEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        TabGroup tabGroup = (TabGroup)target;

        if (GUILayout.Button("Add tab")) 
            tabGroup.AddTab();
        if (GUILayout.Button("Remove tab"))
            tabGroup.RemoveTab();
    }
}
