using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourTree : Node
{
    // Start is called before the first frame update
    public BehaviourTree()
    {
        name = "Tree";
    }

    // Update is called once per frame
    public BehaviourTree(string n)
    {
        name = n;
    }

    public void PrintTree()
    {

    }
}
