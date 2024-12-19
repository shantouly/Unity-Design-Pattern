# Unity Design Pattern  
# The Asset contains demos of various design patterns, some of which may have multiple corresponding implementations in various scenarios  
# Asset中包含的是各种设计模式的demo，有的可能有多种对应实现的多种场景  
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
## Object Pool Pattern对象池模式  
  The core idea of object pooling is not to delete it directly after use, but to put it back into the pool and retrieve it when needed.  
  In the development process of games, due to the frequent creation and deletion of game objects in many games, and the fact that game objects also contain a large number of objects,  
  object pool optimization techniques have been well applied.  
  对象池的核心思想：使用完不直接删除，而是将其放回池子里，需要的时候再取出来。在游戏的开发过程中，由于很多游戏的游戏对象创建和删除也很频繁，同时游戏对象也包含了非常多的对象，此时对象池的优化技术就有了很好的应用。  
### 对象池主要的两点优化  
  ·防止对象被频繁的创建和删除，从而内存抖动、频繁GC  
  ·对象的初始化成本较高  
### Main Functions 主要的方法  
  ·从对象池中获取对象。  
    从对象池中获取对象，如果是第一次获取物体要进行初始化。  
  ·将对象送到对象池中。  
    对象用完不用删除，将对象送回到对象池中。但是对象池中的对象的数量不能大于一个阈值，否则内存会爆。  
  ·对象池中对象的预热。  
    预加载一定数量对象池中的对象，这是一个较为重要的一个优化的点，如果不这样做，那么创建一个新对象也是需要时间的，如果在竞技游戏，这是耗时间的。
  ·对象池中对象的缩小。  
    如果对象池中的对象超过了该对象池中的阈值的话，是要进行删除的操作的，但是，删除一个对象也是需要消耗时间的，基于此，可以先不删除，等到加载界面的时候再删除也是可以的，这样可以给玩家一个更好的游戏体验。  
  ·对象池中对象的重置。  
    从对象池中每次取对象都必须要是新的，不能明显带有上次使用过的状态，因此，再每一次取对象之后要进行重置的操作，OnEnable中初始化对象。不在start中因为start只会执行一次的，OnEnable会在每次物体重新启用的时候执行。  
### 应用场景  
  ·频繁的创建或者删除对象。  
  ·游戏中包含了十分多的对象。  
## MVC Pattern Unity Model、View、Controller模式  
  The MVC pattern is a very common design pattern, also known as a framework.  
  It divides the program into three parts: model, view, and controller.  
  Using this pattern in Unity allows us to effectively separate the logic of the code and maintain and extend it effectively  
  MVC模式是一种十分常见的设计模式，也可以被称为一种框架。它将程序划分为三个部分：模型、视图、控制器。在Unity中使用这种模式可以很好地将程序的逻辑进行分离，有利于后续的维护和扩展  
### Structure 结构  
  ·Model：程序中数据和业务逻辑的表示，负责处理数据的存储和更新  
  ·View：程序中用户界面的表示，负责显示数据  
  ·Controller：程序中逻辑和交互的表示，用来控制Model、View，用更加具体的用户逻辑来处理Model中的数据和View中的数据的显示  
## AdapterPattern 适配器模式  
  Convert the interface of a class into another interface desired by the client,  
  so that classes that were originally unable to work together due to interface incompatibility can work together.  
  将一个类的接口转换成客户希望的另一个接口使得原本由于接口不兼容而无法一起工作的类可以协同工作。  
### Main Structure 主要的结构  
  ·目标接口（Target）：客户端期望使用的接口，它应该是适配了各种类的接口  
  ·适配者：已有的类，或者第三方的类，不满足客户的需求  
  ·适配器：将目标接口与适配者接口连接起来，实现接口转换  
### Main scene to use this pattern  
  ·对第三方插件进行封装适配  
  ·数据格式的转换  
## Strategy Pattern 策略模式  
  Define a series of algorithms or operations, encapsulate each algorithm, and make them interchangeable with each other.  
  策略模式定义一系列算法或者操作，将每一个算法封装起来，并且使得它们可以相互替换。使用策略模式可以让算法独立于使用它的客户端的代码的变化  
### Main Structure 主要的结构  
  ·Strategy Interface. 定义所有策略的公共接口  
  ·Concrete strategies. 实现接口的不同策略  
  ·Context. 持有一个策略对象，负责于客户端进行交互，并在需要时调用策略的方法  
### Main scene to use this pattern  
  ·角色行为的切换  
  ·AI决策逻辑：不同的AI的行为（巡逻、追击、逃跑）  
  ·文件的读取与处理：处理不同的文件的格式（这里用适配器模式也是可以的）  
  ·游戏难度模式的切换：切换简单、普通、困难模式下的规则或者算法（可能没有这么明显）  

