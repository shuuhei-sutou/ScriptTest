using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
/*    private int hp = 100;
    private int power = 25;

    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        this.hp -= damage;
    }
    */
}

public class Test : MonoBehaviour {
    
    // Use this for initialization
    void Start()
    {
 /*       Boss lastboss = new Boss();
        Boss midboss = new Boss();

        lastboss.Attack();
        lastboss.Defence(3);

        lastboss.Attack();
        lastboss.Defence(100);
        */
        int[] array = { 30, 20, 50, 10, 80 };
        int[] array2 = { 0, 0, 0, 0, 0};
        for (int i = 0; i < 5; i++){
            Debug.Log(array[i]);
        }
        Debug.Log("順番に表示終了");

        for (int i = 0; i < 5; i++)
        {
            array2[i] = array[4 - i];
            Debug.Log(array2[i]);
        }

    }
	// Update is called once per frame
	void Update () {
		
	}
}
