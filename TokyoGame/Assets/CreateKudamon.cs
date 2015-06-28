using UnityEngine;
using System.Collections;

public class CreateKudamon : MonoBehaviour {

    private GameObject[] Createnumber;
    private Vector3[] pos;
    [SerializeField]
    GameObject Kudamon;
    HandController hand_controller_ = null;

    void Awake()
    {
        //Kudamon = GameObject.Find("Kudamon1");
        Createnumber = new GameObject[100];
        pos = new Vector3[100];

    }

	void Start () 
    {
        Create();
        hand_controller_ = GameObject.Find("HandController").GetComponent<HandController>();
	}
	
	void Update () 
    {
        if (hand_controller_.isAttack)
        {
            for (int i = 0; i < 5; ++i)
            {
                pos[i].x = Random.Range(-20, 20);
                pos[i].y = Random.Range(15, 25);
                pos[i].z = Random.Range(-20, 15);
                Createnumber[i] = GameObject.Instantiate(Kudamon, pos[i], Quaternion.identity) as GameObject;
            }
        }
	}

    void Create()
    {
       for(int i = 0; i < 100; ++i)
       {
           pos[i].x = Random.Range(-20, 20);
           pos[i].y = Random.Range(15, 25);
           pos[i].z = Random.Range(-20, 15);
//  Createnumber[i] = GameObject.Instantiate(Kudamon, pos[i], Quaternion.identity)as GameObject;
           Createnumber[i] = GameObject.Instantiate(Kudamon, pos[i], Quaternion.identity) as GameObject;


       }
    }
}
