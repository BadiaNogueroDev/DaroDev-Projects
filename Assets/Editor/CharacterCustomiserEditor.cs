using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(CharacterCustomiser))]
public class CharacterCustomiserEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        CharacterCustomiser characterCustomiser = (CharacterCustomiser)target;

        if (GUILayout.Button("Randomise Unisex Character")) 
            characterCustomiser.CreateRandomUnisexCharacter();
        
        GUILayout.BeginHorizontal();
        
            if (GUILayout.Button("Randomise Female Character")) 
                characterCustomiser.CreateRandomFemaleCharacter();
        
            if (GUILayout.Button("Randomise Male Character"))
                characterCustomiser.CreateRandomMaleCharacter();
        
        GUILayout.EndHorizontal();
    }
}
