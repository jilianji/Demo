--region *.lua
--Date
--此文件由[BabeLua]插件自动生成



--endregion



--声明，这里声明了类名还有属性，并且给出了属性的初始值。
LChooseRoleStr =  {}

local this = LChooseRoleStr;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
LChooseRoleStr.__index = LChooseRoleStr;



--构造体，构造体的名字是随便起的，习惯性改为New()
function LChooseRoleStr:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, LChooseRoleStr);  --将self的元表设定为Class   
    return self;    --返回自身
end



function  LChooseRoleStr:SettingRegistObj( tmpObj)


     this.registObj =  tmpObj ;

end  


function  LChooseRoleStr:SettingParent( tmpObj)
     this.loadingParent =  tmpObj ;
end  
 


function  LChooseRoleStr.RegistBtnPress()

          print(" LChooseRoleStr.RegistBtnPress");

          this.loadingParent:InstantiatePlaneGameObje( this.registObj )
end 
--点击prev按钮
function LChooseRoleStr.PrevBtnPress()
    --this.LoginScript = this.Object:AddComponent(typeof(LoginSq))

    print(RolesEvents.PrevBtn);
    local testMsg = MsgBase.New(tonumber(RolesEvents.PrevBtn));
    LUIBase:SendMsg(testMsg);


end
--点击next按钮
function LChooseRoleStr.NextBtnPress()
    print(RolesEvents.NextBtn);
    local testMsg = MsgBase.New(tonumber(RolesEvents.NextBtn));
    LUIBase:SendMsg(testMsg);
end
--点击accept按钮
function LChooseRoleStr.AcceptBtnPress()
    --print("点击accept");
    local testMsg = MsgBase.New(tonumber(RolesEvents.AcceptBtn));
    LUIBase:SendMsg(testMsg);
    if this.userName == nil or this.userName == "" then
        this.userName = "null";
        this.loadingParent.ChooseRole:OnOkButtonClick(this.loadingParent.reminder, this.userName);        
    else
        this.loadingParent.ChooseRole:OnOkButtonClick(this.loadingParent.reminder, this.userName);
    end
end

--用户名输入参数
function   LChooseRoleStr.NameInput (obj,bb)
    --print("input start !!");
end
function   LChooseRoleStr.NameInputEnd (aa,userName)
    this.userName = userName
end