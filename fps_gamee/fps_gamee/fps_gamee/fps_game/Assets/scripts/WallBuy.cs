using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuy : MonoBehaviour
{
    public int price = 500;
    public GameObject score;
    public GameObject Weapon;

   // private WeaponSystem weaponsys;
    private ScoreManager scoremng;

    private void Start()
    {
        //weaponsys = Weapon.GetComponent<WeaponSystem>();
        scoremng = score.GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider wallbuy)
    {
        if (wallbuy.tag == "Player")
        {
            Debug.Log("Test");

            if (scoremng.GetComponent<ScoreManager>().curScore >= price)
                scoremng.subtractScore(price);
            //if (weaponsys.GetComponent<WeaponSystem>() != null)
               // weaponsys.GetComponent<WeaponSystem>().SetActiveWeapon(gameObject);
        }
    }
}