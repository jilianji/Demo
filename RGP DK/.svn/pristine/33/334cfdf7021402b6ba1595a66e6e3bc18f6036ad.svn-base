
--声明，这里声明了类名还有属性，并且给出了属性的初始值。
LLoding = LUIBase:New()

local this = LLoding;

--这句是重定义元表的索引，就是说有了这句，这个才是一个类。
LLoding.__index = LLoding ;



local transform = nil;
local gameObject = nil;


--构造体，构造体的名字是随便起的，习惯性改为New()
function LLoding:New() 
    local self = {};    --初始化self，如果没有这句，那么类所建立的对象改变，其他对象都会改变
    setmetatable(self, LLoding);  --将self的元表设定为Class

   self.msgIds = {};
   
    return self;    --返回自身
end


 function  LLoding.Awake(object)
    -- body

    gameObject = object.gameObject;
    transform = object.transform;

--   这里面 就干这么多事 不要加其它的 ;

end


function  LLoding.Regist()
         this.msgIds = {
         UILoginEvents.Login,
         UILoginEvents.Signin,
         UIChooseRoleEvents.GetResources,
         UIEnterGameCommonEvents.SigninExit,
         UIChooseRoleEvents.LoadinProgerssLoad
       };
       print("########################");
       this:RegistSelf(this,this.msgIds);

end 


this.Regist();




function LLoding.GetResourceBack(scence, bundle, reses, objes)

    -- LChoosePlayer1==     objes[1] ;

end 


function LLoding:ReleaseRes()
	-- body
   this:ReleaseRes(LAssetEvent.ReleaseBundleAndObjects, "LuaScence", "ChoosePlayer", nil);

end

function   LLoding:GetResoures()

-- bundle 对应的名字
local bundle = {
    "Login",
};

-- 以下 和上面的bundle 个数对应起来 数值 和resNames
-- 表示每个bundle 资源请求的个数   对应起来
local numbers = {

    1,
};

---  以下两个数组是一一对应关系
-- 一个一维数组表示每个bundle 里面资源的名字


------- -----------------------------这里面要加后缀 .prefab   .png----------BagUI0多个情况不用加----------
local resName = { "Login.prefab",

    };
     

---- ture 表示 单个 false 表示多个
local singles = {

    true,
};


--- 第一参数 表示  回调的你要接收的消息 
    
this:GetMutiBundlAndRes(UILoginEvents.Login, "EnterGame", bundle, resName, singles, numbers);



end 


this:GetResoures()
--  执行 退出 消除逻辑
 function  LLoding:Exist()
    
           transform = nil;
           gameObject = nil;
           this = nil ;

end


 function  LLoding:JumpNextView()
    
   local   testMsg = LMsgBase:New(LTCPEvent.SendMsg);

   SendMsg(testMsg)

   testMsg:ChangeEventId(LTCPEvent.RecvMsg)

   SendMsg(testMsg);

end


--  进行 重新设置值
 function  LLoding:Reset()
    


end


-- 外界的入口  进行初始化操作
 function  LLoding:Initial()
    


end




function   LLoding.UserNameInput (obj,bb)
     

end 

function   LLoding.UserNameInputEnd (aa,username)

this.Username = username

end 

function   LLoding.PassWordInput (aa,bb)
     

end 

function   LLoding.PassWordInputEnd (obj,password)

this.Password = password

end 




function  LLoding.ExitBtnPress ()

     this.LoginScript:ExitProgram()
     print(" 退出游戏  ");

end 

function  LLoding.EnterBtnPress ()

--     print("进入游戏");
     print(this.Username);
     print(this.Password);
     this.LoginScript:OnLoginButtonClick(this.Hint,this.Username,this.Password);
end 

function  LLoding.SignBtnPress ()
local SMsg=LMsgBase:New(UILoginEvents.Signin)
this:SendMsg(SMsg)
local SSMsg=LMsgBase:New(UISigninEvents.Initia)
this:SendMsg(SSMsg)

     print(" 注册游戏  ");

end 

function LLoding.ProgressBar()
    
end






-- 这里面 就是做一些 事件的处理

function  LLoding:ProcessEvent(msg)

      
         if   msg.msgId  ==   UILoginEvents.Login  then

              local  tmpObj = msg:GetBundleRes("Login", "Login.prefab");

                this.Object = this: InstantiatePlaneGameObje(tmpObj[0])

                
                this.LoginScript = this.Object:AddComponent(typeof(LoginSq))

                this:AddButtonLisenter("Exit",this.ExitBtnPress);
                this:AddButtonLisenter("Enter",this.EnterBtnPress);
                this:AddButtonLisenter("Sign",this.SignBtnPress);

                --将输入信息提示text隐藏
                this.Hint = this:GetText("Hint")
                this.Hint.gameObject:SetActive(false);

                --获取进度条
                this.Progress = this:GetGameObject("Login","ProgressSlider");
                this.Progress:SetActive(false);

              this:AddInputFiledLisenter("UserNameInput",this.UserNameInput,this.UserNameInputEnd);
              this:AddInputFiledLisenter("PassWordInput",this.PassWordInput,this.PassWordInputEnd);

              this.Object:SetActive(false)
              
              FrameTimer.New(LLoding.Update,0,-1):Start()


         elseif    msg.msgId  ==  UILoginEvents.Signin  then

             this.Object:SetActive(false)     
         elseif msg.msgId == UIChooseRoleEvents.GetResources then
             --将lodingPanel隐藏
             this.Object:SetActive(false)               
         
        elseif msg.msgId == UIEnterGameCommonEvents.SigninExit then
           this.Object:SetActive(true);  
           
         
        --加载进度条
        elseif msg.msgId == UIChooseRoleEvents.LoadinProgerssLoad then
            this.Progress:SetActive(true);  
            this.LoginScript:ProgressBarExecute(this.Progress);                                         
        end
end


this.bool=false;
function LLoding.Update()

if  Time.time>3.5 and this.bool==false then
if Input.anyKey then
this.bool=true
this.Object:SetActive(true)

end

end


end