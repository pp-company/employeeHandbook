#!/bin/sh

#1. 看状态
git config --global alias.s status

#2. 将所有已修改、已删除、新添加的文件添加到暂存区并且commit
git config --global alias.cm "!git add -A;git commit -am"

#3. 合并并且会自动忽略格式问题且留住分支结构
git config --global alias.m "merge --no-ff -Xignore-space-change"

#4. 看图
git config --global alias.g "log --graph --oneline"

#5. 强制创建新分支```$1```指传入的参数代表你的新分支名
git config --global alias.nb !"f(){ git d "$1";git sc "$1";};f"


#6. 更新主支
git config --global alias.pl "!git pull origin master:master"

#7. 创建并切换到新分支
git config --global alias.sc "switch -c"

#8. 开始新任务
git config --global alias.start "!git pl;git checkout master;git nb"

#9. 删除分支，如果删除不存在的分支会报错，但是没有关系
git config --global alias.d "branch -d"

#10. 结束任务，end之后如果有冲突手动解决冲突，然后马上手动进行push，（你不push你留着干啥呢？）
git config --global alias.end "!git pl; git checkout master; git m"
#11. 更新当前分支
git config --global alias.rb "!git pl; git rebase -Xignore-space-change master;"
#解释:当你做了一点点微小的修改尚且不值得merge但是又需要同步一下就用这个，如果你做了很多修改，不建议用这个。按理来说你做的一点点修改不至于导致冲突，但是如果冲突发生了，手动解决冲突后用```git add -A; git rebase --continue;```
#说明:使用git rb应该先把已有的改动cm，如果觉得cm尚早可以用git stash暂存，完成 git rb后（包括解决冲突后） 用git stash pop 放回来