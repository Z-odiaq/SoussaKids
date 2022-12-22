using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class save_load : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //check if file exists if not create it
        if (!File.Exists("./SoussaKidsSaves.txt"))
        {
            File.Create("./SoussaKidsSaves.txt");
        }
    }
    public static void Save(string data)
    {
        //save to file 
        //load from file
        if (!File.Exists("./SoussaKidsSaves.txt"))
        {
            File.Create("./SoussaKidsSaves.txt");
        }
        string filePath = "./SoussaKidsSaves.txt";

        // Write the data to a file using a StreamWriter
        using (StreamWriter writer = new StreamWriter(filePath, false))
        {
            writer.Write(data);
        }

        // Alternatively, you can use the File.WriteAllText method to write the data to a file
        File.WriteAllText(filePath, data);
    }
    public static string Load()
    {
        if (!File.Exists("./SoussaKidsSaves.txt"))
        {
            File.Create("./SoussaKidsSaves.txt");
        }
        string filePath = "./SoussaKidsSaves.txt";

        // Read the data from a file using a StreamReader
        using (StreamReader reader = new StreamReader(filePath))
        {
            return reader.ReadToEnd();
        }

        // Alternatively, you can use the File.ReadAllText method to read the data from a file
        return File.ReadAllText(filePath);
    }
}
