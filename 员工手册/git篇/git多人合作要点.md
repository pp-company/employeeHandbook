###<center>git多人合作要点</center>
1. merge都要带 --no-ff。
2. 每次开新分支前记得一定先pull一下,push之前先pull，有事没事pull一下。
3. 早merge早脱手 越晚需要手动解决冲突的概率越大。但是当然需要做完整之后才merge。 
4. **严禁把不可以编译的代码在任何情况下merge到master**,可以push到自己的分支上(这个部关)
5. 除非是刚merge就马上想起来忘了做什么，可以马上重复利用刚才的分支，不然尽量不要重复回收利用之前的分支。
6. 没用的分支该删就删了 git branch -d 分支名。 git branch -D 分支名是强制删除 尽量别乱用。
7. **永远不要直接在master上 commit写东西**，建好你自己的分支 分支名跟你做的项目相关，如果没有合作人的话，建议在分支名带上自己名字的缩写，在你自己的分支上做修改 做好了merge回master。所以最好的习惯就是 merge完就马上切到自己的分支，不要临渴掘井等要commit了才去切换分支。
8. 如果你的分支还没完美到可以merge，但是又遇到了重大问题需要给同事或者老板看看， 参考[弃枝模式](git练习题.md)
<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>