using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{

    public static string voiceRec = "";



    // Start is called before the first frame update
    void Start() 
    {

    }
    // Update is called once per frame
    void Update()
    {
        //check to ee if player is shooting
        CheckForShooting();
    }
    //checks to see if player is shooting
    private  void CheckForShooting()
    {
        if (voiceRec == "fire")
        {
            RaycastHit whatIHit;
            if (Physics.Raycast(transform.position, transform.forward, out whatIHit, Mathf.Infinity))
            { 
              
                IDamageable damageable = whatIHit.collider.GetComponent<IDamageable>();
                if (damageable !=null ) {
                    damageable.DealDamage(10);
                    voiceRec = "";
                }
            }
        }
    }
}
