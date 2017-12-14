using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillItem : MonoBehaviour
{
    public int id;
    public SkillInfo info;
    private Image ItemImage;
    

    private GameObject icon_mask;

    private int level;

    void Awake()
    {
        ItemImage = transform.Find("ImageName").GetComponent<Image>();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.J))
        //{
        //    Debug.Log(info.name + " " + info.level);
        //}
    }


    public void SetId(int id, Object[] a, GameObject obj)
    {
        //Debug.Log(5);
        Text name = transform.Find("name").GetComponent<Text>();
        Text type = transform.Find("type").GetComponent<Text>();
        Text des = transform.Find("des").GetComponent<Text>();
        Text mp = transform.Find("mp").GetComponent<Text>();


        this.id = id;
        info = SkillsInfo.Instance.GetSkillInfoById(id);
        foreach (Object mage in a)
        {
            if (mage.name == info.icon_name)
            {
                ItemImage.sprite = mage as Sprite;
            }
        }

        switch (info.applyType)
        {
            case ApplyType.Passive:
                type.text = "增益";
                break;
            case ApplyType.Buff:
                type.text = "增强";
                break;
            case ApplyType.SingleTarget:
                type.text = "单体攻击";
                break;
            case ApplyType.MultiTarget:
                type.text = "范围伤害";
                break;
        }

        des.text = info.des;
        mp.text = info.mp + "MP";
       
    }

    //public void UpdateShow(int level)
    //{
    //    SkillInfo info = SkillsInfo.Instance.GetSkillInfoById(id);
    //    //Debug.Log(level);
    //    if (level >= info.level)
    //    {
    //        //Debug.Log("adasd");
    //        icon_mask.SetActive(false);
    //        iconNameSprite.GetComponent<SkillItemIcon>().enabled = true;
    //    }
    //    else
    //    {
    //        icon_mask.SetActive(true);
    //        iconNameSprite.GetComponent<SkillItemIcon>().enabled = false;
    //    }
    //    //level = info.level;
    //}
}
