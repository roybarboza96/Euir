using UnityEngine;
using System.Collections;

public class DTree : MonoBehaviour {


    DtreeNode[] allNodes;        //array of all nodes
    DtreeNode current_node;      //current node/scene

    void Start() {

        current_node = null;

    }


    void Update()
    {

        if (current_node != null)
        {

            if (current_node.change_state)
                current_node = current_node.get_next_state();

            if (current_node != null)
                Debug.Log("ERROR get_next_state returned NULL");


            current_node.act();
        }

    }



}
