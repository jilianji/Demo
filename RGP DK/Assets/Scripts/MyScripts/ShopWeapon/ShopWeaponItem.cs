
using System.Collections;
using System.Collections.Generic;
using U3DEventFrame;
using UnityEngine;
using UnityEngine.UI;
public class ShopWeaponItem : MonoBehaviour {
    private int id;
    private ObjectInfo info;
    private Image ItemImage;
   
    
    void Awake () {
        
        ItemImage = transform.Find("Imagename").GetComponent<Image>();
    }
	
	
	void Update () {
		
	}
    public void SetId(int id, Object[]a, GameObject obj)
    {
        Text name = transform.Find("name").GetComponent<Text>();
        Text effect = transform.Find("effect").GetComponent<Text>();
        Text price = transform.Find("price").GetComponent<Text>();
        this.id = id;

        info = ObjectsInfo.Instance.GetObjectInfoById(id);


        foreach (Object mage in a) {
            if (mage.name == info.icon_name) {


                ItemImage.sprite = mage as Sprite;
                
            }

        }

        

        name.text = info.name;
        

        if (info.attack > 0)
        {
            effect.text = "攻： " + info.attack;
        }
        else if (info.def > 0)
        {
            effect.text = "防： " + info.def;
        }
        else
        {
            effect.text = "速： " + info.speed;
        }
        price.text = "$" + info.price_buy;
    }

}
