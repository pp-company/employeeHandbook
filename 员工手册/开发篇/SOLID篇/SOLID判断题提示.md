# <center>SOLID判断题</center>

1. 写代码经常重复是正常的
关键字是重复是正常的，那代码逻辑呢？有没有别的办法能够避免？
2. 不需要严格遵守SOLID原则
3. 代码不能出现重复（尽量什么都不要出现重复）
参考DRY原则
4. 每个类只能做一件事情，一个类只能有一个构造函数
参考S原则
5. 可以重复用构造函数
参考S原则
6. 不要用全局变量
7. 不要用静态
8. 不要用单例模式
9. 随机数生成器或许是唯一一个不合理的静态变量(全局变量)
10. 命名要太长可以缩写，比如魔术师写成mss
那你到时候要让别人怎么看懂你的代码？
11. 如果有多个同类型的变量，可以写成，如：学生1、学生2、学生3
这个变量名有没有意义？
12. 要把所有变量都写到get(),set()
你银行的钱能够让其他人随便转？随便设置?
13. 所有变量都不能public
跟上一条类似
14. 所有的private变量都应该是protected变量
已经禁止子类改变父类的代码了，还不能让子类继承父类之后去改变从父类继承过来的变量吗？
15. 避免if，switch结构，转而用多态去实现
重复
16. 不要重载,用多态
17. 扩展功能不应该改变现有功能
如果改变了现有功能，让其他正在使用这个功能的人怎么办？
18. 写了一些代码觉得以后会用到，但是现在没用到，那就注释起来，方便以后使用
不觉得commit更好吗?
19. 不要在代码里面出现数字/数据
常数是一种特殊的静态
20. 先想接口，再想实现
I原则
21. 不要在一个class的代码里面出现其他class的名字（接口不是class）
D原则
22. 不要用null
L原则
23. 要用枚举(enum)
用了枚举可以多态?
24. 不要用String去影响代码逻辑，除非是在数据库业务密切相关的情况下或者是远程请求密切相关的情况下
25. 使用任何第三方工具的时候，发现该第三方工具没有接口，要先去实现它的接口再去使用它
I原则
26. 不要把print当成debug的工具。
27. 需要什么就注入什么
28. 与S准则无关却必要的东西不要自己去造，不要自己去猜，注入进来。
29. 当几个程序的运行顺序很关键的时候用依赖注入去确保他们的顺序
30. 所有以上的规范都要在开发环境下严格执行（测试环境和配置环境不属于开发环境）

<center> Copyright © 2021 天下数学引擎科技（深圳）有限公司 All Rights Reserved</center>
