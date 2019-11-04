using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEditor;
using System.Text;

public class DatabaseAssetMove : MonoBehaviour
{
    private string conn, sqlQuery;
    private int index = 1;
    public Material[] Imported_Materials;
    public Renderer rend;
    IDbConnection dbconn;
    IDbCommand dbcmd;

    // Use this for initialization
    void Start()
    {
        /*conn = "URI=file:" + Application.dataPath + "/Plugins/Users.s3db"; //Path to database.
                                                                           //Deletvalue(6);
                                                                           //insertvalue("ahmedm", "ahmedm@gmail.com", "sss"); 
                                                                           //Updatevalue("a", "w@gamil.com", "1st", 1);
                                                                           //Deletvalue("a");

        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("SELECT * FROM Userinfo WHERE id =\"{0}\" ", 1);// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                //int id = reader.GetInt32(0);
                //string name = reader.GetString(1);
                //string Email = reader.GetString(2);
                string InitialAddress = reader.GetString(4);

                AssetDatabase.CopyAsset(InitialAddress, "Assets/Imported_Materials/ItIsBlue.mat");

            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            dbconn = null;
        }
        */
        // Start is called before the first frame update
        rend = GetComponent<Renderer>();
        rend.enabled = true;


    }
    

    // Update is called once per frame
    void OnMouseDown()
    {
        if (Imported_Materials.Length == 0)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            index += 1;
            if (index == Imported_Materials.Length + 1)
            {
                index = 1;
            }
        }
        print(index);

        rend.sharedMaterial = Imported_Materials[index - 1];

    }

}