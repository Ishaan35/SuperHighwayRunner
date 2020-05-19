using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class Save
{
    public static void SavePlayer (MoneyCount MoneyAmount)
    {
        Debug.Log("Saving!");
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/PLAYERSAVEDATAMAIN1.dat";
        FileStream stream = new FileStream(path, FileMode.Create);

        Stats data = new Stats(MoneyAmount);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static Stats LoadPlayer()
    {
        string path = Application.persistentDataPath + "/PLAYERSAVEDATAMAIN1.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Stats data = formatter.Deserialize(stream) as Stats;

            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file not found in " + path);
            return null;
        }
    }

   

    

    

    
}
