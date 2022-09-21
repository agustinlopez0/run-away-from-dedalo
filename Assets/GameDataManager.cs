// Add System.IO to work with files!
using System.IO;
// Add System.Security.Crytography to use Encryption!
using System.Security.Cryptography;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    // Create a field for the save file.
    string saveFile;

    // Create a GameData field.
    public GameData gameData = new GameData();

    // FileStream used for reading and writing files.
    FileStream dataStream;

    // Key for reading and writing encrypted data.
    // (This is a "hardcoded" secret key. )
    byte[] savedKey = { 0x16, 0x15, 0x16, 0x15, 0x16, 0x15, 0x16, 0x15, 0x16, 0x15, 0x16, 0x15, 0x16, 0x15, 0x16, 0x15 };

    void Awake()
    {
        // Update the path once the persistent path exists.
        saveFile = Application.persistentDataPath + "/gamedata.json";
    }

    public void readFile()
    {
        // Does the file exist?
        Debug.Log("hohoho");
        Debug.Log(saveFile);
        if (File.Exists(saveFile))
        {
            // Create FileStream for opening files.
            dataStream = new FileStream(saveFile, FileMode.Open);

            // Create new AES instance.
            Aes oAes = Aes.Create();

            // Create an array of correct size based on AES IV.
            byte[] outputIV = new byte[oAes.IV.Length];

            // Read the IV from the file.
            dataStream.Read(outputIV, 0, outputIV.Length);

            // Create CryptoStream, wrapping FileStream
            CryptoStream oStream = new CryptoStream(
                   dataStream,
                   oAes.CreateDecryptor(savedKey, outputIV),
                   CryptoStreamMode.Read);

            // Create a StreamReader, wrapping CryptoStream
            StreamReader reader = new StreamReader(oStream);

            // Read the entire file into a String value.
            string text = reader.ReadToEnd();
            // Always close a stream after usage.
            reader.Close();

            // Deserialize the JSON data 
            //  into a pattern matching the GameData class.
            gameData = JsonUtility.FromJson<GameData>(text);
        }
        //Debug.Log(gameData.valor);
    }

    public void writeFile()
    {
        // Create new AES instance.
        Aes iAes = Aes.Create();

        // Create a FileStream for creating files.
        dataStream = new FileStream(saveFile, FileMode.Create);

        // Save the new generated IV.
        byte[] inputIV = iAes.IV;

        // Write the IV to the FileStream unencrypted.
        dataStream.Write(inputIV, 0, inputIV.Length);

        // Create CryptoStream, wrapping FileStream.
        CryptoStream iStream = new CryptoStream(
                dataStream,
                iAes.CreateEncryptor(savedKey, iAes.IV),
                CryptoStreamMode.Write);

        // Create StreamWriter, wrapping CryptoStream.
        StreamWriter sWriter = new StreamWriter(iStream);

        // Serialize the object into JSON and save string.
        string jsonString = JsonUtility.ToJson(gameData);

        // Write to the innermost stream (which will encrypt).
        sWriter.Write(jsonString);

        // Close StreamWriter.
        sWriter.Close();

        // Close CryptoStream.
        iStream.Close();

        // Close FileStream.
        dataStream.Close();
    }
}