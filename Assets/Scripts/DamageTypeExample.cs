using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample : MonoBehaviour
{
    // Start is called before the first frame update

    public enum DAMAGE_TYPE
    {
        SLASHING,
        PIERCING,
        BLUDGEONING,
        MAGICAL,
        FORCE
    }

    public DAMAGE_TYPE attackType;
    public DAMAGE_TYPE resistence;
    public DAMAGE_TYPE weakness;
    public int baseDamage;

    string DanniInflitti (ref int  damage, DAMAGE_TYPE attackType, DAMAGE_TYPE resistence, DAMAGE_TYPE weakness)
    {
        if (attackType == resistence && attackType == weakness)
        {
            damage = 0;
            return ("errore! resistenza e debolezza sono uguali");
        }
        else if (attackType == resistence)
        {
            damage /= 2;
            return ("il nemico è resistente al danno");
        }
        else if (attackType == weakness)
        {
            damage *= 2;
            return ("il nemico è debole contro questo danno");
        }
        else
        {
            return ("il nemico reagisce normalmente al danno");
        }
    }
    void Start()
    {
        string a = DanniInflitti(ref baseDamage, attackType, resistence, weakness);

        Debug.Log(a);

        Debug.Log("il danno inflitto è " + baseDamage);

     
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
