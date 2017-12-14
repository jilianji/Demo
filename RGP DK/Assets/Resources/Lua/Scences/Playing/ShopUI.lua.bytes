
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
ShopUI = LUIBase:New()

local this = ShopUI;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
ShopUI.__index = ShopUI ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function ShopUI:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, ShopUI);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  ShopUI.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  ShopUI.Regist()

         this.msgIds = {
            UISumEvents.ShopInitial
       };

       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function ShopUI.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function ShopUI:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   ShopUI:GetResoures()

-- bundle 对应的名字
local bundle = {
    "ShopUI",
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    2
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { "Item.prefab",
"weaponBg.prefab"
    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    true,true,
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(UISumEvents.ShopInitial, "Playing", bundle, resName, singles, numbers);



end 

this:GetResoures()

--  执行 退出 消除逻辑
 function  ShopUI:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  ShopUI:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  ShopUI:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  ShopUI:Initial()
    


end



-- 这里面 就是做一些 事件的处理
function  ShopUI:ProcessEvent(msg)
       if msg.msgId==UISumEvents.ShopInitial   then 
       
         local  weaponBgtmpObj = msg:GetBundleRes("ShopUI", "weaponBg.prefab");

         this.weaponBgObject = this: InstantiatePlaneGameObje(weaponBgtmpObj[0])

--         this.contentT=this:GetTransform("Content")--获取Content(需要在下面添加Item)
         this.contentT=this:GetGameObject("weaponBg","Content")

         this.numberT=this:GetTransform("NumberAndBuy")--获取需要买装备个数的输入框，不用时需要隐藏
         
         this.LoginScript = this.weaponBgObject:AddComponent(typeof(ShopWeapon))
         this:AddButtonLisenter("BuyOK",this.BuyOK)
         this:AddButtonLisenter("Close",this.OnClose)


         this.numberT.gameObject:SetActive(false)--初始化先设为false


         local itemObj = msg:GetBundleRes("ShopUI", "Item.prefab");

         
         for i=2001,2022,1 do
        this.itemm= this: InstantiatePlaneGameObje(itemObj[0])
        this.ItemScript = this.itemm:AddComponent(typeof(ShopWeaponItem))
        this.itemm.transform:SetParent(this.contentT.transform)
        this.ItemScript:SetId(i, LogTextures.image,this.itemm);
         this:AddButtonLisenter("Buys",this.Buys)
         
         
         end
         










end


       

end

function  ShopUI:Buys ()
this.numberT.gameObject:SetActive(true)

end 

function  ShopUI:BuyOK ()
this.numberT.gameObject:SetActive(false)


end 


function  ShopUI:OnClose ()
this.weaponBgObject:SetActive(false)


end 
