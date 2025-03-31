using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class CharacterSaveSystem
{
    public static void SaveCharacter(CharacterCustomizer character)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/CharacterCustomizer.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        CharacterCustomizerData data = new CharacterCustomizerData(character);
        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static CharacterCustomizerData LoadCharacter()
    {
        string path = Application.persistentDataPath + "/CharacterCustomizer.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            CharacterCustomizerData data = formatter.Deserialize(stream) as CharacterCustomizerData;
            stream.Close();
            return data;
        }

        Debug.LogError("Character Customizer file not found");
        return null;
    }
}
