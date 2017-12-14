using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsInfo : MonoBehaviour
{
    public static SkillsInfo Instance;



    private Dictionary<int, SkillInfo> skillInfoDict = new Dictionary<int, SkillInfo>();

    void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public SkillInfo GetSkillInfoById(int id)
    {
        SkillInfo info = null;
        skillInfoDict.TryGetValue(id, out info);
        return info;
    }

    /// <summary>
    /// 初始化技能信息字典
    /// </summary>
    void InitSkillInfoDict()
    {

    }

    public void ReadSkillInfo(TextAsset skillsInfoText)
    {
        string text = skillsInfoText.text;
        string[] strArray = text.Split('\n');

        foreach (string str in strArray)
        {
            string[] proArray = str.Split(',');
            SkillInfo info = new SkillInfo();

            int id = int.Parse(proArray[0]);
            string name = proArray[1];
            string icon_name = proArray[2];
            string des = proArray[3];
            info.id = id;
            info.name = name;
            info.icon_name = icon_name;
            info.des = des;

            string str_applyType = proArray[4];
            ApplyType applyType = ApplyType.Buff;
            switch (str_applyType)
            {
                case "Buff":
                    applyType = ApplyType.Buff;
                    break;
                case "Passive":
                    applyType = ApplyType.Passive;
                    break;
                case "SingleTarget":
                    applyType = ApplyType.SingleTarget;
                    break;
                case "MultiTarget":
                    applyType = ApplyType.MultiTarget;
                    break;
            }
            info.applyType = applyType;

            string str_applyProperty = proArray[5];
            ApplyProperty applyPorperty = ApplyProperty.Attack;
            switch (str_applyProperty)
            {
                case "Attack":
                    applyPorperty = ApplyProperty.Attack;
                    break;
                case "Def":
                    applyPorperty = ApplyProperty.Def;
                    break;
                case "Speed":
                    applyPorperty = ApplyProperty.Speed;
                    break;
                case "AttackSpeed":
                    applyPorperty = ApplyProperty.AttackSpeed;
                    break;
                case "HP":
                    applyPorperty = ApplyProperty.HP;
                    break;
                case "MP":
                    applyPorperty = ApplyProperty.MP;
                    break;
            }
            info.applyProperty = applyPorperty;

            int applyValue = int.Parse(proArray[6]);
            int applyTime = int.Parse(proArray[7]);
            int mp = int.Parse(proArray[8]);
            int cooldown = int.Parse(proArray[9]);
            info.applyValue = applyValue;
            info.applyTime = applyTime;
            info.mp = mp;
            info.cooldown = cooldown;

            string str_applicationRole = proArray[10];
            ApplicationRole applicationRole = ApplicationRole.Magician;
            switch (str_applicationRole)
            {
                case "Magician":
                    applicationRole = ApplicationRole.Magician;
                    break;
                case "Swordman":
                    applicationRole = ApplicationRole.Swordman;
                    break;
            }
            info.applicationRole = applicationRole;

            int level = int.Parse(proArray[11]);
            info.level = level;

            string str_releaseType = proArray[12];
            ReleaseType releaseType = ReleaseType.Enemy;
            switch (str_releaseType)
            {
                case "Enemy":
                    releaseType = ReleaseType.Enemy;
                    break;
                case "Self":
                    releaseType = ReleaseType.Self;
                    break;
                case "Position":
                    releaseType = ReleaseType.Position;
                    break;
            }
            info.releaseType = releaseType;

            float distance = float.Parse(proArray[13]);
            string effectName = proArray[14];
            string animationName = proArray[15];
            float animationTime = float.Parse(proArray[16]);

            info.distance = distance;
            info.effectName = effectName;
            info.animationName = animationName;
            info.animationTime = animationTime;


            
            skillInfoDict.Add(id, info);
        }
    }
}
/// <summary>
/// 适用角色
/// </summary>
public enum ApplicationRole
{
    Swordman,
    Magician
}
/// <summary>
/// 作用类型
/// </summary>
public enum ApplyType
{
    Passive,
    Buff,
    SingleTarget,
    MultiTarget
}
/// <summary>
/// 作用属性
/// </summary>
public enum ApplyProperty
{
    Attack,
    Def,
    Speed,
    AttackSpeed,
    HP,
    MP
}
/// <summary>
/// 释放类型
/// </summary>
public enum ReleaseType
{
    Self,
    Enemy,
    Position
}
/// <summary>
/// 技能
/// </summary>
public class SkillInfo
{
    public int id;
    public string name;
    public string icon_name;
    public string des;
    public ApplyType applyType;
    public ApplyProperty applyProperty;
    public int applyValue;
    public int applyTime;
    public int mp;
    public int cooldown;
    public ApplicationRole applicationRole;
    public int level;
    public ReleaseType releaseType;
    public float distance;
    public string effectName;
    public string animationName;
    public float animationTime = 0;
}

