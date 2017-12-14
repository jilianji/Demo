
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
NPC = LNPCBase:New()

local this = NPC;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
NPC.__index = NPC ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function NPC:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, NPC);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  NPC.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  NPC.Regist()

         this.msgIds = {
        DrugEvents.Initia
       };

       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function NPC.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function NPC:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   NPC:GetResoures()

-- bundle 对应的名字
local bundle = {
   "NPC"
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    3
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { "Bar_NPC.prefab",
"Potion_Npc.prefab","Weapon_Npc.prefab"
    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    false,false,false
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(DrugEvents.Initia, "Playing", bundle, resName, singles, numbers);



end 
this:GetResoures()
--  执行 退出 消除逻辑
 function  NPC:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  NPC:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  NPC:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  NPC:Initial()
    


end



-- 这里面 就是做一些 事件的处理
function  NPC:ProcessEvent(msg)


              if   msg.msgId  ==   DrugEvents.Initia  then
              local  BartmpObj = msg:GetBundleRes("NPC", "Bar_NPC.prefab");
              this.Obj1=GameObject.Instantiate(BartmpObj[0])
              this.Obj1:AddComponent(typeof(NNPPCC))
 

              local  PotiontmpObj = msg:GetBundleRes("NPC", "Potion_Npc.prefab");
              this.Obj2=GameObject.Instantiate(PotiontmpObj[0])
              this.Obj2:AddComponent(typeof(NNPPCC))

              local  WeapontmpObj = msg:GetBundleRes("NPC", "Weapon_Npc.prefab");
              this.Obj3=GameObject.Instantiate(WeapontmpObj[0])
              this.Obj3:AddComponent(typeof(NNPPCC))

              end

end