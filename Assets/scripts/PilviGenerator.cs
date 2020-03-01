using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilviGenerator : MonoBehaviour
{
	public GameObject pilvi;
	List<GameObject> pilvet = new List<GameObject>();
	public Transform pelaaja;
	GameObject uusiPilvi;
	int kerroin = 0;
    	
	void Update()
    {
    	if(pilvet.Count<8)
    	{
    		uusiPilvi = Instantiate(pilvi);
    		uusiPilvi.transform.position = new Vector3(pelaaja.position.x+10*(kerroin%8+1)+Random.Range(5,10),7+Random.Range(0,4),0);
    		pilvet.Add(uusiPilvi);
    		kerroin += 1;
    	}
    	foreach(GameObject p in pilvet)
    	{
    		if(p == null)
    		{ 
    			pilvet.Remove(p);
    			break;
    		}
    		if (p.transform.position.x< pelaaja.position.x-10)
    		{
    			Destroy(p);
    			break;
    		}
    	}	
    }

    
}
