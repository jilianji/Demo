﻿
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
LRole = LCharatorBase:New()

local this = LRole;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
LRole.__index = LRole ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function LRole:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, LRole);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  LRole.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  LRole.Regist()

       this.msgIds = {
           CharactorChooseRoleEvents.Initial
       };

       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function LRole.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function LRole:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   LRole:GetResoures()

-- bundle 对应的名字
local bundle = {
    "Roles"
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    2
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { 
    "Magician_idle.prefab",
    "Swordman_idle.prefab"
    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    false,false,
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(LUILoadingEvent.Loading, "ChooseRole", bundle, resName, singles, numbers);



end 
--  执行 退出 消除逻辑
 function  LRole:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  LRole:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  LRole:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  LRole:Initial()
    


end



-- 这里面 就是做一些 事件的处理
function  LRole:ProcessEvent(msg)
    if msg.msgId == CharactorChooseRoleEvents.Initial then
        local tmpObj = msg:GetBundleRes("Roles", "Magician_idle.prefab");
        local tmpObj = msg:GetBundleRes("Roles", "Swordman_idle.prefab");

        --this:Ins
    end

end