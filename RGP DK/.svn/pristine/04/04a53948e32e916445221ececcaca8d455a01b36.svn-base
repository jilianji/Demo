
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
Signin = LUIBase:New()

local this = Signin;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
Signin.__index = Signin ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function Signin:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, Signin);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  Signin.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  Signin.Regist()

         this.msgIds = {
            UISigninEvents.Initia,
            UISigninEvents.Signin,
            UIEnterGameCommonEvents.SigninExit,
            UIChooseRoleEvents.SigninProgressLoad,
            UIChooseRoleEvents.GetResources
       };

       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function Signin.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function Signin:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   Signin:GetResoures()

-- bundle 对应的名字
local bundle = {
    "Signin",
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    1,
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { "Signin.prefab",

    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    true,
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(UISigninEvents.Signin, "EnterGame", bundle, resName, singles, numbers);



end 
--  执行 退出 消除逻辑
 function  Signin:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  Signin:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  Signin:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  Signin:Initial()
    


end

--
function  Signin.UserNameInput (obj,bb)
     

end 

function  Signin.UserNameInputEnd (aa,username)

this.Username = username

end 

function  Signin.PassWordInput (aa,bb)
     

end 

function  Signin.PassWordInputEnd (obj,password)

this.Password = password

end 

function  Signin.EnterBtnPress ()
--     print(this.Username);
--     print(this.Password);
    if this.Username == nil or this.Username == "" then
        this.Username = "null";
        this.Password = "null";
        this.SigninScript:OnClickOk(this.Hint,this.Username,this.Password);
        print(this.Password);
    elseif this.Password == nil or this.Password == "" then
        this.Username = "null";
        this.Password = "null";
        this.SigninScript:OnClickOk(this.Hint,this.Username,this.Password);
    else
        this.SigninScript:OnClickOk(this.Hint,this.Username,this.Password);
    end
end 

--注册界面exit按钮事件
function  Signin.ExitBtnPress ()
    print(UIEnterGameCommonEvents.SigninExit)
    local testMsg = LMsgBase:New(UIEnterGameCommonEvents.SigninExit)
    this:SendMsg(testMsg)

end 


-- 这里面 就是做一些 事件的处理
function  Signin:ProcessEvent(msg)
        if   msg.msgId  ==   UISigninEvents.Signin  then
              local  tmpObj = msg:GetBundleRes("Signin", "Signin.prefab");

              this.Object = this: InstantiatePlaneGameObje(tmpObj[0])


              this.SigninScript = this.Object:AddComponent(typeof(SigninSq))

              this:AddInputFiledLisenter("UserNameInput",this.UserNameInput,this.UserNameInputEnd);


              this:AddInputFiledLisenter("PassWordInput",this.PassWordInput,this.PassWordInputEnd);

              this:AddButtonLisenter("Enter",this.EnterBtnPress);
              this:AddButtonLisenter("Exit",this.ExitBtnPress);
             
                this.Hint = this:GetText("Hint")
                this.Hint.gameObject:SetActive(false);
                
                --获取进度条
                this.Progress = this:GetGameObject("Signin","ProgressSlider");
                this.Progress:SetActive(false);          

          elseif    msg.msgId  ==  UISigninEvents.Initia  then
              this:GetResoures();

        --点击exit消息，将signinPanel隐藏
        elseif msg.msgId == UIEnterGameCommonEvents.SigninExit then
            this.Object:SetActive(false); 
                       
        --登录成功，将signinPanel隐藏
        elseif msg.msgId == UIChooseRoleEvents.GetResources then
            print("收到注册C#发来的消息!");
            --将signin隐藏
            if this.Object ~= nil then          
                this.Object:SetActive(false)  
            end


        --加载进度条
        elseif msg.msgId == UIChooseRoleEvents.SigninProgressLoad then
            this.Progress:SetActive(true);  
            this.SigninScript:ProgressBarExecute(this.Progress);                                                            
        end

end