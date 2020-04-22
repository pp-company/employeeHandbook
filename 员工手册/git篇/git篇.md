##<center>git篇</center>
1. 每个人要申请额外的Bitbucket账号和github账号工作,因为离职的时候要把账号交还给公司的。
2. 对于没有保密需要的,在github上进行,比如员工手册,有保密需求,就用Bitbucket,比如平时的代码开发,如果不清楚有没有保密需求,直接问老板。
3. 学习git预计时间为17个小时，上下波动3小时，零基础大概20小时，有一点基础大概14小时，根据自己实际情况学习,学习期间需要掌握的[知识](git总结.md)。
4. 每个人要有一个github的练习账号,练习公司的[题目](git练习题.md)。
5. 写完git练习题之后，git练习题途中有什么不懂或者不了解的可以查看git练习题[提示](git练习题提示.md)。
6. 严禁使用可以修改历史的git操作。除非有老板明文授权。
7. 上传录音的时候注意文件大小不要超过100m(录音的时候建议超过80分钟就中断，再继续录音,如果不小心超过了，请查看如何减少[文件大小](https://jingyan.baidu.com/article/359911f550cf7757fe03063b.html)),仓库最大只能存放100G。
8. 之前被抛弃的commit突然发现有用可以用git reflog找回来。
9. 快捷方式：
    1. 看状态，将git status 设置成git s
    命令:git config --global alias.s status
    2. 将git commit -m设置成git cm
    命令:git config --global alias.cm "commit -am"
    3. 将git merge --no-ff设置成git m   
    命令：git config --global alias.m "merge --no-ff"
    4. 将log graph设置成git g   
    命令：git config --global alias.g "log --graph"
    5. 将switch -c 设置成sc
    命令:git config --global alias.sc "switch -c"
10. git add -A 把所有的文件全部添加到暂存区。
11. git commit -m "备注" 一定要写清楚，练习可以随便写，工作要清楚。
12. 改名操作很容易把git弄晕,所以使用git做改名操作的时候最好单独放在一个commit来做改名，即 改名前commit一下，改名后马上又commit一下，甚至多个改名的时候都建议先改一部分commit再改一部分，非硬性要求 自己斟酌。
13. 了解一下[ssh private key](https://confluence.atlassian.com/bitbucket/set-up-an-ssh-key-728138079.html),使用谷歌浏览器可以翻译成中文。
14. 解决每次都要输入密钥[问题](http://www.wechatbus.com/artifice/9.html)
15. git push 忽略空目录
16. github如何让别人管理自己的仓库
![img](img/添加权限1.jpg )
![img](img/添加权限2.jpg )
11. git多人合作要点
    1. merge都要带 --no-ff。
    2. 每次开新分支前记得一定先pull一下,push之前先pull，有事没事pull一下。
    3. 早merge早脱手 越晚需要手动解决冲突的概率越大。但是当然需要做完整之后才merge。 
    4. **严禁把不可以编译的代码在任何情况下merge到master**,可以push到自己的分支上(这个部关)
    5. 除非是刚merge就马上想起来忘了做什么，可以马上重复利用刚才的分支，不然尽量不要重复回收利用之前的分支。
    6. 没用的分支该删就删了 git branch -d 分支名。 git branch -D 分支名是强制删除 尽量别乱用。
    7. **永远不要直接在master上 commit写东西**，建好你自己的分支 分支名跟你做的项目相关，如果没有合作人的话，建议在分支名带上自己名字的缩写，在你自己的分支上做修改 做好了merge回master。所以最好的习惯就是 merge完就马上切到自己的分支，不要临渴掘井等要commit了才去切换分支。
    8. 如果你的分支还没完美到可以merge，但是又遇到了重大问题需要给同事或者老板看看， 参考弃枝模式（加入链接！！）推上来。