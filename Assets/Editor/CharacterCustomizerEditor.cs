using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterCustomizer))]
public class CharacterCustomizerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        CharacterCustomizer characterCustomizer = (CharacterCustomizer)target;

        if (GUILayout.Button("Randomise Character"))
            characterCustomizer.SetCharacter();
        if (GUILayout.Button("Swap Gender")) 
            characterCustomizer.SwapGender();
    }
}
