using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using UnityEngine.UI;
public class ObjectsInfo : MonoBehaviour
{

    public static ObjectsInfo Instance;
    /// <summary>
    /// 文本属性的
    /// </summary>
    
    /// <summary>
    /// 声明并实例化一个建为id，值为objectInfo的字典
    /// </summary>
    private Dictionary<int, ObjectInfo> objectInfoDict = new Dictionary<int, ObjectInfo>();
    void Awake()
    {
        //Debug.Log("objectsInfo");
        Instance = this;
        

        //print(objectInfoDict.Keys.Count);
    }
    void Start()
    {
    }

    void Update()
    {

    }

    public ObjectInfo GetObjectInfoById(int id)
    {
        ObjectInfo info = null;
        objectInfoDict.TryGetValue(id, out info);
        return info;
    }

   public void ReadInfo(TextAsset objectsInfoListText)
    {
        //获取文本中的字符串
        string text = objectsInfoListText.text;
        
        string[] strArray = text.Split('\n');

        foreach (string str in strArray)
        {
            string[] proArray = str.Split(',');
            ObjectInfo info = new ObjectInfo();

            int id = int.Parse(proArray[0]);
            string name = proArray[1];
            string icon_name = proArray[2];
            string str_type = proArray[3];

            info.id = id;
            info.name = name;
            info.icon_name = icon_name;

            ObjectType type = ObjectType.Drug;
            switch (str_type)
            {
                case "Drug":
                    type = ObjectType.Drug;
                    break;
                case "Equip":
                    type = ObjectType.Equip;
                    break;
                case "Mat":
                    type = ObjectType.Mat;
                    break;
            }

            info.type = type;

            if (type == ObjectType.Drug)
            {
                int hp = int.Parse(proArray[4]);
                int mp = int.Parse(proArray[5]);
                int price_sell = int.Parse(proArray[6]);
                int price_buy = int.Parse(proArray[7]);

                info.hp = hp;
                info.mp = mp;
                info.price_sell = price_sell;
                info.price_buy = price_buy;
            }
            else if (type == ObjectType.Equip)
            {
                int attack = int.Parse(proArray[4]);
                int def = int.Parse(proArray[5]);
                int speed = int.Parse(proArray[6]);
                int price_sell = int.Parse(proArray[9]);
                int price_buy = int.Parse(proArray[10]);

                string str_dressType = proArray[7];
                DressType dressType = DressType.Headgear;
                switch (str_dressType)
                {
                    case "Headgear":
                        dressType = DressType.Headgear;
                        break;
                    case "Armor":
                        dressType = DressType.Armor;
                        break;
                    case "RightHand":
                        dressType = DressType.RightHand;
                        break;
                    case "LeftHand":
                        dressType = DressType.LeftHand;
                        break;
                    case "Shoe":
                        dressType = DressType.Shoe;
                        break;
                    case "Accessory":
                        dressType = DressType.Accessory;
                        break;
                }
                string str_applicationType = proArray[8];
                ApplicationType applicationType = ApplicationType.Swordman;
                switch (str_applicationType)
                {
                    case "Swordman":
                        applicationType = ApplicationType.Swordman;
                        break;
                    case "Magician":
                        applicationType = ApplicationType.Magician;
                        break;
                    case "Common":
                        applicationType = ApplicationType.Common;
                        break;
                }

                info.attack = attack;
                info.def = def;
                info.speed = speed;
                info.price_buy = price_buy;
                info.price_sell = price_sell;

                info.dressType = dressType;
                info.applicationType = applicationType;
            }
            //向字典中添加一个objectInfo实例
            objectInfoDict.Add(id, info);
        }
    }
}
/// <summary>
/// 物品类型枚举
/// </summary>
public enum ObjectType
{
    Drug,
    Equip,
    Mat
}
public enum DressType
{
    Headgear,
    Armor,
    RightHand,
    LeftHand,
    Shoe,
    Accessory
}
public enum ApplicationType
{
    Swordman,
    Magician,
    Common
}

public class ObjectInfo
{
    public int id;
    public string name;
    public string icon_name;
    public ObjectType type;
    public int hp;
    public int mp;
    public int price_sell;
    public int price_buy;

    public int attack;
    public int def;
    public int speed;
    public DressType dressType;
    public ApplicationType applicationType;
}
