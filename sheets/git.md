---
title: git
---
# ローカル側の変更を捨てて、とにかくリモート側に合わせる
```
git reset --hard
git pull
```
# addの取り消し
```
git reset HEAD <filename>
```

# conflictが起きた時
```
git pull origin master (or main) # リモートの情報を取得、マージ
git push origin maser
```
もしくは
```
git push -f origin master
```

# 更新漏れや誤字修正を前のコミットに含める
```
git add A
git commit --amend --no-edit
```

# gitサーバを立てる
## リモート側(設定)
```
mcd mds.git
git init --bare --shared
git config --global init.defaultBranch main
```

## ローカル側(設定)
```
mcd mds
git init
git add .
git commit
git remote add origin ssh://usr@host/dir/repository.git
git config branch.master.remote origin
git config branch.master.merge refs/heads/main
```

## 新しいローカルリポジトリ
```
git clone ssh://user@host/dir/repository.git
git clone ssh://git@github.com/user/repository.git
```
