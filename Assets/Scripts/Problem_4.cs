using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    //Connect this Script to Game Object Named Part_4,get the Transfom component
    //of Part_4, Part_4_Child using either transform.Get or transform.Find and the
    //transfrom of Part_4_GameObject using GameObject.Find
    //Using transform.name pass the name and position values of each of the Game Objects
    //to PrintOutNameAndPosition. 
    //You should have the results of Part_4, 0,0,0, Part_4_Child -5,-5,-5 and Part_4_GameObject, 5,5,5

    private Transform _transform; 
    private Transform _tranform; 
    private Transform _transfrom;

    void Start()
    {
        _transform = GameObject.Find("Part_4").GetComponent<Transform>();
        _tranform = transform.GetChild(0).GetComponent<Transform>();
        _transfrom = GameObject.Find("Part_4_GameObject").GetComponent<Transform>();

        PrintOutNameAndPosition(_transform.name, _transform.position);
        PrintOutNameAndPosition(_tranform.name, _tranform.position);
        PrintOutNameAndPosition(_transfrom.name, _transfrom.position);

    }

    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
