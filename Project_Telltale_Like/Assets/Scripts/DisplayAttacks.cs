using UnityEngine;
using System.Collections;

public class DisplayAttacks : MonoBehaviour {

	TurnManager tm;

	void OnEnable()
	{

		//tm = TurnManager.Instance();
		GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
		Player playerStats = playerObject.GetComponent<Player>();
		//TODO: delete this:
		playerStats.attacks[0] = playerStats.atdb.attackList[0];
		playerStats.attacks[1] = playerStats.atdb.attackList[1];
		playerStats.attacks[2] = playerStats.atdb.attackList[2];
		playerStats.attacks[3] = null; 
		int counter = 0;
		ModalPanel.Instance().EnableAllAttacks();

		foreach(Attack at in playerStats.attacks)
		{
			if(at != null)
				counter++;
		}
		for(int i = 0; i < counter; i++)
		{
			if(playerStats.attacks[i] != null)
			{
				if(playerStats.attacks[i].currentCooldown > 0)
					ModalPanel.Instance().DisableAttack(i);
			}
		}
		switch(counter)
		{
		case 0:
			//counter++;
			//playerStats.getBasicAttack
			Debug.Log("Error, no attacks could have been found");
			break;
		case 1:
			ModalPanel.Instance().Show (playerStats.attacks[0].attackName, ()=>{playerStats.Attack(0,tm);},()=>{Next();});
			break;
		case 2:
			ModalPanel.Instance().Show (playerStats.attacks[0].attackName, playerStats.attacks[1].attackName, ()=>{playerStats.Attack(0,tm);}, ()=>{playerStats.Attack(1,tm);}, ()=>{Next();});
			break;
		case 3:
			ModalPanel.Instance().Show (playerStats.attacks[0].attackName, playerStats.attacks[1].attackName, playerStats.attacks[2].attackName, ()=>{playerStats.Attack(0,tm);}, ()=>{playerStats.Attack(1,tm);}, ()=>{playerStats.Attack(2,tm);}, ()=>{Next();});
			break;
		case 4:
			ModalPanel.Instance().Show (playerStats.attacks[0].attackName, playerStats.attacks[1].attackName, playerStats.attacks[2].attackName, playerStats.attacks[3].attackName, ()=>{playerStats.Attack(0,tm);}, ()=>{playerStats.Attack(1,tm);}, ()=>{playerStats.Attack(2,tm);}, ()=>{playerStats.Attack(3,tm);}, ()=>{Next();});
			break;
		default:
			Debug.Log("Wrong amount of attacks");
			break;

		}
	}

	public void Next()
	{
		Debug.Log("Next ");
		//TODO: add turn manager
	}
}
