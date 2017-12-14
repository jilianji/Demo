require "Scences.ChooseRole.LChooseRoleStr"

--声明，这里声明了类名还有属性，并且给出了属性的初始值。
LChooseRole = LUIBase:New()

local this = LChooseRole;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
LChooseRole.__index = LChooseRole ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function LChooseRole:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, LChooseRole);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  LChooseRole.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  LChooseRole.Regist()

       this.msgIds = {
           UIChooseRoleEvents.Initial,
           UIChooseRoleEvents.GetResources,
           RolesEvents.PrevBtn,
           RolesEvents.NextBtn
       };
       print("UIChooseRoleEvents.GetResources");
       this:RegistSelf(this,this.msgIds);
       LChooseRoleStr:SettingParent(this);
end 


this.Regist();




function LChooseRole.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function LChooseRole:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   LChooseRole:GetResoures()

-- bundle 对应的名字
local bundle = {
    "CharacterCreation"
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {
    1
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { 
    "CharacterPanel.prefab",
    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    false
};



--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(UIChooseRoleEvents.Initial, "ChooseRole", bundle, resName, singles, numbers);

--this:GetMutiBundlAndRes(UIChooseRoleEvents.GetResources, "ChooseRole", bundle, resName2, singles2, numbers);



end 


--  执行 退出 消除逻辑
 function  LChooseRole:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  LChooseRole:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  LChooseRole:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  LChooseRole:Initial()
    


end




-- 这里面 就是做一些 事件的处理
function  LChooseRole:ProcessEvent(msg)
    if msg.msgId == UIChooseRoleEvents.GetResources then
        this:GetResoures();
    
    elseif msg.msgId == UIChooseRoleEvents.Initial then
        local tmpObj = msg:GetBundleRes("CharacterCreation", "CharacterPanel.prefab");        
        this.Object = this:InstantiatePlaneGameObje(tmpObj[0]);

        this.reminder = this:GetText("reminder");
        this.reminder.gameObject:SetActive(false);

        this.ChooseRole = this.Object:AddComponent(typeof(ChooseRoleStr))
        this:AddInputFiledLisenter("NameInput", LChooseRoleStr.NameInput, LChooseRoleStr.NameInputEnd);

        this:AddButtonLisenter("prevBtn", LChooseRoleStr.PrevBtnPress);
        this:AddButtonLisenter("nextBtn", LChooseRoleStr.NextBtnPress);
        this:AddButtonLisenter("acceptBtn", LChooseRoleStr.AcceptBtnPress);        
    end
end