###<center>git快捷方式</center>
1. 看状态，将git status 设置成git s
```
命令:git config --global alias.s status
```
2. 将git commit -m设置成git cm
```
命令:git config --global alias.cm "!git add -A;git commit -am"
```
3. 将git merge --no-ff设置成git m   
```
命令：git config --global alias.m "merge --no-ff -Xignore-space-change"
```
4. 将--graph --oneline设置成git g   
命令：git config --global alias.g "log --graph --oneline"
5. 将branch -d $1; git sc $1 设置成nb,$1指传入的参数
```
命令:git config --global alias.nb !"f() { git d "$1"; git sc "$1"; }; f"
```
6. 将git switch master git pull origin master两条命令设置成pl
```
命令git config --global alias.pl "!git switch master;git pull origin master"
```
7. 将switch -c 设置成sc
···
命令:git config --global alias.sc "switch -c"
···
8. 将git pl;git start 
```
命令:git config --global alias.start "!git pl;git nb"
```
9. 将git branch -d设置成d 
命令：git config --global alias.d "branch -d"
10. 将git pl;git m $1设置成end
命令:git config --global alias.end "!git pl;git m $1"
<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>
