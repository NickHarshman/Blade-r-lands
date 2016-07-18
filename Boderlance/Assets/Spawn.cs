using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    private Transform point;
    private float rng;
    public GameObject item;
    public GameObject money;
    public GameObject common;
    public GameObject uncommon;
    public GameObject rare;
    public GameObject veryrare;
    public GameObject legendary;
    // Use this for initialization
    void Start () {
        point = GetComponent<Transform>();
        InvokeRepeating("Loot", .2f, .2f);
	}
	
	// Update is called once per frame
	void Loot()
    {
        rng = Random.Range(0f, 1f);
        if(rng<.3f)
        {
            Instantiate(item, point.position, point.rotation);
        }
        else
        {
            if(rng<.6f)
            {
                Instantiate(money, point.position, point.rotation);
            }
            else
            {
                if(rng<.8f)
                {
                    Instantiate(common, point.position, point.rotation);
                }
                else
                {
                    if(rng<.9f)
                    {
                        Instantiate(uncommon, point.position, point.rotation);
                    }
                    else
                        if(rng<.95f)
                    {
                        Instantiate(rare, point.position, point.rotation);
                    }
                    else
                    {
                        if(rng<.98f)
                        {
                            Instantiate(veryrare, point.position, point.rotation);
                        }
                        else
                        {
                            Instantiate(legendary, point.position, point.rotation);
                        }
                    }
                }
            }
        }
    }
}
