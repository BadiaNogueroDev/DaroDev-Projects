using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterCustomizer))]
public class CharacterCustomizerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        CharacterCustomizer characterCustomizer = (CharacterCustomizer)target;

        if (GUILayout.Button("Randomise Unisex Character")) 
            characterCustomizer.CreateRandomUnisexCharacter();
        if (GUILayout.Button("Randomise Gendered Character"))
            characterCustomizer.CreateRandomGenderedCharacter();
        if (GUILayout.Button("Swap Gender")) 
            characterCustomizer.SwapGender();
    }
}
