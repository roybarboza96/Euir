using UnityEngine;
using System.Collections;

public class DtreeNode {




    public int id;                  //id of DtreeNode
    public DtreeNode[] children;    //children of DtreeNode


    public bool change_state;       //flag to indicate to move to next state
    private DtreeNode next_state;   //DtreeNode of the next state
                                    //Note that this will be only be set when change_state
                                    //is true

    
    //Arrays and indicies of all action for this nodes
    //The actions in the array should be in chronological order
    private int move_index;
    private MoveAction current_move;
    private MoveAction[] move_actions;

    private int dialog_index;
    private DialogAction current_dialog;
    private DialogAction[] dialog_actions;

    private int internal_index;
    private InternalAction current_internal;
    private InternalAction[] internal_actions;


    public DtreeNode()
    {


        change_state = false;
        next_state = null;
    }


    public DtreeNode get_next_state() { return next_state; }


    //public function that acts out scene
    //the function will just call the three different types
    //of act function
    //Do this to organize the code and also helps make testing easier
    public void act()
    {
        physicalAct();
        verbalAct();
        internalAct();
        check_next_state();


    }

    public void initialize(MoveAction[] move_actions, DialogAction[] dialog_actions, InternalAction[] internal_actions)
    {
        move_index = 0;
        this.move_actions = move_actions;
        current_move = move_actions[move_index];

        dialog_index = 0;
        this.dialog_actions = dialog_actions;
        current_dialog = dialog_actions[dialog_index];


        internal_index = 0;
        this.internal_actions = internal_actions;
        current_internal = internal_actions[internal_index];

    }


    //Any physcal movement will be done here 
    private void physicalAct()
    {
        if (current_move == null)
            return;

    }

    //Any verbal actions will be done here
    private void verbalAct()
    {
        if (current_dialog == null)
            return;

    }

    //Any changes made to the system will be done here
    private void internalAct()
    {
        if (current_internal == null)
            return;
    }


    //function to check if transitioning to next state
    //if moving to next state change_state will be set to true
    //and next_state will not be null
    private void check_next_state()
    {


    }









}
