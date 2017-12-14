using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopWeapon : MonoBehaviour
{
    public static ShopWeapon Instance;
    public int[] weaponIdArray;
    private int buyId = 0;
    void Awake () {
        weaponIdArray = new int[22];
        int j = 2001;
        for (int i = 0; i < 22; i++) {
            weaponIdArray[i] = j;
            j++;
        }
	}
	

    
    public  void Instan(GameObject item,GameObject partent,Object []a) {

        foreach (int id in weaponIdArray)
        {

            GameObject Item = GameObject.Instantiate(item);
            Item.transform.SetParent(partent.transform);

            Item.AddComponent<ShopWeaponItem>().SetId(id, a, Item);

    }

}


}
