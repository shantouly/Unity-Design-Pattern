# Unity Design Pattern  
## Instance Pattern单例模式  
  Used to ensure that a class has only one instance and provide a global access point  
  用于确保一个类只有一个实例，并且提供全局访问点  
### 应用场景  
   通常在游戏中的各管理器中使用  
## Obeserver Pattern观察者模式  
  A one to many dependency relationship that allows multiple observer objects to simultaneously monitor the state changes of a subject object.  
  When the theme changes, all observers who rely on it will automatically receive notifications and respond accordingly.  
  一对多的依赖关系，让多个观察者对象同时监听一个主题对象的状态变化。当主题发生改变时，所有依赖于它的观察者都会自动收到通知并作出相应反应。  
  Obeserver Pattern其实本身就是一个消息系统
### 应用场景  
  1:事件的广播与监听：
    涉及到当玩家做出某一动作时，触发多个系统的变化时  
  2:模块间的通信  
    UI监听游戏状态的变化，根据游戏的状态来更新界面  
## State Machine Pattern Unity状态机模式  
  Used to manage the different states of objects and their transition logic between states,  
  by decomposing complex logic into states and transitions between states, making the code structure clearer and easier to maintain.  
  用于管理对象的不同状态及其状态之间的转换逻辑,通过将复杂的逻辑分解为状态和状态之间的转换，使代码结构更加清晰、易维护。  
### 应用场景  
  主要在角色行为控制、敌人AI、动画系统控制、UI状态管理等等使用。  
  StateMachine文件夹中包含了两种状态机模式的实现，一种是简易的实现，一种是优化版。  
