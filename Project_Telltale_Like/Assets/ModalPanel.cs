using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;

public class ModalPanel : MonoBehaviour {

	//easy access to all items plox
	//public Text chat;


	public Button ButtonOne;
	public Button ButtonTwo;
	public Button ButtonThree;
	public Button ButtonFour;
	public GameObject menuObject; //The panel that displays the buttons/text

	
	private static ModalPanel modalPanel;


	public static ModalPanel Instance(){
		if(!modalPanel){
			modalPanel =FindObjectOfType(typeof (ModalPanel)) as ModalPanel;
			//maybe I could use two instances methods- or one that gets two parameters
			//they will find a component in the child of the object, indicating if it's an npc attached component
			//also this method will sort through all of the conversation windows
		}
		if(!modalPanel)
			Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in my scene");
	return modalPanel;
	}



	public void Show (string buttonText1, UnityAction eventOne, UnityAction next) {

		ButtonOne.onClick.RemoveAllListeners();

		ButtonOne.onClick.AddListener (eventOne);
		ButtonOne.onClick.AddListener (next);
		ButtonOne.onClick.AddListener (turnOff);

		ButtonTwo.onClick.RemoveAllListeners();
		
		ButtonThree.onClick.RemoveAllListeners();
	
		ButtonOne.gameObject.SetActive (true);
		ButtonTwo.gameObject.SetActive (false);
		ButtonThree.gameObject.SetActive (false); 
		ButtonFour.gameObject.SetActive (false); 


		Text t1=ButtonOne.GetComponentInChildren<Text>();
		t1.text=buttonText1;

		//setting the buttons to active
		//ButtonOne.gameObject.SetActive (true);
		//ButtonTwo.gameObject.SetActive (false);
		//ButtonThree.gameObject.SetActive (false);
	}

	public void Show (string buttonText1, string buttonText2, UnityAction eventOne, UnityAction eventTwo , UnityAction next) {
		ButtonOne.onClick.RemoveAllListeners();
		ButtonOne.onClick.AddListener (eventOne);
		ButtonOne.onClick.AddListener (next);
		ButtonOne.onClick.AddListener (turnOff);

		ButtonTwo.onClick.RemoveAllListeners();
		ButtonTwo.onClick.AddListener (eventTwo);
		ButtonTwo.onClick.AddListener (next);
		ButtonTwo.onClick.AddListener (turnOff);

		ButtonThree.onClick.RemoveAllListeners();

		ButtonOne.gameObject.SetActive (true);
		ButtonTwo.gameObject.SetActive (true);
		ButtonThree.gameObject.SetActive (false);
		ButtonFour.gameObject.SetActive (false); 

		Text t1=ButtonOne.transform.GetComponentInChildren<Text>();
		t1.text=buttonText1;
		Text t2=ButtonTwo.transform.GetComponentInChildren<Text>();
		t2.text=buttonText2;

		
		//setting the buttons to active
		//ButtonOne.gameObject.SetActive (true);
		//ButtonTwo.gameObject.SetActive (true);
		//ButtonThree.gameObject.SetActive (false);
	}

	public void Show (string buttonText1, string buttonText2, string buttonText3, UnityAction eventOne, UnityAction eventTwo, UnityAction eventThree , UnityAction next) {

		ButtonOne.onClick.RemoveAllListeners();

		ButtonOne.onClick.AddListener (eventOne);
		ButtonOne.onClick.AddListener (next);
		ButtonOne.onClick.AddListener (turnOff);

		ButtonTwo.onClick.RemoveAllListeners();

		ButtonTwo.onClick.AddListener (eventTwo);
		ButtonTwo.onClick.AddListener (next);
		ButtonTwo.onClick.AddListener (turnOff);

		ButtonThree.onClick.RemoveAllListeners();

		ButtonThree.onClick.AddListener (eventThree);
		ButtonThree.onClick.AddListener (next);
		ButtonThree.onClick.AddListener (turnOff);

		ButtonOne.gameObject.SetActive (true);
		ButtonTwo.gameObject.SetActive (true);
		ButtonThree.gameObject.SetActive (true);
		ButtonFour.gameObject.SetActive (false);

		Text t1=ButtonOne.transform.GetComponentInChildren<Text>();
		t1.text=buttonText1;
		Text t2=ButtonTwo.transform.GetComponentInChildren<Text>();
		t2.text=buttonText2;
		Text t3=ButtonThree.transform.GetComponentInChildren<Text>();
		t3.text=buttonText3;
		//setting the buttons to active
		//ButtonOne.gameObject.SetActive (true);
		//ButtonTwo.gameObject.SetActive (true);
		//ButtonThree.gameObject.SetActive (true);
	}

	public void Show (string buttonText1, string buttonText2, string buttonText3, string buttonText4, UnityAction eventOne, UnityAction eventTwo, UnityAction eventThree, UnityAction eventFour , UnityAction next) {
		
		ButtonOne.onClick.RemoveAllListeners();
		
		ButtonOne.onClick.AddListener (eventOne);
		ButtonOne.onClick.AddListener (next);
		ButtonOne.onClick.AddListener (turnOff);
		
		ButtonTwo.onClick.RemoveAllListeners();
		
		ButtonTwo.onClick.AddListener (eventTwo);
		ButtonTwo.onClick.AddListener (next);
		ButtonTwo.onClick.AddListener (turnOff);
		
		ButtonThree.onClick.RemoveAllListeners();
		
		ButtonThree.onClick.AddListener (eventThree);
		ButtonThree.onClick.AddListener (next);
		ButtonThree.onClick.AddListener (turnOff);

		
		ButtonThree.onClick.RemoveAllListeners();
		
		ButtonThree.onClick.AddListener (eventFour);
		ButtonThree.onClick.AddListener (next);
		ButtonThree.onClick.AddListener (turnOff);
		
		ButtonOne.gameObject.SetActive (true);
		ButtonTwo.gameObject.SetActive (true);
		ButtonThree.gameObject.SetActive (true);
		ButtonFour.gameObject.SetActive (true);

		Text t1=ButtonOne.transform.GetComponentInChildren<Text>();
		t1.text=buttonText1;
		Text t2=ButtonTwo.transform.GetComponentInChildren<Text>();
		t2.text=buttonText2;
		Text t3=ButtonThree.transform.GetComponentInChildren<Text>();
		t3.text=buttonText3;
		Text t4=ButtonFour.transform.GetComponentInChildren<Text>();
		t4.text=buttonText4;
		//setting the buttons to active
		//ButtonOne.gameObject.SetActive (true);
		//ButtonTwo.gameObject.SetActive (true);
		//ButtonThree.gameObject.SetActive (true);
	}

	public void DisableAttack(int i)
	{
		switch(i)
		{
		case 0:
			ButtonOne.interactable = false;
			break;
		case 1:
			ButtonTwo.interactable = false;
			break;
		case 2:
			ButtonThree.interactable = false;
			break;
		case 3:
			ButtonFour.interactable = false;
			break;
		}
	}

	public void EnableAllAttacks()
	{
		ButtonOne.interactable = true;
		ButtonTwo.interactable = true;
		ButtonThree.interactable = true;
		ButtonFour.interactable = true;
	}
	

	public void turnOff(){
		menuObject.SetActive (false);
	}
	public bool getActive(){
		return menuObject.activeSelf;
	}
	/*
	//Probably won't be used
	public void setFont(Font f){
		if(f==null)Debug.LogError("No font!!!");
		else chat.font=f;
	}
*/
}
