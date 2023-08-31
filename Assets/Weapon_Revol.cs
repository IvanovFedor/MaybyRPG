using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_Revol : MonoBehaviour
{
    [SerializeField] private Animator animatorRevol;
    private bool canShoot = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && canShoot)
        {
            StartCoroutine(LKMShot());
            canShoot = false;
        }
        else if (Input.GetMouseButtonDown(1) && canShoot)
        {
            StartCoroutine(PKMShot());
            canShoot = false;
        }
        else if(Input.GetKeyDown(KeyCode.R) && canShoot)
        {
            StartCoroutine(Reload());
            canShoot = false;
        }
    }

    IEnumerator PKMShot()
    {
        animatorRevol.SetInteger("Stage", 2);
        yield return new WaitForSeconds(1f);
        animatorRevol.SetInteger("Stage", 0);
        canShoot = true;
    }

    IEnumerator LKMShot()
    {
        animatorRevol.SetInteger("Stage", 1);
        yield return new WaitForSeconds(0.15f);
        animatorRevol.SetInteger("Stage", 0);
        canShoot = true;
    }

    IEnumerator Reload()
    {
        animatorRevol.SetInteger("Stage", 3);
        yield return new WaitForSeconds(3f);
        animatorRevol.SetInteger("Stage", 0);
        canShoot = true;
    }
}
