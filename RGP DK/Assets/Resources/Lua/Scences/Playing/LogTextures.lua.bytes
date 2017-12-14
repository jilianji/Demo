
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
LogTextures = LUIBase:New()

local this = LogTextures;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
LogTextures.__index = LogTextures ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function LogTextures:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, LogTextures);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  LogTextures.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  LogTextures.Regist()

         this.msgIds = {
         UISumEvents.TXT
       };

       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function LogTextures.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function LogTextures:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   LogTextures:GetResoures()

-- bundle 对应的名字
local bundle = {
    "Textures",
};
print("+++++++++++++++++++++++++++++++++++++");

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    3
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { "ObjectsInfoList.txt","SkillsInfoList.txt",
"State"
    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    true,true,false
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(UISumEvents.TXT, "Playing", bundle, resName, singles, numbers);



end 


this:GetResoures()

--  执行 退出 消除逻辑
 function  LogTextures:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  LogTextures:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  LogTextures:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  LogTextures:Initial()
    


end



-- 这里面 就是做一些 事件的处理
function  LogTextures:ProcessEvent(msg)
            if msg.msgId==UISumEvents.TXT then
            local  TxtObj = msg:GetBundleRes("Textures", "ObjectsInfoList.txt");
            local txt = TextAsset.New()
            txt=TxtObj[0]
            ObjectsInfo.Instance:ReadInfo(txt)


            local TxtSkill = msg:GetBundleRes("Textures", "SkillsInfoList.txt");
            local  txT = TextAsset.New()
            txT=TxtSkill[0]
            
            SkillsInfo.Instance:ReadSkillInfo(txT)



            local  ImgtObj = msg:GetBundleRes("Textures", "State");
            LogTextures.image=ImgtObj
           

            
            end

end