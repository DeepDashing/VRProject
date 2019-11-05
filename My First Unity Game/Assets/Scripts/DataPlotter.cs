using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPlotter : MonoBehaviour
{
    public GameObject PointPrefab;
    public Material red;
    public Material blue;
    public int maxPoints;
    

    private List<int> pointList;

    // Start is called before the first frame update
    void Start()
    {
        //instantiate prefab
        //(PointPrefab, new Vector3(0,0,0), Quaternion.identity);

        pointList = GenerateData();

        //Log to console
        foreach (int val in pointList)
        {
            Debug.Log(val);
        }
        
        //loop through Pointlist
        for (var i = 0; i < pointList.Count; i++)
        {
            //Get value in pointList
            float x = System.Convert.ToSingle(i);
            float y = System.Convert.ToSingle(pointList[i]);
            float z = System.Convert.ToSingle(0);
           


            if (y > 1)
            {
                PointPrefab.GetComponent<Renderer>().material = red;
            }

            else
            {
                PointPrefab.GetComponent<Renderer>().material = blue;
            }
            

            

            //instantiate the prefab with coordinates defined above
            Instantiate(PointPrefab, new Vector3(x, y, z), Quaternion.identity);

            
        }
    }

    public List<int> GenerateData()
    {
        List<int> myData = new List<int>();

        int fakeNumber;
        for (int i = 0; i < maxPoints; i++)
        {
            fakeNumber = System.Convert.ToInt32(Random.Range(0, 10));
            myData.Add(fakeNumber);
        }

        return myData;
    }
}
