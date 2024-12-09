# Unity Design Pattern  
## Commend Pattern 命令模式  
  Encapsulate a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests,and support undoable operations  
  命令模式将请求封装成对象，以便使用不同的请求、队列或者日志来参数化其他对象，同时支持可撤销的操作。  
### Main Structure 主要结构  
  ·Commend(base class):抽象类，要对外public一个execute方法，如果有撤销需求的还要public一个unexecute方法。  
  ·DerivedCommand：实现Commend类，重写Commend中的方法。  
  ·Invoker：调用的类，负责调用这些execute方法。  
  ·Receiver：接受类，负责接收这些动作，一般是游戏中的玩家对象或者是其他的游戏对象来接收。  
## Instance Pattern 单例模式  
  Used to ensure that a class has only one instance and provide a global access point  
  用于确保一个类只有一个实例，并且提供全局访问点  
### 应用场景  
   通常在游戏中的各管理器中使用  
## Factory Pattern 工厂模式  
  It provides an interface for creating objects, but the specific object creation logic is taken care of by the factory class.  
  Hides the details of object creation, and the client only needs to get the required object through the factory class, and does not need to care about the specific creation process of the object.  
  工厂模式它提供了一种创建对象的接口，但具体的对象创建逻辑由工厂类负责。隐藏了对象的创建细节，客户端只需要通过工厂类来获取所需的对象，而不需要关心对象的具体创建过程。  
### Advantage 优点  
  ·降低了客户端与创建对象之间的耦合度  
  ·通过工厂类统一来管理对象的创建，提高代码的可维护性和可扩展性  
  ·可以根据需要动态的来进行创建对象的切换，灵活度高  
### 应用场景  
  ·游戏中游戏对象的创建：在开发的过程中，可能要生成很多种的游戏对象，例如有子弹、敌人、一些道具等等，此时就可以通过工厂模式将游戏对象的创建逻辑封装在工厂类中。  
  ·游戏中资源的加载：在开发的过程中，可能有许多的资源需要进行加载，例如音效、模型等等，此时就可以通过工厂模式将这些资源的创建逻辑封装在工厂类中。  
  ·游戏中的UI界面：在开发的过程中，UI的界面是不止一种的，此时对UI的生成也可以采用工厂模式将这些UI的生成的逻辑封装在工厂类中。  
### Extend 工厂模式的扩展  
  ·简单工厂模式：只通过一个工厂类来创建对象，客户端根据需要创建对象的类型传递给工厂然后再创建相应类型的对象。  
  ·抽象工厂模式：提供一个抽象的工厂接口和一组具体的工厂实现类来创建一系列相关或依赖对象。  
## Obeserver Pattern 观察者模式  
  A one to many dependency relationship that allows multiple observer objects to simultaneously monitor the state changes of a subject object.  
  When the theme changes, all observers who rely on it will automatically receive notifications and respond accordingly.  
  一对多的依赖关系，让多个观察者对象同时监听一个主题对象的状态变化。当主题发生改变时，所有依赖于它的观察者都会自动收到通知并作出相应反应。  
  Obeserver Pattern其实本身就是一个消息系统
### 应用场景  
  1:事件的广播与监听：  
    涉及到当玩家做出某一动作时，触发多个系统的变化时  
  2:模块间的通信：  
    UI监听游戏状态的变化，根据游戏的状态来更新界面  
## State Machine Pattern Unity 状态机模式  
  Used to manage the different states of objects and their transition logic between states,  
  by decomposing complex logic into states and transitions between states, making the code structure clearer and easier to maintain.  
  用于管理对象的不同状态及其状态之间的转换逻辑,通过将复杂的逻辑分解为状态和状态之间的转换，使代码结构更加清晰、易维护。  
### 应用场景  
  主要在角色行为控制、敌人AI、动画系统控制、UI状态管理等等使用。  
  StateMachine文件夹中包含了两种状态机模式的实现，一种是简易的实现，一种是优化版。  
## MVC Pattern Unity Model、View、Controller模式  
  The MVC pattern is a very common design pattern, also known as a framework.  
  It divides the program into three parts: model, view, and controller.  
  Using this pattern in Unity allows us to effectively separate the logic of the code and maintain and extend it effectively  
  MVC模式是一种十分常见的设计模式，也可以被称为一种框架。它将程序划分为三个部分：模型、视图、控制器。在Unity中使用这种模式可以很好地将程序的逻辑进行分离，有利于后续的维护和扩展  
### Structure 结构  
  ·Model：程序中数据和业务逻辑的表示，负责处理数据的存储和更新  
  ·View：程序中用户界面的表示，负责显示数据  
  ·Controller：程序中逻辑和交互的表示，用来控制Model、View，用更加具体的用户逻辑来处理Model中的数据和View中的数据的显示  

