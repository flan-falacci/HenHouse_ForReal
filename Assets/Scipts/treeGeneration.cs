using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeGeneration : MonoBehaviour
{

    public GameObject tree;
    public int treeAmount;
    int treeCount;

    public float xMax;
    public float xMin;
    public float zMax;
    public float zMin;

    // Start is called before the first frame update
    void Start()
    {
        while (treeCount < treeAmount) {
            GameObject newTree = (GameObject)Instantiate(tree, new Vector3(Random.Range(xMin, xMax), .32f, (Random.Range(zMin, zMax))),
                Quaternion.Euler(0, Random.Range(-90, 90), 0)); 

            treeCount++; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
