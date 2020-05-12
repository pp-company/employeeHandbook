###<center>git快捷方式</center>

```git config --global alias.s status```

```git config --global alias.cm "!git add -A;git commit -am"```

```git config --global alias.m "merge --no-ff -Xignore-space-change"```
  
```git config --global alias.g "log --graph --oneline"```

```git config --global alias.nb !"f() { git d "$1"; git sc "$1"; }; f"```

```git config --global alias.pl "!git pull origin master:master"```

```git config --global alias.sc "switch -c"```

```git config --global alias.start "!git pl;git nb"```

```git config --global alias.d "branch -d"```

```git config --global alias.end "!git pl;git m $1"```

```git config --global alias.rb "! git pl; git rebase master;"```

<center> Copyright © 2020 珠海数镜空时科技有限公司 All Rights Reserved</center>
