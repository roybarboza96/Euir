using UnityEngine;
using System.Collections;


/// <summary>
/// This is a generic action datatype. Action datatype are just like what they
/// say. They have specific type that can refer to "dialog", "move", "internal"
/// </summary>
public class Action {



    public string actionType;      //string to identify what type of action this is
    public bool done;              //boolean to tell whether the action is done

    public Action()
    {
        actionType = null;
        done = false;

    }

    //do this particular action
    public virtual void act()
    {

    }






}
